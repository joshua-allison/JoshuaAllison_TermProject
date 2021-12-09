using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JoshuaAllison_TermProject.Models;

namespace JoshuaAllison_TermProject.Controllers
{
    public class EquipmentController : Controller
    {
        private DS3ItemContext context { get; set; }

        public EquipmentController(DS3ItemContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Subcategories = context.Subcategories.OrderBy(s => s.SubcategoryName).ToList();
            ViewBag.WeaponArts = context.WeaponArts.OrderBy(w => w.Name).ToList();
            context.SaveChanges();
            return View("Edit", new Equipment());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Subcategories = context.Subcategories.OrderBy(s => s.SubcategoryName).ToList();
            ViewBag.WeaponArts = context.WeaponArts.OrderBy(w => w.Name).ToList();
            var item = context.Equipments.Find(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Equipment item)
        {
            if (ModelState.IsValid)
            {
                if (item.EquipmentId == 0)
                    context.Equipments.Add(item);
                else
                    context.Equipments.Update(item);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (item.EquipmentId == 0) ? "Add" : "Edit";
                ViewBag.Subcategories = context.Subcategories.OrderBy(s => s.SubcategoryName).ToList();
                ViewBag.WeaponArts = context.WeaponArts.OrderBy(w => w.Name).ToList();
                ViewBag.AttackTypes = 
                context.SaveChanges();
                return View(item);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = context.Equipments.Find(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(Equipment item)
        {
            context.Equipments.Remove(item);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}
