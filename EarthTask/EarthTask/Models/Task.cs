﻿namespace EarthTask.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Description { get; set; } = string.Empty;
        public string? Status { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
