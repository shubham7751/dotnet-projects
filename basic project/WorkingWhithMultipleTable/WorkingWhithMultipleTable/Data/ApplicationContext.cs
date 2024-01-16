using Microsoft.EntityFrameworkCore;
using WorkingWhithMultipleTable.Models;

namespace WorkingWhithMultipleTable.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
