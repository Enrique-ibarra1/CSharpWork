using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAndCategories.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}
        [Required(ErrorMessage="Name is required")]
        [MinLength(3, ErrorMessage="Product name must be at least 3 characters")]
        public string Name {get;set;}
        [Required(ErrorMessage="Description is required")]
        [MaxLength(140, ErrorMessage="Description too long, make it tweet length")]
        public string Description {get;set;}
        [Required]
        [Range(0,Double.MaxValue)]
        public double Price {get;set;}
        public List<Association> Categories {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}