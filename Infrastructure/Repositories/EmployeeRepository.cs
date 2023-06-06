using Application;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Task = System.Threading.Tasks.Task;

namespace Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly UserManager<Employee> _userManager;
        public EmployeeRepository(UserManager<Employee> userManager)
        {
            _userManager = userManager;
        }

        public async Task Delete(Employee employee)
        {
            var result = await _userManager.DeleteAsync(employee);
            if (!result.Succeeded)
            {
                throw new Exception($"Cannot delete user with ID '{employee.Id}'.");
            }
        }

        public async Task<Employee> GetById(int id)
        {
            return await _userManager.FindByIdAsync(id.ToString());
        }

        public async Task<Employee> Update(Employee user)
        {
            if (user != null)
            {
                await _userManager.UpdateAsync(user);
                return user;
            }
            else
            {
                throw new InvalidOperationException("Forbidden");
            }
        }
    }
}
