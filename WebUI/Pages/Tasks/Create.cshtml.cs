using Infrastructure.Repositories;

namespace WebUI.Pages.Tasks
{
    public class CreateModel : DepartmentNamePageModelModel
    {
        private readonly EmployeeService _employeeService;

        public CreateModel(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        //public IActionResult OnGet()
        //{
        //    PopulateDepartmentsDropDownList(_context);
        //    return Page();
        //}

    }
}
