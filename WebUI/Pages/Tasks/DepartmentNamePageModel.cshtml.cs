using Infrastructure;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Task = Domain.Entities.Task;

namespace WebUI.Pages.Tasks
{
    public class DepartmentNamePageModelModel : PageModel
    {
        public SelectList DepartmentNameSL { get; set; }

        public void PopulateDepartmentsDropDownList(AppDbContext _context,
            object selectedDepartment = null)
        {
            var departmentsQuery = from d in _context.Tasks
                                   orderby d.Name // Sort by name.
                                   select d;

            DepartmentNameSL = new SelectList(departmentsQuery.AsNoTracking(),
                nameof(Task.Id),
                nameof(Task.Name),
                selectedDepartment);
        }
    }
}
