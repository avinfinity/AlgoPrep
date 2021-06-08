using System;
namespace AlgoPrep
{
    public static class Assert
    {
        public static void IsTrue(bool value)
        {
            IsFalse(!value);
        }

        public static void IsFalse(bool value)
        {
            if (!value)
            {
                Console.WriteLine("Assert Passed");
            }
            else
            {
                Console.WriteLine("Assert Failed");
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}