using Microsoft.AspNetCore.Mvc;
using MvcCore.Models;
using System.Diagnostics;

namespace MvcCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        
        public string msg()
        {
            string s = "Welcome tp asp.net core";
            return s;
        }
    }
}