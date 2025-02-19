


namespace CareYourSkin.Models
{
    public class Expert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string ClinicAddress { get; set; }
        public string ContactInfo { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
