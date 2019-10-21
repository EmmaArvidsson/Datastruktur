using System;

namespace Linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add First: ");
            LinkedList mylist = new LinkedList();

            mylist.AddFirst(2);
            mylist.AddFirst(8);
            mylist.AddFirst(5);
            mylist.PrintList();

            Console.WriteLine("Add last: ");
            LinkedList mylist2 = new LinkedList();

            mylist2.AddLast(3);
            mylist2.AddLast(56);
            mylist2.AddLast(89);
            mylist2.PrintList();

            Console.ReadLine();


        }
    }
}
