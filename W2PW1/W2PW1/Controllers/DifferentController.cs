using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace W2PW1.Controllers
{
    public class DifferentController : Controller
    {
        public IActionResult Different()
        {
            return View();
        }
    }
}