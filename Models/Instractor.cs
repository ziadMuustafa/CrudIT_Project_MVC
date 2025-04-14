using System.ComponentModel.DataAnnotations.Schema;

namespace CrudIT_Project.Models
{
    public class Instractor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public decimal Salary { get; set; } 
        public string Address { get; set; }


        //handeling 1-M relationship between Department and Instractor
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }   
        public Department? Department { get; set; }



        //handeling 1-M relationship between Course and Instractor
        [ForeignKey("Course")]
        public int CourseId { get; set; }    
        public Course Course { get; set; }  

    }
}
