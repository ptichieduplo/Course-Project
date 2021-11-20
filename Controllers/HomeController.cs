using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly TasksRepository tasksRepository;

        public HomeController(TasksRepository tasksRepository)
        {
            this.tasksRepository = tasksRepository;
        }

        public IActionResult Index()
        {
            var model = tasksRepository.GetTasks();
            return View(model);
        }

        public IActionResult TasksEdit(int id)
        {
            Models.Task model = id == default ? new Models.Task() : tasksRepository.GetTasksById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult TasksEdit(Models.Task model)
        {
            if (ModelState.IsValid)
            {
                tasksRepository.SaveTask(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult TaskDelete(int id)
        {
            tasksRepository.RemoveTask(new Models.Task { Id = id });
            return RedirectToAction("Index");
        }

        public IActionResult TaskView(int id)
        {
            var model = tasksRepository.GetTasksById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult SolveTask(Models.Task task)
        {
            if (task.UsersAnswer == null)
            {
                ViewBag.message = "0";
                return View(task);
            }
            else if (task.UsersAnswer == tasksRepository.GetTasksById(task.Id).CorrectAnswer)
            {
                task.ComplitedAuthors += User.Identity.Name;
                ViewBag.message = "1";
                return View(task);
            }
            else
            {
                ViewBag.message = "2";
                return View(task);
            }
        }

        public IActionResult Privacy()
        {
            var model = tasksRepository.GetTasks();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
