using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Codeplex.EMS.Employees
{
    public class Employee : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public EmployeeType Type { get; set; }

        public DateTime JoiningDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public double Salary { get; set; }
    }
}
