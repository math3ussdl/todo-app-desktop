using System.Collections.Generic;
using TodoApp.src.Classes;

namespace TodoApp.Interfaces
{
    public interface IListInterface
    {
        string Title { get; set; }
        string Description { get; set; }
        string Category { get; set; }
        List<Activity> Activities { get; set; }
    }
}
