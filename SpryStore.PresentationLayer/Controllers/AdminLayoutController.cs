using Microsoft.AspNetCore.Mvc;
using System;
using static System.Net.WebRequestMethods;

namespace SpryStore.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        //idlhitzwiogthyvi mail işlemlerinde kullanılacak key
        public IActionResult Index()
        {
            Random rnd = new Random();
            int number = rnd.Next(0,100);
            ViewBag.n = number;
            return View();
        }
    }
}
