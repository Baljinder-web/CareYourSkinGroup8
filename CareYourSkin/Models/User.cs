using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CareYourSkin.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Your Username")]
       
        // [UsernameValidation]
        public string? Username { get; set; }

        // [PasswordValidation]

        [Required(ErrorMessage = "Enter Your Password")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string? ConfirmPassword { get; set; }

       // public string? ProfilePic { get; set; }

        // [NameValidation]

        [Required(ErrorMessage = "Enter Your Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please Enter Age ")]
        [Range(1, 150)]
        public int Age { get; set; }

        //[DateOfBirthValidation]
        [Required(ErrorMessage = "Enter Your Birth date")]
        public DateTime DateOfBirth { get; set; }

        public string? Role { get; set; }

        public string? ContentType { get; set; }
        public string? ImagePath { get; set; }
    }
}
