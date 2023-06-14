using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace Application
{
    public interface IEmployeeService
    {
        // Task<IList<Employee>> GetEmployeesAsync();
        Task<List<Employee>> GetAll();

    }
}

