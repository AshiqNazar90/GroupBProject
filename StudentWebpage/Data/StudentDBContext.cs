using Microsoft.EntityFrameworkCore;
using StudentWebpage.Models;

namespace StudentWebpage.Data
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
      
    }
}
