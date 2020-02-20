using System.ComponentModel.DataAnnotations;

namespace BankAccounts.Models
{
    public class LoginUser
    {
        [EmailAddress]
        public string LoginEmail {get; set;}
        [DataType(DataType.Password)]
        public string LoginPassword {get;set;}

    }
}