using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    public class LimitedList<T>
    {
        private int _maxNumberOfItems;
        private List<T> _list;

        public LimitedList(int maxNumberOfItems)
        {
            _maxNumberOfItems = maxNumberOfItems;
            _list = new List<T>();
        }

        public void Add(T item)
        {
            if (_list.Count < _maxNumberOfItems)
            {
                _list.Add(item);
            }
            else // if list is full
            {
                throw new ListIsFullException($"List is full due to max amount = {_maxNumberOfItems}");
            }
        }

        public void Sort()
        {
        }

        public void Remove(T item)
        {
            _list.Remove(item);
        }

        public int Count()
        {
            return _list.Count;
        }
    }

    public class ListIsFullException : Exception
    {
        public ListIsFullException()
        {

        }

        public ListIsFullException(string message) : base(message)
        {

        }

        public ListIsFullException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
