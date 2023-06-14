using Application;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Pages.Tasks
{
    public class CreateModel /*: TaskNamePageModel*/
    {
        private readonly ITaskService _taskService;

        public CreateModel(ITaskService taskService)
        {
            _taskService = taskService;
        }

        //public IActionResult OnGet()
        //{
        //    PopulateTasksDropDownList(_taskService);
        //    return Page();
        //}

        [BindProperty]
        public Domain.Entities.Task Task { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //var emptyTask = new Domain.Entities.Task();

            //if (await TryUpdateModelAsync<Domain.Entities.Task>(
            //     emptyTask,
            //     "task",   // Prefix for form value.
            //     s => s., s => s.Status, s => s.Name, s => s.Description))
            //{
            //    _taskService.Create()
            //    _taskService.Create()
            //    _context.Courses.Add(emptyTask);
            //    await _context.SaveChangesAsync();
            //    return RedirectToPage("./Index");
            //}

            //// Select DepartmentID if TryUpdateModelAsync fails.
            //PopulateDepartmentsDropDownList(_context, emptyTask.DepartmentID);
            //return Page();
        }
    }
}
