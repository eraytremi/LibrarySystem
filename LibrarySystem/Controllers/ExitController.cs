using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Controllers
{
    public class ExitController : Controller
    {
        public IActionResult Quit()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
    }
}
