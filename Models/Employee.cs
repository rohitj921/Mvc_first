using System.ComponentModel.DataAnnotations;

namespace MVC_First.Models
{
    public class Employee
    {

            public int Id { get; set; }
            [Required(ErrorMessage = "Name is required")]
            [StringLength(25,MinimumLength =3,ErrorMessage ="Name should be between 3-25 characters.")]
            [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name must contain only letters and spaces.")]
            public required string Name { get; set; }

        [Range(18,65,ErrorMessage ="Age must be between 18 and 65.")]
        public int? Age {  get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public required DateTime Dob { get; set; }
        
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits")]
        public required string Phone { get; set; }

       
        [Required(ErrorMessage = "Gender is required")]
        public required string Gender { get; set; }

        [Required(ErrorMessage = "City is required")]
        public required string City {  get; set; }
 

    }
}
