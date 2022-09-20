using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Codeplex.EMS.Employees
{
    public interface IEmployeeAppService : ICrudAppService< //Defines CRUD methods
            EmployeeDto, //Used to show Employee
            Guid, //Primary key of the Employee entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateEmployeeDto> //Used to create/update a Employee
    {

    }
}
