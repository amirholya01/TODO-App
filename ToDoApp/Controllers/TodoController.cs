﻿using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}