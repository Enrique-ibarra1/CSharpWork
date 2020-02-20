using Microsoft.EntityFrameworkCore;
namespace EntintySetup.Models
{
    public class MyContext : DbContext
    {
        //this class is what forms the relationship between our models and our database.
        //base() calls the parent class' constructor passing the "options" parameter along.
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<User> Users {get; set;}
    }
}