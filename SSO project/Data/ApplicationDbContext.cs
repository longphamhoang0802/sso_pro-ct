using Microsoft.EntityFrameworkCore;
using SSO_project.Models;

namespace SSO_project.Data
    
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Account> Account { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
