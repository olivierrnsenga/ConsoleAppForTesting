using System;

namespace ConsoleAppForTesting
{
    public class IsNumberEvenOrOdd
    {
        public string Execute()
        {
            int n;
            Console.Write("Enter number");
            n = Int32.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
    }
}