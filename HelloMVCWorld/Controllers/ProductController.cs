using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCWorld.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

     
        public IActionResult Details(int id)
        {
            ViewBag.ProductTitle = "Toilet Paper";
            ViewBag.ProductPrice = 1.99;
            return View();
        }
    }
}
