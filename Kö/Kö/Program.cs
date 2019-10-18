using System;
using System.Collections;

namespace Kö
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(12);
            queue.Enqueue(67);
            queue.Enqueue(3);

            Console.WriteLine(queue.Peek());

            queue.Dequeue();

            Console.WriteLine(queue.Peek());

            queue.Dequeue();

            Console.WriteLine(queue.Peek());

            Console.WriteLine("Hur många element det är i kön" + queue.Count);



        }
    }
}
