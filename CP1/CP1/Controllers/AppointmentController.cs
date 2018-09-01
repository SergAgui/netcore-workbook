using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CP1.Models;

namespace CP1.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IApptRepository repository;

        public AppointmentController(IApptRepository appt)
        {
            repository = appt;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}