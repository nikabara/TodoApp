using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controllers
{
    public class TodoListController : Controller
    {
        private readonly AppDbContext _context;

        public TodoListController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TodoList obj)
        {
            obj.SubmissionsDate = DateTime.Now;
            _context.TodoList.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Edit(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            TodoList todoItem = _context.TodoList.Find(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return View(todoItem);
        }


        [HttpPost]
        public IActionResult Edit(TodoList obj)
        {
            if (ModelState.IsValid)
            {
                _context.TodoList.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
                
            return View();
        }
    }
}
