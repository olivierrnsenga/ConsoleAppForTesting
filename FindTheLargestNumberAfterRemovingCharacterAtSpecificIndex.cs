namespace ConsoleAppForTesting
{
    public class FindTheLargestNumberAfterRemovingCharacterAtSpecificIndex
    {
        public string Execute(string number, char index)
        {
            // string number = "15958";
            //char index = '5';

            return RemoveX(number, index);

            // Function call
            // Console.Write(RemoveX(N, X));
        }

        // Function to find the largest number after removing character at specific index
        private string RemoveX(string N, char X)
        {
            // Stores the index of X
            // that has to be removed
            int index = -1;

            // Find leftmost occurrence of X
            // such that the digit just after X
            // is greater than X
            for (int i = 0;
                 i < N.Length - 1;
                 i++)
            {
                if (N[i] == X
                    && N[i] - '0'
                    < N[i + 1] - '0')
                {
                    // Update index and break
                    index = i;
                    break;
                }
            }

            // If no occurrence of X such that
            // the digit just after X
            // is greater than X is found
            // then find last occurrence of X
            if (index == -1)
            {
                for (int i = N.Length - 1;
                     i >= 0;
                     i--)
                {
                    if (N[i] == X)
                    {
                        index = i;
                        break;
                    }
                }
            }

            // Construct answer using all characters
            // in string N except index
            string ans = "";
            for (int i = 0; i < N.Length; i++)
            {
                if (i != index)
                    ans = ans + N[i];
            }

            return ans;
        }
    }
}