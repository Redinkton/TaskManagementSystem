using Domain.Entities;

namespace Application
{
    public interface ITaskService
    {
        Task<Domain.Entities.Task> Create(Domain.Entities.Task task);
        Task<List<Domain.Entities.Task>> GetAll();
    }
}
