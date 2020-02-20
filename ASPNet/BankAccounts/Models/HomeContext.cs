using BankAccounts.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Models
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options){}

        public DbSet<User> Users {get; set;}
        public DbSet<Transaction> Transactions {get;set;}
    }
}