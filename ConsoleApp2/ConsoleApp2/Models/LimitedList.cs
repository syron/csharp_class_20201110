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
}
