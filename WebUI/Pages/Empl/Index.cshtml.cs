using Application;
using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebUI.Pages.Empl
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeService _employeeService;

        public IndexModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        // Sort
        public string NameSort { get; set; }
        public string DateSort { get; set; }

        public IList<Employee> Employees { get; set; }

        public async System.Threading.Tasks.Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Task" ? "task_desc" : "Task";

            var employees = await _employeeService.GetAll();

            switch (sortOrder)
            {
                case "name_desc":
                    employees = employees.OrderByDescending(s => s.LastName).ToList();
                    break;
                case "Task":
                    employees = employees.OrderBy(s => s.Tasks).ToList();
                    break;
                case "task_desc":
                    employees = employees.OrderByDescending(s => s.Tasks).ToList();
                    break;
                default:
                    employees = employees.OrderBy(s => s.LastName).ToList();
                    break;
            }
            Employees = employees;
        }
    }
}
