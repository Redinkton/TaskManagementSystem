namespace Domain.Entities
{
    public record Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
