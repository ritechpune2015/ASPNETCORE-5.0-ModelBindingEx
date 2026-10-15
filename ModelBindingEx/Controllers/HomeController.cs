using Microsoft.AspNetCore.Mvc;
using ModelBindingEx.Models;
using System;

namespace ModelBindingEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer c)
        {
    
            return View();
        }
    }
}
