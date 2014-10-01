using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class WorkController : Controller
    {
        //
        // GET: /Work/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Battleship()
        {
            spKevinEntities db = new spKevinEntities();
            return View(db.HighScores.Where(x => x.Game == "Battleship").OrderBy(x => x.Score));
        }

        public ActionResult Hangman()
        {
            spKevinEntities db = new spKevinEntities();
            return View(db.HighScores.Where(x => x.Game == "Hangman").OrderBy(x => x.Score));
        }

        public ActionResult PokerHands()
        {
            spKevinEntities db = new spKevinEntities();
            return View();
        }

        public ActionResult Trivia()
        {
            spKevinEntities db = new spKevinEntities();
            return View(db.HighScores.Where(x => x.Game == "Trivia").OrderBy(x => x.Score));
        }

    }
}
