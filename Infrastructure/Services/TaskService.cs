using Application;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public  class TaskService : ITaskService
    {
        private readonly AppDbContext _appDbContext;
        public TaskService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Domain.Entities.Task> Create(Domain.Entities.Task task)
        {
            if (task == null) 
            {
                throw new ArgumentNullException(nameof(task));
            }

            await _appDbContext.Tasks.AddAsync(task);
            await _appDbContext.SaveChangesAsync();

            return task;
        }

        public Task<List<Domain.Entities.Task>> GetAll()
        {
            var tasks = _appDbContext.Tasks.AsNoTracking().ToListAsync();
            return tasks;
        }
    }
}
