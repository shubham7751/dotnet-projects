using Crud_3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Crud_3.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

    }
}
