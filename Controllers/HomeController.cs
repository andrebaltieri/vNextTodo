using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;
using MvcTodoWithNg.Models;
using MvcTodoWithNg.Data;

namespace MvcSample.Web
{
    [Route("api/todo")]
    public class HomeController : Controller
    {
        private AppDataContext _db;

        public HomeController()
        {
            _db = new AppDataContext();
        }

        [HttpGet]
        public IEnumerable<Todo> GetAll()
        {
            return _db.Todos.ToList();
        }
        
        [HttpPost]
        public Todo Post([FromBody] Todo todo)
        {
            _db.Todos.Add(todo);
            _db.SaveChanges();

            return todo;
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}