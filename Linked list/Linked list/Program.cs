using System;

namespace Linked_list
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
            Console.WriteLine("Add First: ");
            LinkedList<int> mylist = new LinkedList<int>();

            mylist.AddFirst(2);
            mylist.AddFirst(8);
            mylist.AddFirst(5);
            mylist.PrintList();

            Console.WriteLine("Add last: ");
            LinkedList<int> mylist2 = new LinkedList<int>();

            mylist2.AddLast(3);
            mylist2.AddLast(56);
            mylist2.AddLast(89);
            mylist2.PrintList();

            Console.ReadLine();


        }
    }
}
