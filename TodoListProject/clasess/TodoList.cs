using System;
using System.Collections.Generic;

namespace TodoListProject.classes
{
    public class TodoList
    {
        private List<string> _items = new List<string>();

        //public IReadOnlyList<string> Items => _items.AsReadOnly();

        public bool AddTodo(string todo)
        {
            if (!string.IsNullOrWhiteSpace(todo))
            {
                _items.Add(todo);
                return true;
            }

            return false;
        }

        public bool RemoveTodo(int index)
        {
            if (index >= 0 && index < _items.Count)
            {
                _items.RemoveAt(index);
                return true;
            }
            return false;
        }

        public List<string> GetAllTodos()
        {
           // return this._items.Select((value, index) => $"[{index+1}] {value}")
                //.ToList();

            return _items;
        }

        public string GetTodoById(int idx)
        {
            if(idx >= 0 && idx < _items.Count)
            {
                var todo = _items[idx];
                return todo;
            } else
            {
                return "todo no encontrado";
            }
        }
    }
}
