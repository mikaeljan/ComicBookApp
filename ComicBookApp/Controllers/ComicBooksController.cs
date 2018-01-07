using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookApp.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.IssueNumber = 700;
            ViewBag.issueDescription = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.seriesTitle = "The Amazing Spider-Man";
            ViewBag.artists = new string[]
            {
            "Script: Dan Slott",
            "Pencils: Humberto Ramos",
            "Inks: Victor Olazaba",
            "Colors: Edgar Delgado",
            "Letters: Chris Eliopoulos"
                };


            return View();
        }
    }
}