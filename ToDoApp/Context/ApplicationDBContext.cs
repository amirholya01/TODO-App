using Microsoft.EntityFrameworkCore;
using ToDoApp.Entities.Todo;

namespace ToDoApp.Context
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }


        //Tables
        public DbSet<Todo> Todos { get; set; }
    }
}
