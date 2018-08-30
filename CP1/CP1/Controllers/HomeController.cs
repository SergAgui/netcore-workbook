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
        private readonly IApptRepository repository;
        public HomeController(IApptRepository repository)
        {
            this.repository = repository;
        }
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
        public ActionResult CustomerDetails(Customer cust)
        {
            repository.AddCust(cust);
            return View(cust);
        }

        [HttpPost]
        public ActionResult ProviderDetails(ServiceProvider prov)
        {
            repository.AddServProv(prov);
            return View(prov);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
