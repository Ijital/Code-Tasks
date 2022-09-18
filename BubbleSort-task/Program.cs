using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_task
{
    internal class Program
    {
        static int[] numbers = new int[] { 3,2,1,0,34,4,3,44,3,2,24,5,2,1,2,44,34,12,3};
        static void Main(string[] args)
        {
   
            var des = BubbleSort(numbers);
            Console.Read();
        }

        private static int[] BubbleSort(int[] numbers)
        {
            bool swaps = true;

            while (swaps)
            {
                swaps = false;

                for (int i = 0; i < numbers.Length-1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int tempValue = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = tempValue;
                        swaps = true;
                    }
                }
            }
            return numbers;
        }
    }
}
