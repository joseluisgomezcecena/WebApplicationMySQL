using System.ComponentModel.DataAnnotations;

namespace WebApplicationMySQL.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name field is required.")]
        [StringLength(maximumLength:100, MinimumLength = 2, ErrorMessage ="Name must be between 2 and 100 Characters.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Email field is required.")]
        [EmailAddress]
        public string Email { get; set; }



        [Required(ErrorMessage = "Phone field is required.")]
        [StringLength(maximumLength: 15, MinimumLength = 10, ErrorMessage = "Phone must be between 10 and 15 Characters.")]
        public string Phone { get; set; }


        [StringLength(maximumLength: 255, ErrorMessage = "Address must less than 255 Characters.")]
        public string ?  Address { get; set; }


    }
}
