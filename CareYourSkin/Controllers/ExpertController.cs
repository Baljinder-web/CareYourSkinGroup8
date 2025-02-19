using CareYourSkin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CareYourSkin.Controllers
{
    public class ExpertController : Controller
    {
        private readonly SkinCareManagementContext  context;

        public ExpertController(SkinCareManagementContext context)
        {
            context = context;
        }

        // GET: Expert/Create
        public IActionResult AddDetails()
        {
            return View();
        }

        // POST: Expert/Create
        [HttpPost]
        public IActionResult AddDetails(Expert expert)
        {
            if (ModelState.IsValid)
            {
                context.Experts.Add(expert);
                context.SaveChanges();
                return RedirectToAction("IsExpert", "User"); // Redirect to home or expert list
            }
            return View(expert);
        }
    }
}
