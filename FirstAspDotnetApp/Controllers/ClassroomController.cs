using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstAspDotnetApp.ViewModels.Classroom;

namespace FirstAspDotnetApp.Controllers
{
    public class ClassroomController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexViewModel();
            return View(model);
        }

        public IActionResult Students()
        {
            var model = new IndexViewModel();
            return View(model);
        }
    }
}
