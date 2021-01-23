using System;
using Microsoft.AspNetCore.Mvc;

namespace App.webui.Controllers
{   //localhost:5000/home
    public class HomeController : Controller
    {
        //Index action
        public IActionResult Index()
        {
            int Hour = DateTime.Now.Hour;
            string msg = Hour > 12 ? "İyi günler" : "Günaydın";
            ViewBag.Greeting = msg;
            ViewBag.UserName = "Ahmet";
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {

            return View("MyView");
        }

    }
}