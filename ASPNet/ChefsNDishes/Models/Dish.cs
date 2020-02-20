using System.ComponentModel.DataAnnotations;
using System;
namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key] 
        [Required]
        public int DishId {get;set;} 
        [Required]
        public string Name {get;set;}
        [Required]
        [Range(1,2501)]
        public int Calories {get;set;}
        [Required]
        [Range(1,6)]
        public int Tastiness {get;set;}
        [Required]
        public string Description {get;set;}
        public int ChefId {get;set;}
        public Chef Creator {get;set;}
    }
}