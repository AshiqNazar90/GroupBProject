using System.ComponentModel.DataAnnotations;

namespace GroupBProject.Model
{
    public class Employee
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string Designation { get; set; }

    }
}
