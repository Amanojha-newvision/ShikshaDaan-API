using Microsoft.EntityFrameworkCore;
using Entity;

namespace Database
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SetupAccount> SuperAdmins { get; set; }
    }
}
