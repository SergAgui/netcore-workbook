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


        [HttpPost]
        public IActionResult Add(Appointment appointment)
        {
            try
            {
                repository.NewAppt(appointment);
                return View("Index", repository.Appointments);
            }
            catch
            {
                ViewBag.message = "Not a valid appointment.";
                return View("Index", repository.Appointments);
            }
        }


        [HttpGet]
        public IActionResult Add(Customer customer, ServiceProvider serviceProvider)
        {
            List<ServiceProvider> NewProvider = new List<ServiceProvider>();
            foreach (var provider in repository.ServiceProviders)
            {
                NewProvider.Add(provider);
            }

            ViewData["NewProvider"] = NewProvider;

            List<Customer> NewCustomer = new List<Customer>();
            foreach (var cust in repository.Customers)
            {
                NewCustomer.Add(cust);
            }

            ViewData["NewCustomer"] = NewCustomer;

            return View();
        }


        public IActionResult Remove(Guid id)
        {
            repository.RemoveApptById(id);
            return RedirectToAction(nameof(Index));
        }
    }
}