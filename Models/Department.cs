using System.ComponentModel.DataAnnotations;

namespace CrudIT_Project.Models
{
    public class Department
    {
        
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Manager { get; set; }


        //navigation prop with Instractor
        public List<Instractor> Instractors { get; set; }

        //navigation prop with Course   
        public List<Course> Courses { get; set; }

        public List<Trainee> Trainees { get; set; }

    }
}
