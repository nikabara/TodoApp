using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers
{
    public class TodoListController : Controller
    {
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(TodoList obj)
        {
            return View();
        }
    }
}
