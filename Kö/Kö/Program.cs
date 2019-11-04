using System;

namespace Kö
{
    class Program
    {

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

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
