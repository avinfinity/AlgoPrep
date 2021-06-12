using System;
using System.Collections;

namespace AlgoPrep
{
    public class MyQueue
    {
        private readonly Stack first = new Stack();
        private readonly Stack second = new Stack();

        public void Enqueue(int n)
        {
            first.Push(n);
        }

        public int Dequeue()
        {
            if(second.Count == 0)
            {
                while(first.Count != 0)
                {
                    second.Push(first.Pop());
                }
            }
            return (int)second.Pop();
        }
    }
}