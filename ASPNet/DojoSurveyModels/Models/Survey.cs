using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModels.Models
{
    public class Survey
    {
        [Required]        
        [MinLength(2)]
        public string Name {get;set;}
        [Required]
        public string Dojo {get;set;}
        [Required]
        public string Language {get;set;}

        [MaxLength(21, ErrorMessage="Comment must be less than 20 characters?")]
        public string Comment {get;set;}
        
    }
}