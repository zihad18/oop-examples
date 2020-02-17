using System;
namespace Encapsulation
{
    public class Queue<T>
    {
        private T [] _items;
        private int _head;
        private int _tail;
        private int _size;
        public int Size
        {
            get
            {
                return _size;
            }
        }

        public Queue(int capacity)
        {
            _items = new T[capacity];
            _head = 0;
            _tail = 0;
            _size = 0;
        }
        public void Enqueue(T item)
        {
            if (_size == _items.Length)
            {
                Console.WriteLine("Queue is full");
                return;
            }

            _items[_tail] = item;
            ++_tail;
            ++_size;
        }
        public T Dequeue()
        {
            if (_size == 0)
            {
                Console.WriteLine("Queue is empty.");
                return default;
            }

            T removed = _items[_head];
            _items[_head] = default;
            _head++;
            _size--;
            return removed;
        }
    }
}
