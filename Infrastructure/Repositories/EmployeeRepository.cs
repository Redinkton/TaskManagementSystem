using Application;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Task = System.Threading.Tasks.Task;

namespace Infrastructure.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // This is registration
        public async Task<Employee> Create(Employee employee)
        {
            if (_appDbContext.Employees.FindAsync(employee.Id) == null)
            {
                await _appDbContext.Employees.AddAsync(employee);
                await _appDbContext.SaveChangesAsync();

                return employee;
            }
            else if (_appDbContext.Employees.FindAsync(employee.Id) != null)
            {
                var existingEmployee = await _appDbContext.Employees.FindAsync(employee.Id);
                return existingEmployee;
            }
            else
            {
                throw new InvalidOperationException("Forbidden");
            }
        }

        public async Task Delete(Employee employee)
        {
            _appDbContext.Employees.Remove(employee);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _appDbContext.Employees.FindAsync(id);
        }

        public async Task<Employee> Update(Employee user)
        {
            if (user != null)
            {
                _appDbContext.Employees.Update(user);
                return user;
            }
            else
            {
                throw new InvalidOperationException("Forbidden");
            }
        }
    }
}
