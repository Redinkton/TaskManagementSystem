using Domain;
using Task = System.Threading.Tasks.Task;

namespace Application
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetUserById(int id);
        Task<Employee> CreateUser(Employee user);
        Task<Employee> UpdateUser(Employee user);
        Task DeleteUser(Employee employee);
    }
}

