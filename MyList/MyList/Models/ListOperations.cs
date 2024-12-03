using System;
using MyList.Models;

namespace MyList.Models
{
    public static class ListOperations<T>
    {
        public static void AddOperation(CustomList<T> list, T item)
        {
            list.ExecuteOperation(list.Add, item);
        }

        public static void RemoveOperation(CustomList<T> list, T item)
        {
            list.ExecuteOperation(list.Remove, item);
        }

        public static void DisplayOperation(CustomList<T> list)
        {
            list.Display();
        }
    }
}
