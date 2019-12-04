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

        public ViewResult List()
        {
            TechListViewModel techListViewModel = new TechListViewModel();

            techListViewModel.Tech = _techRepository.AllTech;
            techListViewModel.CurrentCategory = "Special Tech!";

            return View(techListViewModel);
        }
    }
}
