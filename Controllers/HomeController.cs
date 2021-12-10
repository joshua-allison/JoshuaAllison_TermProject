using JoshuaAllison_TermProject.Models;
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
        private DS3ItemContext context { get; set; }

        public HomeController(DS3ItemContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            ViewBag.WeaponArts = context.WeaponArts.OrderBy(w => w.Name).ToList();
            ViewBag.ItemCategories = context.ItemCategories.OrderBy(c => c.Name).ToList();
            ViewBag.ItemSubcategories = context.ItemSubcategories.OrderBy(s => s.Name).ToList();
            ViewBag.AuxillaryEffects = context.AuxillaryEffects.OrderBy(a => a.Name).ToList();
            var equipments = context.Equipments.OrderBy(e => e.Name).ToList();
            return View(equipments);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
