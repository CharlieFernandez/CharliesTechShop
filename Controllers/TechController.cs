using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondCharliesTechShop.Models;
using SecondCharliesTechShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SecondCharliesTechShop.Controllers
{
    public class TechController : Controller
    {
        private readonly ITechRepository _techRepository;
        private readonly ICategoryRepository _categoryRepository;

        public TechController(ITechRepository techRepository, ICategoryRepository categoryRepository)
        {
            _techRepository = techRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Tech> tech;
            string currentCategory;

            if(string.IsNullOrEmpty(category))
            {
                tech = _techRepository.AllTech.OrderBy(t => t.TechId);
                currentCategory = "All tech";
            }
            else
            {
                tech = _techRepository.AllTech.Where(c => c.Category.CategoryName == category).OrderBy(t => t.TechId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new TechListViewModel
            {
                Tech = tech,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var tech = _techRepository.GetTechById(id);

            if (tech == null)
                return NotFound();

            return View(tech);
        }
    }
}
