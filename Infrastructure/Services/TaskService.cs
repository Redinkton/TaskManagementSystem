using Application;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Domain.Entities.Task;

namespace Infrastructure.Services
{
    public  class TaskService : ITaskService
    {
        private readonly AppDbContext _appDbContext;
        public TaskService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //public DbSet<Domain.Entities.Task> GetAllTasks()
        //{
        //    var allTasks = _appDbContext.Employees.ToList();
        //    var tasks = new List<Task>();
        //    foreach (var task in allTasks)
        //    {
        //        allTasks.Add(task);
        //    }

        //    return _appDbContext.Employees;
        //}
    }
}
