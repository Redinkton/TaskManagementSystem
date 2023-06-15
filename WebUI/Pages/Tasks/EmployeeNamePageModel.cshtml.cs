using Application;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace WebUI.Pages.Tasks
{
    public class TaskNamePageModel : PageModel
    {
        public SelectList EmployeeNameSL { get; set; }

        public async System.Threading.Tasks.Task PopulateTasksDropDownList(IEmployeeService employeeService, object selectedEmployee = null)
        {
            var employees = await employeeService.GetAll();

            var employeesQuery = employees.OrderBy(d => d.FirstName);

            EmployeeNameSL = new SelectList(employeesQuery,
                nameof(Domain.Entities.Task.Id),
                nameof(Domain.Entities.Task.Name),
                selectedEmployee);
        }
    }
}
