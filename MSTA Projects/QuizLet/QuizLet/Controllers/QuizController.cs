using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizLet.Models;
using QuizLet.Services;

namespace QuizLet.Controllers
{
    public class QuizController : Controller
    {
        QuestionsContext ctx = new QuestionsContext();
        IScore _score;
        public QuizController(IScore score)
        {
            _score = score;
        }
        public IActionResult Index()
        {
            _score.Correct = 0;
            _score.Wrong = 0;
            return View();
        }
        public IActionResult Question(int? id)
        {
            if (id == null)
            {
                id = 0;
            } else if (id == ctx.Questions.Count)
            {
                ViewBag.Correct = _score.Correct;
                ViewBag.Wrong = _score.Wrong;
                return View("Results");
            }
            Question question = new Question();
            if (id != null)
            {
                question = ctx.Questions[(int)id];
            }
            else
            {
                question = ctx.Questions[0];
            }
            return View("Question", question);
        }
        public IActionResult Answer(int qn, int an)
        {
            Question question = ctx.Questions[qn];
            if (question.CorrectAnswer == an)
            {
                ViewBag.Response = "You got that one correct!";
                _score.Score(true);
            }
            else
            {
                ViewBag.Response = "Sorry, you missed that one - the answer is " + question.Answers[question.CorrectAnswer];
                _score.Score(false);
            }
            ViewBag.NextQuestion = qn + 1;
            return View();
        }
    }
}
