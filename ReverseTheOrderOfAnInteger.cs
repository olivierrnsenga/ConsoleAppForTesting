namespace ConsoleAppForTesting
{
    public class ReverseTheOrderOfAnInteger
    {
        public int Execute()
        {
            int number = 12345;
            int ReversedNumber = 0;
            while (number > 0)
            {
                ReversedNumber = (ReversedNumber * 10) + (number % 10);
                number = number / 10;
            }

            return ReversedNumber;
        }
    }
}