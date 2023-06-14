using Application;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebUI.Pages.Empl
{
    public class EmployeeNamePageModelModel : PageModel
    {

        public SelectList EmployeeNameSL { get; set; }

        public async System.Threading.Tasks.Task PopulateTasksDropDownList(IEmployeeService employeeServicee, object selectedTask = null)
        {
            var employees = await employeeServicee.GetAll();

            var employeesQuery = employees.OrderBy(d => d.FirstName);

            EmployeeNameSL = new SelectList(employeesQuery,
                nameof(Employee.Id),
                nameof(Employee.FirstName),
                selectedTask);
        }
    }
}
