using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue <int> (5);
            Console.WriteLine(queue.Size);
            Console.WriteLine(queue.Dequeue());
        }
    }
}
