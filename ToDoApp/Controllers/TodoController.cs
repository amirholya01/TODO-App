using Microsoft.AspNetCore.Mvc;
using ToDoApp.Context;

namespace ToDoApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly ApplicationDBContext _context;
        public TodoController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var todos = _context.Todos.ToList();
            return View(todos);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
