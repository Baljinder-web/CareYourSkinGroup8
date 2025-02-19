namespace CareYourSkin.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int ExpertId { get; set; }
        public string UserName { get; set; } // Or link to a User table if you have user accounts
        public DateTime AppointmentDate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Confirmed, Cancelled
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Expert Expert { get; set; } // Navigation property
    }
}
