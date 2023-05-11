namespace Domain
{
    public record Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateOnly DuDate { get; set; }
        public Status Status { get; set; }
        public ICollection<Employee> Employees { get;set; }
        public ICollection<Dependency> Dependencies { get; set; }


    }
}
