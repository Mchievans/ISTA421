using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test11.v2.Models;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Test11.v2.Controllers
{
    public class HomeController : Controller
    {
        PeopleRepository PeopleList = PeopleRepository.UsableListofPeople;

        public IActionResult Index()
        {
            return View(PeopleRepository.GetPeopleInfo);
        }

        [HttpGet]
        public IActionResult AddPerson()
        {
            return View(new Person());
        }

        [HttpPost]
        public IActionResult AddPerson(Person p)
        {
            PeopleList.AddPeopleInfo(p);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0,Location = ResponseCacheLocation.None,NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult SearchPerson()
        {
            
            return View(new PersonSearch());
        }

        [HttpPost]
        public IActionResult SearchPersonel(PersonSearch p)
        {
            PeopleRepository.SearchPeopleInfo(p);
            return View(PeopleRepository.SearchPeopleInfo(p));
        }
    }
}
