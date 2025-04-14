using CrudIT_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CrudIT_Project.ViewModels
{
    [Keyless]
    public class CourseDepInstractorcs
    {
        public int CourseId { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        [UniqueCustomValidator()]
        public string Name { get; set; }
        [Required]
        [Range(50, 100)]
        public int Degree { get; set; }

        [MinDegreeCustomValidator]
        [Remote("Course", "CheckMinDegree", AdditionalFields = nameof(Degree), ErrorMessage = "MinDegree is invalid")]
        public int MinDegree { get; set; }


        //navigation prop with Instractor ---> M-M realtion - no foriegn key here - there are third table
        public List<Instractor>? Instractors { get; set; }
        public List<int>? SelectedInstructorIds { get; set; }


        //handeling 1-M relationship between Department and Course

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }


        //List of departments to be used in dropdown list
        public List<Department>? Departments { get; set; }

        //navigation prop with Trainee --->  M-M realtion - no foriegn key here - there are third table
        public List<Trainee>? Trainees { get; set; }
    }
}
