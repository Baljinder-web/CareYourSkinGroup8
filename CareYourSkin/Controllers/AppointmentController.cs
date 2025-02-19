using CareYourSkin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CareYourSkin.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly SkinCareManagementContext context;

        public AppointmentController(SkinCareManagementContext context)
        {
            context = context;
        }

        // GET: Appointment/BookAppointment
        public IActionResult BookAppointment(int expertId)
        {
            var expert = context.Experts.Find(expertId);
            if (expert == null)
            {
                return NotFound();
            }

            ViewBag.ExpertId = expertId;
            return View();
        }

        // POST: Appointment/BookAppointment
        [HttpPost]
        public IActionResult BookAppointment(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                context.Appointments.Add(appointment);
                context.SaveChanges();
                return RedirectToAction("Index", "Home"); // Redirect to home or confirmation page
            }
            return View(appointment);
        }

        public IActionResult ExpertList()
        {
            var experts = context.Experts.ToList();
            return View(experts);
        }
    }
}
