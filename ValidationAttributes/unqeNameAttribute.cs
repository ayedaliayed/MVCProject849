using MVCProject849.Context;
using System.ComponentModel.DataAnnotations;

namespace MVCProject849.ValidationAttributes
{
    public class unqeNameAttribute : ValidationAttribute
    {
        CompanyContext CompanyContext = new CompanyContext();

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            var employee = CompanyContext.Employees.FirstOrDefault(em=>em.Name == (string)value);
        
            if (employee != null)
            {
                return new ValidationResult("The name must be unique.");
            }
            return ValidationResult.Success;
        }

    }
}
