using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SecondCharliesTechShop.Models;
using SecondCharliesTechShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SecondCharliesTechShop.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Authorize(Policy = "DeleteTech")]
    public class TechManagementController : Controller
    {
        private readonly ITechRepository _techRepository;
        private readonly ICategoryRepository _categoryRepository;

        public TechManagementController(ITechRepository techRepository, ICategoryRepository categoryRepository)
        {
            _techRepository = techRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult Index()
        {
            var tech = _techRepository.AllTech.OrderBy(t => t.TechId);
            return View(tech);
        }

        public IActionResult AddTech()
        {
            var categories = _categoryRepository.AllCategories;
            var techEditViewModel = new TechEditViewModel
            {
                Categories = categories.Select(c => new SelectListItem() { Text = c.CategoryName, Value = c.CategoryId.ToString() }).ToList(),
                CategoryId = categories.FirstOrDefault().CategoryId
            };
            return View(techEditViewModel);
        }

        [HttpPost]
        public IActionResult AddTech(TechEditViewModel techEditViewModel)
        {
            //Basic validation
            if (ModelState.IsValid)
            {
                _techRepository.CreateTech(techEditViewModel.Tech);
                return RedirectToAction("Index");
            }
            return View(techEditViewModel);
        }

        public IActionResult EditTech(int techId)
        {
            var categories = _categoryRepository.AllCategories;

            var tech = _techRepository.AllTech.FirstOrDefault(t => t.TechId == techId);

            var techEditViewModel = new TechEditViewModel
            {
                Categories = categories.Select(c => new SelectListItem() { Text = c.CategoryName, Value = c.CategoryId.ToString() }).ToList(),
                Tech = tech,
                CategoryId = tech.CategoryId
            };

            var item = techEditViewModel.Categories.FirstOrDefault(c => c.Value == tech.CategoryId.ToString());
            item.Selected = true;

            return View(techEditViewModel);
        }

        [HttpPost]
        public IActionResult EditTech(TechEditViewModel techEditViewModel)
        {
            techEditViewModel.Tech.CategoryId = techEditViewModel.CategoryId;

            if (ModelState.IsValid)
            {
                _techRepository.UpdateTech(techEditViewModel.Tech);
                return RedirectToAction("Index");
            }
            return View(techEditViewModel);
        }

        [HttpPost]
        public IActionResult DeleteTech(string techId)
        {
            return View();
        }

    }
}
