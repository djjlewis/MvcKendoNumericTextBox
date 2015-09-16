using MvcKendoNumericTextBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKendoNumericTextBox.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Person> people = new List<Person>
        {
            new Person
            {
                Id  = 1,
                Name = "John",
                Age = 22M
            },
            new Person
            {
                Id  = 2,
                Name = "George",
                Age = 20M
            },
            new Person
            {
                Id  = 3,
                Name = "Paul",
                Age = 23M
            },
        };

        // GET: Home
        public ActionResult Index()
        {
            return View(people);
        }

        // GET: Home
        public ActionResult Create()
        {
            var model = new Person();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                model.Id = people.Max(m => m.Id) + 1;
                people.Add(model);
                return RedirectToAction("Index");
            }
        }
    }
}