using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CP1.Models;

namespace CP1.Controllers
{
    public class HomeController : Controller
    {
        // GET : Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        // POST : Home / Details
        [HttpPost]
        public ActionResult CustomerDetails(Customer appt)
        {
            
            return View(appt);
        }

        [HttpPost]
        public ActionResult ProviderDetails(ServiceProvider prov)
        {
            TryUpdateModelAsync(prov);
            return View(prov);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
