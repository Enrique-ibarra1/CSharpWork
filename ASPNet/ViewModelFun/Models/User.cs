using System.ComponentModel.DataAnnotations;

namespace ViewModelFun.Models
{
    public class User
    {
        // validations for later ;)
        [Required(ErrorMessage="First Name is required")]
        [Display(Name="First Name: ")]
        [MinLength(4, ErrorMessage="First Name must be at least 4 characters")]
        public string FirstName {get; set;}
        
        [Required(ErrorMessage="Last Name is required")]
        [Display(Name="Last Name: ")]
        [MinLength(4, ErrorMessage="Last Name must be at least 4 characters")]
        public string LastName {get; set;}
    }
}