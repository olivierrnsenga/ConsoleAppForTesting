using System;

namespace ConsoleAppForTesting
{
    public class FindLargestNumberAmongThreeNumbers
    {
        public int Execute(int num1, int num2, int num3)
        {
            // set the value of the three numbers

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    return num1;
                }
                else
                {
                    return num3;
                }
            }
            else if (num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }

        public int ExecuteUsingFunction(int num1, int num2, int num3)
        {
            return Math.Max(Math.Max(num1, num2), num3);
        }
    }
}