using Microsoft.EntityFrameworkCore;
using Todo_API.models.entities;

namespace Todo_API.Data
{
    public class todoDbContext:DbContext
    {
        public todoDbContext(DbContextOptions<todoDbContext> options) : base(options)
        {
            
        }
        public DbSet<Todo> Todos { get; set; }
    }
}
