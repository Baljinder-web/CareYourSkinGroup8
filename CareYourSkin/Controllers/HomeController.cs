using Microsoft.AspNetCore.Mvc;
using CareYourSkin.Models;

namespace CareYourSkin.Controllers
{
    public class HomeController : Controller
    {

        private readonly SkinCareManagementContext _context;

        public HomeController(SkinCareManagementContext context)
        {
            _context = context;
        }

        public bool IsSessionActive()
        {
            return !string.IsNullOrEmpty(HttpContext.Session.GetString("Username"));
        }

        public IActionResult Home()
        {
            if (!IsSessionActive())
            {
                TempData["SessionExpired"] = "Your Session has expired. Please Log In Again";
                return RedirectToAction("Login", "User");
            }
            return View();

        }

        public IActionResult IsExpert()
        {
            var role = HttpContext.Session.GetString("Role");
            var mode = HttpContext.Session.GetString("CurrentMode");

            if (role == "Expert" && mode == "Expert")
            {
                return View(); // Load expert panel
            }

            return RedirectToAction("IsUser", "Home"); // Redirect to user panel if not in expert mode
        }

        public IActionResult IsUser()
        {
            return View();
        }
        public IActionResult IsAdmin()
        {
            return View(); 
        }

    }
}
