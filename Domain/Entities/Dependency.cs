namespace Domain.Entities
{
    public record Dependency
    {
        public int Id { get; set; }
        public Guid TaskId { get; set; } // Задача, для которой задана зависимость
        public Guid DependentTaskId { get; set; } // Зависимая задача
        public Task Task { get; set; } // Навигационное свойство к задаче
        public Task DependentTask { get; set; } // Навигационное свойство к зависимой задаче
    }
}
