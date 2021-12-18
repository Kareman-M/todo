using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo.Core.Model;
using todo.Core.Repository;
using todo.ViewModels;

namespace todo.Controllers
{
    //[Authorize]
    public class TodoController : Controller
    {
        private readonly ITodoRepository _Todo;
        public TodoController(ITodoRepository Todo) => _Todo = Todo; 
        public IActionResult Index()
        {
            ViewBag.NotStarted = _Todo.GetAll().Where(x => x.Status == "NotStarted" );
            ViewBag.InProgress = _Todo.GetAll().Where(x => x.Status == "InProgress");
            ViewBag.Completed = _Todo.GetAll().Where(x => x.Status == "Completed");
            return View();
        }
    }
}
