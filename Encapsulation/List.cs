using System;

namespace Encapsulation
{
    public class List<T>
    {
        private T[] _items;
        private int _size;
        private const int DefaultSize = 10;
        public List()
        {
            _items = new T[DefaultSize];
            _size = 0;
        }
        public void Add(T item)
        {
            if (_size == _items.Length)
                IncreaseCapacity();
            _items[_size] = item;
            _size++;
        }
        private void IncreaseCapacity()
        {
            var tempArray = new T[_items.Length];
            Array.Copy(_items, tempArray, _items.Length);
            _items = new T[DefaultSize + _items.Length];
            Array.Copy(tempArray, _items, tempArray.Length);
        }
    }
}
