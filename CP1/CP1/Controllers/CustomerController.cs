using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CP1.Models;

namespace CP1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IApptRepository repository;

        public CustomerController(IApptRepository appt)
        {
            repository = appt;
        }
        public IActionResult Index()
        {
            return View(repository.GetAllCustomers());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            if (ModelState.IsValid)
            {
                repository.AddCust(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        public IActionResult Remove(int id)
        {
            repository.RmvCustById(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var cust = repository.GetCustomer(id);
            return View(cust);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                repository.UpdateCustomer(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }
    }
}