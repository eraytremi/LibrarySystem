
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibrarySystem.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

       
    }
}