using System;
using System.Collections.Generic;
using System.Text;

namespace Kö
{
    class Queue<T>
    {

        private T[] queue;

        private int count = 0;

        public int Count
        { get { return count; } }


        public T this[int i]
        {
            get { return queue[i]; }
            set { queue[i] = value; }
        }

        public Queue()
        {
            queue = new T[10];
        }

        public Queue(int size)
        {
            queue = new T[size];
        }



        public void Enqueue(T value)
        {
            if (queue.Length == count)
                ReSize((int)(count * 1.3));

            queue[count] = value;
            count++;

        }

        public T Dequeue()
        {
            count--;
            if (count == queue.Length/2 && queue.Length >  100)
                ReSize((int)(count * 1.3));

            T var = queue[0];

            for (int i = 0; i < Count; i++)
            {
                queue[i] = queue[i + 1];
            }

            return var;

        }


        public T Peek()
        {
            return queue[0];
        }


        private void ReSize(int size)
        {
            T[] temp = queue;
            queue = new T[size];

            for (int i = 0; 1 < count; i++)
            {
                queue[i] = temp[i];
            }
        }

        public void Clear()
        {
            count = 0;
            queue = new T[10]; 
        }
    }
}
