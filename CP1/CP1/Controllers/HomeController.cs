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

        [HttpPost]
        public ActionResult Index(Appointment appointment)
        {
            int? appointmentId = appointment.Id;
            string name = appointment.Name;
            string provider = appointment.Provider;
            string hours = appointment.WorkHours;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
