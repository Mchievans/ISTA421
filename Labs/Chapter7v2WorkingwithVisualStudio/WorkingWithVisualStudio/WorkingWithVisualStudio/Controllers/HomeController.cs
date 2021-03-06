﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WorkingWithVisualStudio.Models;

namespace WorkingWithVisualStudio.Controllers
{
    public class HomeController : Controller
    {

        SimpleRepository Repository = SimpleRepository.SharedRepository;

        public IActionResult Index()
        {
            return View(Repository.Products.Where(p => p?.Price < 50));
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            Repository.AddProduct(p);
            return RedirectToAction("Index");
        }
    }
}