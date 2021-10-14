using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
namespace WebApplication1.Models
{
    public class TasksRepository
    {
        private readonly ApplicationDbContext context;

        public TasksRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Task> GetTasks()
        {
            return context.tasks.OrderBy(x => x.Name);
        }

        public Task GetTasksById(int id)
        {
            return context.tasks.Single(x => x.Id == id);
        }

        public int SaveTask(Task entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return entity.Id;
        }

        public void RemoveTask(Task entity)
        {
            context.tasks.Remove(entity);
            context.SaveChanges();
        }
    }
}
