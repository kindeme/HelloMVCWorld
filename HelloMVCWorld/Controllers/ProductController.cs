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
            return Content("Product overview");
        }

        public IActionResult List()
        {
            return Content("Product list");
        }

        public IActionResult Details(int id)
        {
            return Content("Product details for #" + id);
        }
    }
}
