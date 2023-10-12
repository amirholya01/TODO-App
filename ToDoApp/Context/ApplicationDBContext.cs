using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Context
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }
    }
}
