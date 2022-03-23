using System.ComponentModel.DataAnnotations;

namespace StudentWebpage.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string BloodGroup { get; set; }
        public string Division { get; set; }
    }
}
