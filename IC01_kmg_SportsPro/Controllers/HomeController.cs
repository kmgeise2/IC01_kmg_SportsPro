using IC01_kmg_SportsPro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IC01_kmg_SportsPro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}