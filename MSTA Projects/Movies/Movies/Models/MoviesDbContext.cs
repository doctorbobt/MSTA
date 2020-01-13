using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Movies.Models
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    MovieId = 1,
                    Title = "Rudolf the Red Nosed Reindeer",
                    Genre = "Christmas",
                    LastWatched = "12/25/2019"
                },
                new Movie()
                {
                    MovieId = 2,
                    Title = "Wizard of Oz",
                    Genre = "Fantasy",
                    LastWatched = "12/01/2019"
                }
             );
        }
    }
}

