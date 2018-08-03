using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Models
{
    public class Name : IValidatableObject
    {
        [Required]
        [MinLength(4)]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    var name = (Name)validationContext.ObjectInstance;
        //    if (name.FirstName == name.LastName)
        //    {
        //        yield return new ValidationResult("First and Last name cannot match");
        //    }
        //}
    }
}
