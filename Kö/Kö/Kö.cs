using System;
using System.Collections.Generic;
using System.Text;

namespace Kö
{
    class Queue
    {

        private int[] queue;

        private int count = 0;

        public int Count
        { get { return count; } }


        public int this[int i]
        {
            get { return queue[i]; }
            set { queue[i] = value; }
        }

        public Queue()
        {
            queue = new int[10];
        }

        public Queue(int size)
        {
            queue = new int[size];
        }



        public void Enqueue(int value)
        {
            if (queue.Length == count)
                ReSize((int)(count * 1.3));

            queue[count] = value;
            count++;

        }

        public int Dequeue()
        {
            count--;
            if (count == queue.Length/2 && queue.Length >  100)
                ReSize((int)(count * 1.3));

            int var = queue[0];

            for (int i = 0; i < Count; i++)
            {
                queue[i] = queue[i + 1];
            }

            return var;

        }


        public int Peek()
        {
            return queue[0];
        }



        private void ReSize(int size)
        {
            int[] temp = queue;
            queue = new int[size];

            for (int i = 0; 1 < count; i++)
            {
                queue[i] = temp[i];
            }
        }

        public void Clear()
        {
            count = 0;
            queue = new int[10]; 
        }
    }
}
