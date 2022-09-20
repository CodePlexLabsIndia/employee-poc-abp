using AutoMapper;
using Codeplex.EMS.Employees;

namespace Codeplex.EMS.Web;

public class EMSWebAutoMapperProfile : Profile
{
    public EMSWebAutoMapperProfile()
    {
        CreateMap<EmployeeDto, CreateUpdateEmployeeDto>();
        //Define your AutoMapper configuration here for the Web project.
    }
}
