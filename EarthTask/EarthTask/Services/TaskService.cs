using EarthTask.Interfaces;
using EarthTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace EarthTask.Services
{
    public class TaskService : ITaskService
    {
        private readonly List<EarthTask.Models.Task> _tasks = new List<EarthTask.Models.Task>();

        public void CreateTask(EarthTask.Models.Task task)
        {
            _tasks.Add(task);
        }

        public EarthTask.Models.Task GetTask(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }

        public void UpdateTask(EarthTask.Models.Task task)
        {
            var existingTask = GetTask(task.Id);
            if (existingTask != null)
            {
                existingTask.Description = task.Description;
                existingTask.Status = task.Status;
                existingTask.Date = task.Date;
            }
        }

        public void DeleteTask(int id)
        {
            var task = GetTask(id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
        }

        public IEnumerable<EarthTask.Models.Task> GetAllTasks()
        {
            return _tasks;
        }
    }
}
