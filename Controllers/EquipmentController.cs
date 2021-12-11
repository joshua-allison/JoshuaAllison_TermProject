using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using JoshuaAllison_TermProject.Models;

namespace JoshuaAllison_TermProject.Controllers
{
    public class EquipmentController : Controller
    {
        private DS3ItemContext Context { get; set; }

        public EquipmentController(DS3ItemContext ctx)
        {
            Context = ctx;
        }
        public void addDBListsToViewBag()
        {
            //Theres a lot of entities related to equipment that need to be added to the ViewBag, so it makes sense to just write a function that just loads them all up at once, so I don't have to keep writing it out.
            ViewBag.WeaponArts = Context.WeaponArts.OrderBy(w => w.Name).ToList();
            ViewBag.ItemCategories = Context.ItemCategories.OrderBy(c => c.Name).ToList();
            ViewBag.ItemSubcategories = Context.ItemSubcategories.OrderBy(s => s.Name).ToList();
            ViewBag.AuxillaryEffects = Context.AuxillaryEffects.OrderBy(a => a.Name).ToList();
            return;
        }
        public IActionResult List()
        {
            addDBListsToViewBag();
            var equipments = Context.Equipments.OrderBy(e => e.Name).ToList();
            return View(equipments);
        }
        public ActionResult SearchPage(string searchString)
        {
            ViewBag.Action = "Search";
            Debug.Print(searchString);
            return View(Context.Equipments.Where(e =>
                e.Name.Contains(searchString) ||
                e.FlavorText.Contains(searchString) ||
                e.ItemSubcategory.Name.Contains(searchString)).ToList());
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            addDBListsToViewBag();
            return View("Edit", new Equipment());
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            ViewBag.Action = "Details";
            addDBListsToViewBag();
            var equipment = Context.Equipments.Find(id);
            Context.SaveChanges();
            return View(equipment);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            addDBListsToViewBag();
            var equipment = Context.Equipments.Find(id);
            Context.SaveChanges();
            return View(equipment);
        }

        [HttpPost]
        public IActionResult Edit(Equipment equipment)
        {
            if (ModelState.IsValid)
            {
                if (equipment.EquipmentId == 0)
                    Context.Equipments.Add(equipment);
                else
                    Context.Equipments.Update(equipment);
                Context.SaveChanges();
                return RedirectToAction("Index", "Home");
            } else {
                ViewBag.Action = (equipment.EquipmentId == 0) ? "Add" : "Edit";
                Context.SaveChanges();
                addDBListsToViewBag();
                return View(equipment);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var equipment = Context.Equipments.Find(id);
            return View(equipment);
        }

        [HttpPost]
        public IActionResult Delete(Equipment equipment)
        {
            Context.Equipments.Remove(equipment);
            Context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
