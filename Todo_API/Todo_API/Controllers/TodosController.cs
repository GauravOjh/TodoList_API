using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo_API.models.DTO;
using Todo_API.models.entities;
using Todo_API.Repositories.Interface;

namespace Todo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository todoRepository;
        public TodosController(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateData(CreateTodoDTO todo)
        {
            var _todo = new Todo
            {
                Data = todo.Data,
            };
            await todoRepository.CreateAsync(_todo);

            var response = new TodoDTO
            {
                Id=_todo.id,
                Data=todo.Data,
            };
            return Ok(response);
        }
    }
}
