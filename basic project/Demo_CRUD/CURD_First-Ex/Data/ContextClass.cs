using CURD_First_Ex.Models;
using Microsoft.EntityFrameworkCore;

namespace CURD_First_Ex.Data
{
    public class ContextClass:DbContext
    {
        public ContextClass(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee>employees { get; set; }
        public DbSet<Department>departments { get; set; }


    }
}
