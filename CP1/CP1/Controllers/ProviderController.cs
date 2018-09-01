using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CP1.Models;

namespace CP1.Controllers
{
    public class ProviderController : Controller
    {
        private readonly IApptRepository repository;
        public ProviderController(IApptRepository appt)
        {
            repository = appt;
        }
        public IActionResult Index()
        {
            return View(repository.ServiceProviders);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ServiceProvider provider)
        {
            if (ModelState.IsValid)
            {
                repository.AddProv(provider);
                return RedirectToAction(nameof(Index));
            }
            return View(provider);
        }


        public IActionResult Remove(Guid id)
        {
            repository.RemoveProvById(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(Guid id)
        {
            var prov = repository.GetProvider(id);
            return View(prov);
        }
        [HttpPost]
        public IActionResult Edit(ServiceProvider provider)
        {
            if (ModelState.IsValid)
            {
                repository.UpdateProvider(provider);
                return RedirectToAction(nameof(Index));
            }
            return View(provider);
        }
    }
}