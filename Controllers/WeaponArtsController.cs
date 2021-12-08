using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoshuaAllison_TermProject.Controllers
{
    public class WeaponArtsController : Controller
    {
        public IActionResult WeaponArts()
        {
            return View();
        }
    }
}
