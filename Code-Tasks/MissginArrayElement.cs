
using System.Collections.Immutable;

namespace Code_Tasks
{
    public static class MissginArrayElement
    {
        /// <summary>
        /// QUESTION: Given an array of N number of different integers. The elements of the array
        /// however have values within the range 1---N+1/ This means there is one missing 
        /// element from the consequtive sequence. Get that element.
        /// 
        /// SOLUTION: Sort the Array so that they are in ascending order and then iterate
        /// Where the element does not match the index then thats the missing element
        /// </summary>

        public static int GetMissingElement()
        {

            int[] A = { };
            Array.Sort(A);

            int missingElement = 0;
       
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] != i + 1)
                    {
                        missingElement = i + 1;
                        break;
                    }
                }


            return missingElement;
        }
    }
}
