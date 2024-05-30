using Microsoft.AspNetCore.Http.HttpResults;
using Todo_API.Data;
using Todo_API.models.entities;
using Todo_API.Repositories.Interface;

namespace Todo_API.Repositories.Implementations
{
    public class TodoRepository : ITodoRepository
    {
        private readonly todoDbContext todoDbContext;
        public TodoRepository(todoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }
        public async Task<Todo> CreateAsync(Todo todo)
        {
            await todoDbContext.Todos.AddAsync(todo);
            await todoDbContext.SaveChangesAsync();
            return todo;
        }
    }
}
