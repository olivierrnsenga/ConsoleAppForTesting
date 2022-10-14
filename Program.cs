using System;

namespace ConsoleAppForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, A, B;
            Console.WriteLine("Input: ");
            Console.WriteLine("-------------------------");
            Console.Write("A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write("N: ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nOutput: ");
            Console.WriteLine("-----------------------------------");
            for (int i = 1; i <= N; i++)
            {
                if (i % A == 0)
                {
                    Console.Write("F");
                    if (i % B == 0)
                    {
                        Console.Write("B");
                    }
                }

                else if (i % B == 0)
                {
                    Console.Write("B");
                }
                else
                {
                    Console.Write(i);
                }
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}