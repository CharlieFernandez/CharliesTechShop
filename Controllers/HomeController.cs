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
    public class HomeController : Controller
    {
        private readonly ITechRepository _techRepository;

        public HomeController(ITechRepository techRepository)
        {
            _techRepository = techRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                MostPopularTech = _techRepository.MostPopularTech
            };            

            return View(homeViewModel);
        }
    }
}
