

namespace Sorting_Tests
{
    public class Program
    {
        static int[] numbers = new int[] { 5, 4, 3, 2, 1, 4, 5, 6, 7, 99, 3, 4, 56 };
        static void Main(string[] args)
        {
            int a = 33;
            int b = 34;

            var semba = a.GetHashCode();
            var sena = b.GetHashCode();

            var ss= IsertionSort(numbers);

            var bubbled = BubbleSort(numbers);
        }

        /// <summary>
        /// Very inefficient. You 
        /// </summary>
        // BIG O = O(N^2) rarely used, not veru effieceint
        private static int[] BubbleSort(int[] numbers)
        {
            bool wasThereASwap = true;

            while (wasThereASwap)
            {
                wasThereASwap = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int tempValue = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = tempValue;
                        wasThereASwap = true;
                    }
                }
            }
            return numbers;
        }

        /// <summary>
        /// Insertion Sort. We loop through each position  in the entire array 
        /// For each position we loop through the remainder of the array and get the smallest
        /// amongst the remaining items to fill the spot. 
        /// i.e Start from index 0, loop the rest of the array to find the smallest, move the value in index 0 to
        /// the index where smallest is found and move the value of smallest from the index where it is found to 
        /// index 0. 
        /// Then move to index 1 and repeat the steps
        /// </summary>
        ///  // BIG O = O(N^2) rarely used, not veru effieceint
        private static int[] SelectionSort(int[] numbers)
        {
            for (int a = 0; a < numbers.Length; a++)
            {
                int tempSmallest = numbers[a];
                int indexOfTempSmallest = 0;

                for (int b = a; b < numbers.Length; b++)
                {
                    if (numbers[b] < tempSmallest)
                    {
                        tempSmallest = numbers[b];
                        indexOfTempSmallest = b;
                    }
                }
                if (tempSmallest != numbers[a])
                {
                    numbers[indexOfTempSmallest] = numbers[a];
                    numbers[a] = tempSmallest;
                }
            }

            return numbers;
        }

        /// <summary>
        /// This is effieceint when you are sure he collection is almost sorted
        /// but its worst case scenrio is also O(N^2)
        /// </summary>
        private static int[] IsertionSort(int[] numbers)
        {
            for (int a = 1; a < numbers.Length; a++)
            {
                int val = numbers[a];

                for (int b = a - 1; b >= 0; b--)
                {
                    if (numbers[b] > val)
                    {
                        numbers[b + 1] = numbers[b];
                    }

                    if (numbers[b] == val)
                    {
                        numbers[b + 1] = val;
                        break;
                    }
                     if (b == 0 && val < numbers[1])
                    {
                        numbers[b] = val;
                        break;
                    }
                }
            }
            return numbers;
        }


        #region DIVIDE AND CONQUER SORTING ALGORITHMS

        // The sorting algortims above are not very efficient, the following sorting algorthms 
        // use the divide and conquoer algorithm, an idea that is used in Tree data structures
        // Where the entire collection would not have to be traversed when searching for an item



        #endregion


    }
}
