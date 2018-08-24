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
        public ActionResult Details(Appointment appointment)
        {
            var id = appointment.Id;
            var name = appointment.Name;
            var provider = appointment.Provider;
            var hours = appointment.WorkHours;
            TryUpdateModelAsync(appointment);
            return View(appointment);
        }

        [HttpGet]
        public ActionResult Details(int? id, Appointment appointment)
        {
            id = appointment.Id;
            return View(appointment);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
