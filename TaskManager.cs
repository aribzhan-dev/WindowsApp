using System.Collections.Generic;

namespace HelloAvalonia
{
    public static class TaskManager
    {
        private static readonly List<string> _tasks = new();

        public static IReadOnlyList<string> GetTasks()
            => _tasks;

        public static void AddTask(string task)
        {
            _tasks.Add(task);
        }

        public static void RemoveTask(string task)
        {
            _tasks.Remove(task);
        }
    }
}