using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArGuessingGame.Models;

namespace ArGuessingGame.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            Session["Answer"] = new Random().Next(1, 50);
            return View();
        }

        private bool GuessIsCorrect(int guess)
        {
            return guess == (int)Session["Answer"];
        }

       [HttpPost]
       [ValidateAntiForgeryToken]

        public ActionResult Index(AngieGame model)
        {
           if (ModelState.IsValid)
            {
                ViewBag.Win = GuessIsCorrect(model.Guess);
            }

            return View(model);
        }
    }
}