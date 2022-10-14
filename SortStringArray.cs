using System;

namespace ConsoleAppForTesting
{
    public class SortStringArray
    {
        public void Execute()
        {
            // sort string array
            string[] stringArray = new string[5] { "X", "B", "Z", "Y", "A" };
            Array.Sort(stringArray);
            // write array
            foreach (string str in stringArray)
            {
                Console.Write(str + " "); // output: A B X Y
            }

            Array.Sort(stringArray);

            // reverse array
            Array.Reverse(stringArray);

            // print all element of array
            foreach (string value in stringArray)
            {
                Console.Write(value + " ");
            }
        }
    }
}