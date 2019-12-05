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
    public class ShoppingCartController : Controller
    {
        private readonly ITechRepository _techRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ITechRepository techRepository, ShoppingCart shoppingCart)
        {
            _techRepository = techRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int techId)
        {
            var selectedTech = _techRepository.AllTech.FirstOrDefault(t => t.TechId == techId);

            if (selectedTech != null)
                _shoppingCart.AddToCart(selectedTech, 1);

            return RedirectToAction("Index");
        }
    }
}
