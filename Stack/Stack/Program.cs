using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();


            string s=

            for (int i = 0; i < s.Lenght; i++)
            {
                if(s[i] == '<')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);

                }
            }

            foreach (var item in stack)
            {
                Console.Write(item);
            }

        }
    }
}
