using DotNetCoreJS.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DotNetCoreJS.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
