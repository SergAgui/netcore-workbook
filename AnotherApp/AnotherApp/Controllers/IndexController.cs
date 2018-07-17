using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnotherApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnotherApp.Controllers
{
    public class IndexController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new Hello();
            model.CurrentTime = DateTime.Today;
            return View(model);
        }
    }
}
