using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set;}
    }
}
