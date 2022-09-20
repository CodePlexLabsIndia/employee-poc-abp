using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Codeplex.EMS.Employees
{
    public class EmployeeDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public EmployeeType Type { get; set; }

        public DateTime JoiningDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public double Salary { get; set; }
    }
}
