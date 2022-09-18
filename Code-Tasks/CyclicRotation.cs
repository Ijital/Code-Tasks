using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Tasks
{
    /// <summary>
    /// QUESTION: Rotate an array A Anti clockwise K number of times
    /// </summary>
    public static class CyclicRotation
    {
        public static int[] GetRotatedArray(int[] A, int K)
        {
            for (int i = 1; i <= K; i++)
            {
                int last = A[A.Length - 1];

                for (int a = A.Length - 1; a > 0; a--)
                {
                    A[a] = A[a - 1];
                }
                A[0] = last;
            }
            return A;
        }


        public static int[] GetRotatedArrayElegant(int[] A, int K)
        {
            for (int i = 1; i <= K; i++)
            {
                int last = A[A.Length - 1];

                A = A.SkipLast(1).Prepend(last).ToArray();
            }
            return A;
        }

    }

   
}
