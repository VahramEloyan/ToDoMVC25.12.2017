using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoMVC.Core
{
   public class ToDoList
    {
        public List<ToDoItem> ToDoItems { set; get; } = new List<ToDoItem>();
        public void Add(string title)
        {
            ToDoItems.Add(new ToDoItem { Title = title });
        }
        public bool Remove(int index)
        {
            if (index < 0 || index >= ToDoItems.Count)
            {
                throw new ArgumentOutOfRangeException("Incorect Argument");               
            }
            ToDoItems.RemoveAt(index);
            return true;
        }
    }
}
