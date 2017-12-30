﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookApp.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Index()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                return new RedirectResult("/");
            }
            return new ContentResult()
            {
                Content = "Hello from ComicBook Detail page!"
            };
        }
    }
}