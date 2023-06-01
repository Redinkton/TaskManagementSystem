using Domain.Enums;

namespace Domain.Entities
{
    public record Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Dependency> Dependencies { get; set; }
    }
}
