using Codeplex.EMS.Employees;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Codeplex.EMS.Web.Pages.Employees
{
    public class CreateModalModel : EMSPageModel
    {
        [BindProperty]
        public CreateUpdateEmployeeDto Employee { get; set; }

        private readonly IEmployeeAppService _employeeAppService;

        public CreateModalModel(IEmployeeAppService employeeAppService)
        {
            _employeeAppService = employeeAppService;
        }

        public void OnGet()
        {
            Employee = new CreateUpdateEmployeeDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _employeeAppService.CreateAsync(Employee);
            return NoContent();
        }
    }
}
