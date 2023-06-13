using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{
    public class LoginModel
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        [MinLength(6)]
        public string? Password { get; set; }

    }



}