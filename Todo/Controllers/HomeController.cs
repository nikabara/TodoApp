using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Todo.Data;
using Todo.Models;

namespace Todo.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            List<TodoList> list = _dbContext.TodoList.ToList();
            return View(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}