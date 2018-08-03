using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Controllers
{
    public class CopyWriteViewComponent : BaseViewComponent
    {
        public override IViewComponentResult Invoke()
        {
            return View();
        }
    }
    public abstract class BaseViewComponent : ViewComponent
    {
        public abstract IViewComponentResult Invoke();
    }
}
