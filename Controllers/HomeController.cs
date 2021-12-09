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
        /* Not sure why how to include the following code without an error... yet...
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
            List<Equipment> items = context.Equipments.OrderBy(e => e.Name).ToList();
            return View(items);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
