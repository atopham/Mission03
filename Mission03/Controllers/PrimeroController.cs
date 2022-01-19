using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission03.Models;

namespace Mission03.Controllers
{
    public class PrimeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Grade()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Grade(GradeModel model)
        {
            return View();
        }
    }
}
