using CrudIT_Project.CrudItContext;
using System;
using System.ComponentModel.DataAnnotations;

namespace CrudIT_Project.Models
{
    
    public class UniqueCustomValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //handeling DepInjection with my custom validator
            var dbContext = validationContext.GetRequiredService<AppDBcontext>();


            if (value == null)
            {

                return new ValidationResult("Must enter value in this field");


            }

            else 
            {
                var context = dbContext.Courses.FirstOrDefault(e => e.Name == value.ToString());
                
                if (context == null) { return ValidationResult.Success; }

                return new ValidationResult("This value is already exist");

            }


        }
    }
}
