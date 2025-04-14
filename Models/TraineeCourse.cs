using System.ComponentModel.DataAnnotations.Schema;

namespace CrudIT_Project.Models
{
   
    public class TraineeCourse
    {


        //handeling M-M relationship between Trainee and Course
        [ForeignKey("Trainee")]
        public int TraineeId { get; set; }
        public Course Course { get; set; }  

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Trainee Trainee { get; set; }


        //Additional properties
        public int id { get; set; } 
        public int degree { get; set; } 

    }
}
