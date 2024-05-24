using System.Collections.Generic;

namespace EarthTask.Interfaces
{
    public interface ITaskService
    {
        void CreateTask(EarthTask.Models.Task task);
        EarthTask.Models.Task GetTask(int id);
        void UpdateTask(EarthTask.Models.Task task);
        void DeleteTask(int id);
        IEnumerable<EarthTask.Models.Task> GetAllTasks();
    }
}
