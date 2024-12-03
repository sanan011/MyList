using System;
using System.Collections.Generic;
using MyList.Interfaces;

namespace MyList.Models
{
    public class CustomList<T> : IListOperations<T>
    {
        private List<T> _list;

        // Delegates
        public delegate void ListOperation(T item);

        public CustomList()
        {
            _list = new List<T>();
        }

        public void Add(T item)
        {
            _list.Add(item);
            Console.WriteLine($"Added: {item}");
        }

        public void Remove(T item)
        {
            if (_list.Contains(item))
            {
                _list.Remove(item);
                Console.WriteLine($"Removed: {item}");
            }
            else
            {
                Console.WriteLine($"Item '{item}' not found.");
            }
        }

        public void Display()
        {
            Console.WriteLine("\nCurrent Items in the List:");
            if (_list.Count == 0)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                foreach (var item in _list)
                {
                    Console.WriteLine($"- {item}");
                }
            }
        }

        public void ExecuteOperation(ListOperation operation, T item)
        {
            operation?.Invoke(item);
        }
    }
}
