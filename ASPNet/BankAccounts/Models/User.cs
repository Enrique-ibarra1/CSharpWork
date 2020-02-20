using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required(ErrorMessage="First Name required.")]
        [Display(Name="First Name:")]
        [MinLength(3, ErrorMessage="Name must be at least 3 characters long.")]
        public string FirstName {get;set;}

        [Required(ErrorMessage="Last Name required.")]
        [Display(Name="Last Name:")]
        [MinLength(3, ErrorMessage="Last Name must be at least 3 characters long.")]
        public string LastName {get;set;}

        [Required(ErrorMessage="Email is required")]
        [EmailAddress]
        [Display(Name="Email Address:")]
        public string Email {get;set;}

        [DataType(DataType.Password)]
        [Required]
        [Display(Name="Password: ")]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters.")]
        public string Password {get;set;}
        [Required(ErrorMessage="Please confirm your password.")]
        [Display(Name="Confirm Password:")]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password", ErrorMessage="Your passwords do not match.")]
        public string ConfirmPassword {get;set;}
        //Nav property
        public List<Transaction> MyTransactions {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        
    }
}