using LibrarySystem.Data;
using LibrarySystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Controllers
{
    public class SignUpController : Controller
    {
         private readonly SignUpDbContext _signUpDbContext;

        public SignUpController(SignUpDbContext signUpDbContext)
        {
            _signUpDbContext = signUpDbContext;
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUpModel signUpModel)
        {
            if (ModelState.IsValid)
            {
                _signUpDbContext.Add(signUpModel);
                _signUpDbContext.SaveChanges();
                return RedirectToAction("Login", "Login");
            }

            return View();
        }
    }
}
