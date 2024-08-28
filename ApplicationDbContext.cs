using CrudOperationAPIwithAngular.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudOperationAPIwithAngular
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
