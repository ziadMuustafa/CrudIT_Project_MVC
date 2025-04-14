using System.ComponentModel.DataAnnotations.Schema;

namespace CrudIT_Project.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }


        //navigation prop with Instractor
        public List<Instractor>? Instractors { get; set; }


        //handeling 1-M relationship between Department and Course  
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }


        //navigation prop with Trainee  
        public List<Trainee>? Trainees { get; set; }    

    }
}
