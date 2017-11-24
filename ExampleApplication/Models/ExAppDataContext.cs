using Microsoft.EntityFrameworkCore;

namespace ExampleApplication.Models
{
    public class ExAppDataContext : DbContext
    {
        public ExAppDataContext(DbContextOptions<ExAppDataContext> options) : base(options)
        { 
        }
        
        public DbSet<Book> Books { get; set; }
    }
}