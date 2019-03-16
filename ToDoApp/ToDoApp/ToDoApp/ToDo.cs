using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    public class ToDo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; } 

        public ToDo() { }

        public ToDo(string name, string description, bool iscompleted)
        {
            Name = name;
            Description = description;
            IsCompleted = iscompleted;
        }
    }
}
