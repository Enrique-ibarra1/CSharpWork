using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(4, ErrorMessage="First Name must be at least 4 characters")]
        public string FirstName {get;set;}

        [Required]
        [MinLength(4, ErrorMessage="Last name must be at least 4 characters")]  
        public string LastName{get;set;}

        [Required]
        [EmailAddress]
        public string Email{get;set;}

        [Required]
        [Range(0,120, ErrorMessage="Please enter a valid age")]
        public int Age {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters")]
        public string Password{get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters")]
        [Compare("Password", ErrorMessage="Passwords do not match.")]
        public string ConfirmPassword{get;set;}
    }
}