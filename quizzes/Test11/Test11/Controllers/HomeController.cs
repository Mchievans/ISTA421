using Microsoft.AspNetCore.Mvc;
using Test11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Test11.Controllers
{
    public class HomeController : Controller
    {
        People PeopleList = People.UsableListofPeople;

        public ActionResult Index() 
        {  
            return View("Index");
        }

        [HttpGet]
        public IActionResult AddPeopleToList()
        {
            return View(new Person());
        }

        [HttpPost]
        public IActionResult AddPeopleToList(Person p)
        {
            People.AddPeopleInfo(p);
            return RedirectToAction("Index");
        }
    }
}
