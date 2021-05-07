using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizGame.Repository;

namespace QuizGame.Controllers
{
    public class QuizGameController : Controller
    {
        private readonly QuizGameDbContext _quizdb;

        public QuizGameController(QuizGameDbContext quizdb)
        {
            _quizdb = quizdb;
        }
        public IActionResult Index()
        {        
            var model = _quizdb.QuizGameTables.ToList();
            return View(model);     
        }
    }
}
