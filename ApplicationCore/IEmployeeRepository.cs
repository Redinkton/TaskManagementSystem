using Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace Application
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetById(int id);
        Task<Employee> Update(Employee user);
        Task Delete(Employee employee);
    }
}

