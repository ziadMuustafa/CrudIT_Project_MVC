using CrudIT_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace CrudIT_Project.ViewModels
{
    public class InstractorCourseDep
    {
        public int TempId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        [Display(Name = "First name")]
        public string Name { get; set; }

        //[RegularExpression("@\"\\(ImgName\\.png\\)$\"" , ErrorMessage ="Only png photos are allowed") ]
        public string Img { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        public int DepartmentId { get; set; }
        public int CourseId { get; set; }


        public List<Department>? departments { get; set; }
        public List<Course>? courses { get; set; }
    }
}
