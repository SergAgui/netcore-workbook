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
            return View(repository.Appointments);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Appointment appt)
        {
            if (ModelState.IsValid)
            {
                repository.AddAppt(appt);
                return RedirectToAction(nameof(Index));
            }
            return View(appt);
        }
        [HttpGet]
        public IActionResult Add(Customer customer, ServiceProvider provider)
        {
            return View();
        }

        public IActionResult Remove(Guid id)
        {
            repository.RemoveApptById(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(Guid id)
        {
            var appt = repository.GetAppointment(id);
            return View(appt);
        }
        [HttpPost]
        public IActionResult Edit(Appointment appt)
        {
            if (ModelState.IsValid)
            {
                repository.UpdateAppt(appt);
                return RedirectToAction(nameof(Index));
            }
            return View(appt);
        }
    }
}