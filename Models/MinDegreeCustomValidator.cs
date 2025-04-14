using System.ComponentModel.DataAnnotations;

namespace CrudIT_Project.Models
{
    public class MinDegreeCustomValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {

            if (value != null)
            {
                int minDegree = (int)value;
                if (minDegree < 50)
                {
                    return new ValidationResult("Min Degree must be between 0 and 100");
                }
            }
            return ValidationResult.Success;

        }
    }
}
