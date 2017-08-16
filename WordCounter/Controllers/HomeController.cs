using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("/results")]
        public ActionResult Results()
        {
            string chosenWord = (Request.Form["chosen-word"]);
            string userString = (Request.Form["user-string"]);
            RepeatCounter newCount = new RepeatCounter (chosenWord, userString);
            int countOutput = newCount.CountRepeats();
            return View(countOutput);
        }

    }
}
