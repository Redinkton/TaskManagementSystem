using Application;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;



namespace Infrastructure.Repositories
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;   
        }

        public async Task<List<Employee>> GetAllUsersForSort()
        {
            var employees = await _appDbContext.Employees.AsNoTracking().ToListAsync();

            return employees;
        }
    }
}
