
using LibrarySystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Data;

namespace LibrarySystem.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignUpDbContext _signUpDbContext;

        public LoginController(SignUpDbContext? signUpDbContext)
        {
            _signUpDbContext = signUpDbContext;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            try
            {
                var dataValue = _signUpDbContext.signUpModels.FirstOrDefault(x => x.Username == loginModel.Username && x.Password == loginModel.Password);
                if (dataValue != null)
                {

                    HttpContext.Session.SetString("Username", loginModel.Username);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Message = "Bilgileri doğru girmedin. Tekrar deneyiver";
                }
                return View();

            }
            catch (Exception e)
            {
                return Redirect("https://www.google.com");
            }
        }
    }
}
