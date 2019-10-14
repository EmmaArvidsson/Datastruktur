using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack
    {
        private int[] stack;
        private int count = 0;


        public int Count
        { get { return count; }  }

        public int this[int i]
        {
            get { return stack[i]; }
            set { stack[i] = value; }

        }

        public Stack()
        {
            stack = new int[18];
        }

        public Stack(int size)
        {
            stack = new int[size];
        }


        public void Push(int value)
        {
            if (stack.Length == count)
                ReSize((int)(count * 1.3));

            stack[count] = value;
            count++;
        }

        public int Pop()
        {
            count--;
            if (count == stack.Length / 2 && stack.Length > 100)
                ReSize((int)(count * 1.3));

            return stack[count];
        }

        private void ReSize(int size)
        {
            int[] temp = stack;

            stack = new int[size];

            for (int i = 0; i < count; i++)
            {
                stack[i] = temp[i];
            }
        }

        public void Clear()
        {
            count = 0;
            stack = new int[18];
        }
    }
}
