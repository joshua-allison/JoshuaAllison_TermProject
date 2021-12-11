﻿using JoshuaAllison_TermProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JoshuaAllison_TermProject.Controllers
{
    public class HomeController : Controller
    {
        /*  I'm not sure why the code below isn't compatible with the code that follows.
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        DS3ItemContext db = new DS3ItemContext();

        public IActionResult Index(string searching)
        {
            return View(db.Equipments.Where(e =>
                e.Name.Contains(searching) ||
                e.FlavorText.Contains(searching) ||
                e.ItemSubcategory.Name.Contains(searching) ||
                searching == null).ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
