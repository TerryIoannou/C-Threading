using TaskModel = EarthTask.Models.Task;
using EarthTask.Interfaces;
using EarthTask.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace EarthTask.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        private readonly ITaskService _taskService;
        private readonly HealthBarService _healthBarService;
        private int _currentHealth;

        public ObservableCollection<TaskModel> Tasks { get; private set; }
        public ICommand AddTaskCommand { get; private set; }
        public ICommand DeleteTaskCommand { get; private set; }

        // Public parameterless constructor
        public MainPageViewModel()
        {
            // Initialize non-nullable fields with default values
            _taskService = new TaskService();  // Ideally, this should be passed through dependency injection
            _healthBarService = new HealthBarService();  // Ideally, this should be passed through dependency injection
            Tasks = new ObservableCollection<TaskModel>();
            _currentHealth = 100;

            AddTaskCommand = new Command(OnAddTask);
            DeleteTaskCommand = new Command<int>(OnDeleteTask);
        }

        public MainPageViewModel(ITaskService taskService, HealthBarService healthBarService)
        {
            _taskService = taskService;
            _healthBarService = healthBarService;
            Tasks = new ObservableCollection<TaskModel>(_taskService.GetAllTasks());
            _currentHealth = _healthBarService.CurrentHealth;

            AddTaskCommand = new Command(OnAddTask);
            DeleteTaskCommand = new Command<int>(OnDeleteTask);
        }

        public int CurrentHealth
        {
            get => _currentHealth;
            set
            {
                _currentHealth = value;
                OnPropertyChanged();
            }
        }

        private void OnAddTask()
        {
            var newTask = new TaskModel { Description = "New Task", Status = "Active", Date = DateTime.Now };
            _taskService.CreateTask(newTask);
            Tasks.Add(newTask);
            _healthBarService.TaskAdded();
            CurrentHealth = _healthBarService.CurrentHealth;
        }

        private void OnDeleteTask(int taskId)
        {
            var task = _taskService.GetTask(taskId);
            if (task != null)
            {
                _taskService.DeleteTask(taskId);
                Tasks.Remove(task);
                _healthBarService.TaskRemoved();
                CurrentHealth = _healthBarService.CurrentHealth;
            }
        }
    }
}
