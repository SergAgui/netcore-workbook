using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnotherApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnotherApp.Controllers
{
    public class _MyLayoutController : Controller
    {
        public IActionResult Index()
        {
            var otherLayout = new Layout2();
            otherLayout.TwoMinute = DateTime.Today;
            return View(otherLayout);
        }
    }
}