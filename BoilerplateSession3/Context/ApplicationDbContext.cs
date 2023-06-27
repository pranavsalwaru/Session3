using BoilerplateSession3.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerplateSession3.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }    
    }
}
