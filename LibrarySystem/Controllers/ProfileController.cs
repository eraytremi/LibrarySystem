using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
