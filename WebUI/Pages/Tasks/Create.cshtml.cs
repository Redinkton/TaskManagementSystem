using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

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
