using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using taskListRevistedCapstone4.Models;

namespace taskListRevistedCapstone4.Controllers
{
    [Authorize]
    public class TaskListController : Controller
    {
        private readonly TaskListDbContext _context;

        public TaskListController(TaskListDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(UserTask newTask)
        {

            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            newTask.UserId = id;
            _context.UserTask.Add(newTask);
            _context.SaveChanges();
            return RedirectToAction("ViewTask");
        }

        public IActionResult DeleteTask(int Id)
        {
            UserTask found = _context.UserTask.Find(Id);
            if(found != null)
            {
                _context.UserTask.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("ViewTask");
        }

        public IActionResult ViewTask()
        {
            List<UserTask> taskList = _context.UserTask.ToList();
            return View(taskList);
        }


    }
}