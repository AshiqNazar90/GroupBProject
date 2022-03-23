using GroupBProject.Model;
using Microsoft.EntityFrameworkCore;

namespace GroupBProject.DB
{
    public class EmployeeDBContext:DbContext
    {

        //intialize table for Database
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Testdb20;Trusted_Connection=True;");
        }
    }
}
