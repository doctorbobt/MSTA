using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movies.Models;

namespace Movies.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private MoviesDbContext _dbContext;
        public HomeController(MoviesDbContext context)
        {
            _dbContext = context;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var movies = from m in _dbContext.Movies
                         orderby m.Title
                         select m;
            return View(movies);
        }
        public IActionResult Create()
        {
            Movie newMovie = new Movie();
            return View(newMovie);
        }
        [HttpPost]
        public IActionResult Create(Movie newMovie)
        {
            if (!ModelState.IsValid)
            {
                return View(newMovie);
            }
            else
            {
                _dbContext.Movies.Add(newMovie);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        public IActionResult Edit(int id)
        {
            Movie movie = _dbContext.Movies.SingleOrDefault(m => m.MovieId == id);
            if (movie == null)
            {
                return new NotFoundResult();
            }
            return View(movie);
        }
        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            _dbContext.Update(movie);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
