﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

            if (_context.TodoItems.Count() == 0)
            {
                _context.TodoItems.Add(new TodoItem { Title = "Item1" });
                _context.SaveChanges();
            }
        }

    }
}
