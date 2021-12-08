using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoshuaAllison_TermProject.Controllers
{
    public class WeaponArtController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
