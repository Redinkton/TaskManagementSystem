using Application;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TaskManagementSystem.Tests
{
    [TestClass]
    public class TaskManagementSystemTests
    {
        private AppDbContext _context;
        private IEmployeeService _service;

        public TaskManagementSystemTests()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
           .UseInMemoryDatabase(databaseName: "MyDatabase")
           .Options;

            _context = new AppDbContext(options);
            _service = new TaskService(_context);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetAll_ReturnsCorrectCountOfEmployeesAsync()
        {
            // Arrange
            int expectedCount = 2;
            await AddEmployeeToDatabase();

            // Act
            var result = await _service.GetAll();

            // Assert
            Assert.AreEqual(expectedCount, result.Count, "The number of employees in the database and the actual number is different.");
        }

        private async System.Threading.Tasks.Task AddEmployeeToDatabase()
        {
            var firstTask = new Domain.Entities.Task()
            {
                Id = new Guid(),
                Name = "Info",
                Description = "Add new info",
                DueDate = new DateTime(2024, 7, 20)
            };
            var secondTask = new Domain.Entities.Task()
            {
                Id = new Guid(),
                Name = "Info",
                Description = "Add new info",
                DueDate = new DateTime(2024, 7, 20)
            };

            var tasks = new List<Domain.Entities.Task>
            {
                firstTask,
                secondTask,
            };

            await _context.AddRangeAsync(new List<Employee>
            {
                new Employee() {Id = new Guid(), FirstName = "Jack", LastName = "Ugne", Tasks = new List<Domain.Entities.Task>() { tasks[0] }},
                new Employee() {Id = new Guid(), FirstName = "Yell", LastName = "Holq", Tasks = new List<Domain.Entities.Task>() { tasks[1] }},
            });
            await _context.SaveChangesAsync();
        }
    }
}