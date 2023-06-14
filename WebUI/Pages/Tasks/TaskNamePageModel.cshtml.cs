using Application;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace WebUI.Pages.Tasks
{
    public class TaskNamePageModel : PageModel
    {
        public SelectList TaskNameSL { get; set; }

        public async System.Threading.Tasks.Task PopulateTasksDropDownList(ITaskService taskService,object selectedTask = null)
        {
            var tasks = await taskService.GetAll();

            var tasksQuery = tasks.OrderBy(d => d.Name);

            TaskNameSL = new SelectList(tasksQuery,
                nameof(Domain.Entities.Task.Id),
                nameof(Domain.Entities.Task.Name),
                selectedTask);
        }
    }
}
