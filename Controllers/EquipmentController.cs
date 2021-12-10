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
        public void addListsToViewBag()
        {
            ViewBag.WeaponArts = context.WeaponArts.OrderBy(w => w.Name).ToList();
            ViewBag.ItemCategories = context.ItemCategories.OrderBy(c => c.Name).ToList();
            ViewBag.ItemSubcategories = context.ItemSubcategories.OrderBy(s => s.Name).ToList();
            ViewBag.AuxillaryEffects = context.AuxillaryEffects.OrderBy(a => a.Name).ToList();
            return;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            addListsToViewBag();
            return View("Edit", new Equipment());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            addListsToViewBag();
            var equipment = context.Equipments.Find(id);
            return View(equipment);
        }

        [HttpPost]
        public IActionResult Edit(Equipment equipment)
        {
            if (ModelState.IsValid)
            {
                if (equipment.EquipmentId == 0)
                    context.Equipments.Add(equipment);
                else
                    context.Equipments.Update(equipment);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (equipment.EquipmentId == 0) ? "Add" : "Edit";
                addListsToViewBag();
                return View(equipment);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var equipment = context.Equipments.Find(id);
            return View(equipment);
        }

        [HttpPost]
        public IActionResult Delete(Equipment equipment)
        {
            context.Equipments.Remove(equipment);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
