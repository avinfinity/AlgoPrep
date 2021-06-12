using System;

namespace AlgoPrep
{
    public class Program
    {
        static void Main(string[] args)
        {
            // UniquenessCheck.Verify();

            // Console.WriteLine("Reversed".Reverse());
            // Console.WriteLine("".Reverse());
            // Console.WriteLine(string.Empty.Reverse());

            // Assert.IsTrue("Reversed".Reverse().Reverse() == "Reversed");

            MyQueue queue = new MyQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

          Console.WriteLine(queue.Dequeue());
           Console.WriteLine(queue.Dequeue());
           Console.WriteLine(queue.Dequeue());
        }
    }
}
