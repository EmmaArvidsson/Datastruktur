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
            Console.WriteLine("Hur många element det är i kön: " + queue.Count);

            queue.Dequeue();
            

            Console.WriteLine(queue.Peek());
            Console.WriteLine("Hur många element det är i kön: " + queue.Count);

            queue.Dequeue();

            Console.WriteLine(queue.Peek());

            Console.WriteLine("Hur många element det är i kön: " + queue.Count);

            string k = "Jag har en katt";
            string u = "Jag har inte en katt";

            int a = 4;
            int b = 6;

            Console.WriteLine(a + "  " + b);
            Swap<int>(ref a, ref b);
            Console.WriteLine(a + "  " + b);

            
            Queue<string> k = new Queue<string>();
            Queue< string > u = new Queue<string>();
            Swap<Queue<string>>(ref k, ref u);

        }
    }
}
