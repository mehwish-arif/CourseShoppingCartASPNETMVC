using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CouseCatalogueMVC.Models;

namespace CouseCatalogueMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICourseRepository courseRepository;
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(ICourseRepository courseRepository, ShoppingCart cart)
        {
            this.courseRepository = courseRepository;
            this.shoppingCart = cart;
        }
        public IActionResult Index()
        {
            shoppingCart.ShoppingCartItems = shoppingCart.GetShoppingCartItems();
            return View(shoppingCart);
        }

        public RedirectToActionResult AddToShoppingCart(int courseId)
        {
            var SelectedCourse = courseRepository.GetCourseById(courseId);
            shoppingCart.AddItemToCart(SelectedCourse, SelectedCourse.Fee);

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int courseId)
        {
            var selectedCourse = courseRepository.GetCourseById(courseId);
            shoppingCart.RemoveItemFromCart(selectedCourse);
            return RedirectToAction("Index");
        }
    }
}
