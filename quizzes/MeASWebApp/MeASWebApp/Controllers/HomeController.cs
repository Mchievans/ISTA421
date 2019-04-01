using MeASWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeASWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Malachi malachi = new Malachi
            {
                HairColor = "Black",
                EyeColor = "Brown",
                SkinColor = "Brown",
                Height = 5.6,
                Sex = "Male"
            };
            return View(malachi);
        }
    }
}


