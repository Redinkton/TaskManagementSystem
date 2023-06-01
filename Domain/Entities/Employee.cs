using Domain.Enums;
namespace Domain.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public string Password { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
