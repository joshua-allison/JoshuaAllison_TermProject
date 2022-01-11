using JoshuaAllison_TermProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

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
        private DS3ItemContext Context { get; set; }

        public HomeController(DS3ItemContext ctx)
        {
            Context = ctx;
        }
        public IActionResult Index(string searching)
        {
            ViewBag.ItemCategories = Context.ItemCategories.OrderBy(c => c.Name).ToList();
            ViewBag.ItemSubcategories = Context.ItemSubcategories.OrderBy(s => s.Name).ToList();
            return View(Context.Equipments.Where(e =>
                e.Name.Contains(searching) ||
                e.FlavorText.Contains(searching) ||
                e.ItemSubcategory.Name.Contains(searching) ||
                e.ItemSubcategory.itemCategory.Name.Contains(searching) ||
                e.weaponArt.Name.Contains(searching) ||
                e.weaponArt.Description.Contains(searching) ||
                searching == null).ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
