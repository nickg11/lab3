using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab3.models;

namespace lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Razor() => View();

        [HttpPost]
        public IActionResult Count()
        {
            ViewData["bottles"] = Request.Form["bottles"];
            return View();
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]
        public IActionResult DisplayPerson()
        {
            ViewData["first"] = Request.Form["first"];
            ViewData["last"] = Request.Form["last"];
            ViewData["email"] = Request.Form["email"];
            ViewData["age"] = Request.Form["age"];
            ViewData["DoB"] = Request.Form["DoB"];
            ViewData["password"] = Request.Form["password"];
            ViewData["description"] = Request.Form["description"];
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
