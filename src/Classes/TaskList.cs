using System.Collections.Generic;
using TodoApp.src.Classes;

namespace TodoApp.Classes
{
    public class TaskList
    {
        public TaskList()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Users { get; set; }
        public Category Categories { get; set; }
        public List<Activity> Activities { get; set; }
    }
}
