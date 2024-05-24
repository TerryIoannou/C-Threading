using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthTask.Services
{
    public class HealthBarService
    {
        private const int MaxHealth = 100;
        private const int HealthDecrement = 10;
        private int _currentHealth;

        public HealthBarService()
        {
            _currentHealth = MaxHealth;
        }

        public int CurrentHealth => _currentHealth;

        public void TaskAdded()
        {
            _currentHealth = Math.Max(0, _currentHealth - HealthDecrement);
        }

        public void TaskRemoved()
        {
            _currentHealth = MaxHealth;
        }
    }
}

