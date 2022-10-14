using System;

namespace ConsoleAppForTesting
{
    public class FindSumAndAverage
    {
        public string Execute()
        {
            Console.WriteLine("Enter the Size :");
            var size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the Elements of the Array : ");
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int len = a.Length;

            return ComputeSumAverage(a, len);
        }

        public string ComputeSumAverage(int[] arr, int size)
        {
            int sum = 0;
            int average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            average = sum / size;
            return ("Sum Of Array is : " + sum + "Average Of Array is : " + average);
        }
    }
}