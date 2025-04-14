using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudIT_Project.Models
{
    public class Trainee
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string? Img { get; set; }
        public int grade { get; set; }
        public string? Address { get; set; }


        public List<Course>? Courses { get; set; }


        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
