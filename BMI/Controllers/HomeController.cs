using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BMI.Controllers
{
    public class HomeController : Controller
    {
        private List<Person> list = new List<Person>();
        public IActionResult Index()
        {
            List<Person> list = new List<Person>();
            ViewData["Perosns"] = list.ToList();
            ViewBag.Persons = list;
            return View();
        }

        public IActionResult Add(Person person)
        {
            list.Add(person);
            ViewBag.Persons = list;
            return View(person);
        }
    }
}
