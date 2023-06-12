using Application;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Task = System.Threading.Tasks.Task;



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
            //var users =_appDbContext.Employees.ToList();
            //List<Employee> employees = new List<Employee>();
            //foreach (var user in users)
            //{
            //    //user.Id = Guid.NewGuid();
            //    employees.Add(user);
            //    //if (Guid.TryParse(user.Id.ToString(), out Guid id)) // check if the user's Id is a valid integer
            //    //{
            //    //    employees.Add(user);
            //    //}
            //}

            var employees = await _appDbContext.Employees.AsNoTracking().ToListAsync();

            return employees;
        }

        //public DbSet<Employee> GetAllUsersForSort()
        //{
        //    return _appDbContext.Employees;
        //}
    }
}
