using Microsoft.EntityFrameworkCore;

namespace CareYourSkin.Models
{
    public class SkinCareManagementContext : DbContext
    {
        public SkinCareManagementContext(DbContextOptions<SkinCareManagementContext> options) : base(options) { }

        public DbSet<User> AppUser { get; set; }

        public DbSet<Expert> Experts { get; set; }
        public DbSet<Appointment> Appointments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Username = "admin",
                Password = "admin123",
                ConfirmPassword = "admin123",
                Name = "Baljinder",
                Age = 24,
                DateOfBirth = DateTime.Parse("2000-07-21"),
                //ProfilePic = null,
                Role = "Admin",
                ImagePath = null
            },
            new User
            {
                Id = 2,
                Username = "baljinder",
                Password = "bal123@",
                ConfirmPassword = "bal123@",
                Name = "Baljinder Singh",
                Age = 22,
                DateOfBirth = DateTime.Parse("2002-07-25"),
               // ProfilePic = null,
                Role = "Expert",
                ImagePath = null
            }
            );

            
        }
    }
}
