using Microsoft.EntityFrameworkCore;
using StudentWebpage.Models;

namespace StudentWebpage.Data
{
    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Testdb20;Trusted_Connection=True;");
        }
    }
}
