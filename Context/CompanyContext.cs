using Microsoft.EntityFrameworkCore;
using MVCProject849.Models;

namespace MVCProject849.Context
{
    public class CompanyContext:DbContext
    {
       
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(

                "Server=localhost;Database=Session849;Trusted_Connection=True;TrustServerCertificate=True;");
        }


        

    }
}
