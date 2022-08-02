using System;
using System.Collections.Generic;
using Todo.Models;
//similar to model class but contains list of todo items and individual todo item
//used for retreiving data from th database
namespace TodoCambrianProject.Models
{
    public class ToDoItemModel
    {
        public List<TodoItem> TodoList { get; set; }
        public TodoItem Todo { get; set; }
    }
}

