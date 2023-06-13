using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{
    public class SignUpModel
    {
        

        [Key]

        [Required]
        public string? Name { get; set; }
        [Required]

        public string? Username { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "You must enter your e-mail address")]
        public string? Email { get; set; }
        [Required]
        [MinLength(6)]
        public string? Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

    }
}