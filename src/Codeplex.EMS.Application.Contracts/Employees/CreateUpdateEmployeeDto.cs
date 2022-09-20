using System;
using System.ComponentModel.DataAnnotations;

namespace Codeplex.EMS.Employees
{
    public class CreateUpdateEmployeeDto
    {      
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public EmployeeType Type { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public double Salary { get; set; }
    }
}
