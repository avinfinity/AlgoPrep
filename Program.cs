using System;

namespace AlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            UniquenessCheck.Verify();

            Console.WriteLine("Reversed".Reverse());
            Console.WriteLine("".Reverse());
            Console.WriteLine(string.Empty.Reverse());

            Assert.IsTrue("Reversed".Reverse().Reverse() == "Reversed");

        }
    }
}
