using Todo_API.models.entities;

namespace Todo_API.Repositories.Interface
{
    public interface ITodoRepository
    {
        Task<Todo> CreateAsync(Todo todo);
    }
}
