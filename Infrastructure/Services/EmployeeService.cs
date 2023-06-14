using Application;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;



namespace Infrastructure.Repositories
{
    public class TaskService : IEmployeeService
    {
        private readonly AppDbContext _appDbContext;
        public TaskService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;   
        }

        public async Task<List<Employee>> GetAll()
        {
            var employees = await _appDbContext.Employees.AsNoTracking().ToListAsync();

            return employees;
        }
    }
}
