using Microsoft.EntityFrameworkCore;
using Yu_Gi_Oh_API.Models;

namespace Yu_Gi_Oh_API.Data
{
    // Databse context class for app, inherits from DbContext and provides access to the database
    public class AppDbContext : DbContext
    {
        // Constructor that takes DbContextOptions and passes them to the base class constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        // DbSet property for Cards, representing the collection of Card entities in the database
        public DbSet<Card> Cards { get; set; }


    }
}
