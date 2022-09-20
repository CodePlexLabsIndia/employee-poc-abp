using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Codeplex.EMS.Employees
{
    public class EmployeeDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Employee, Guid> _employeeRepository;

        public EmployeeDataSeederContributor(IRepository<Employee, Guid> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _employeeRepository.GetCountAsync() <= 0)
            {
                await _employeeRepository.InsertAsync(
                    new Employee
                    {
                        Name = "Will Smith",
                        Type = EmployeeType.Developer,
                        JoiningDate = new DateTime(2002, 6, 8),
                        Salary = 25000.00,
                        PhoneNumber = "8796547894",
                        Email = "will.smith@outlook.com"
                    },
                    autoSave: true
                );

                await _employeeRepository.InsertAsync(
                    new Employee
                    {
                        Name = "Tom Cruise",
                        Type = EmployeeType.Manager,
                        JoiningDate = new DateTime(2005, 9, 27),
                        Salary = 35000.00,
                        PhoneNumber = "9874569857",
                        Email = "tom.cruise@outlook.com"
                    },
                    autoSave: true
                );
            }
        }
    }
}
