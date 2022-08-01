using System;
using System.Collections.Generic;
using Todo.Models;

namespace TodoCambrianProject.Models
{
    public class ToDoItemModel
    {
        public List<TodoItem> TodoList { get; set; }
        public TodoItem Todo { get; set; }
    }
}

