
namespace Code_Tasks
{
    //QUESTION: A Binary Gap is a consecutive occurance of 0s in between 1s.
    // Given a positive integer N, return the longest  binary gap in Array N
    //The function should return 0 if N doesn't contain a binary gap.
    public static class BinaryGap
    {
        public static int GetBinaryGap(int N)
        {
            string binaryOfNum = Convert.ToString(N, 2);

            int longestZeroCount = 0;

            int zeroCounter = 0;

            for (int i = 1; i < binaryOfNum.Length; i++)
            {
                // Check for first 0 digit occuring after a 1 digit and start zero counter
                if (binaryOfNum[i] == '0' && binaryOfNum[i - 1] == '1')
                {
                    zeroCounter++;
                }

                // Check for 0 digit occuring after after 0 digit counter started
                else if (binaryOfNum[i] == '0' && zeroCounter > 0)
                {
                    zeroCounter++;
                }

                // Check for first 1 digit occuring after start of  0 digit counter then restart counter
                else if (binaryOfNum[i] == '1' && zeroCounter > 0)
                {
                    longestZeroCount = zeroCounter > longestZeroCount ? zeroCounter : longestZeroCount;
                    zeroCounter = 0;
                }
            }

            return longestZeroCount;
        }
    }
}
