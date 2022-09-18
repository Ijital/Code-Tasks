using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Task
{
    internal class Program
    {
   
        static void Main(string[] args)
        {
            var ss = GetFibanaciWIthRecursion(144);
            Console.WriteLine(ss);
            Console.Read();
        }


        /// <summary>
        /// Given a number num, get the index of the number in a fibanaci series
        /// </summary>
        static private int GetFibanaciWIthRecursion(int num)
        {

            if (num < 2)
            {
                return num; 
            }

            return GetFibanaciWIthRecursion(num - 1) + GetFibanaciWIthRecursion(num - 2);
        }

        static private int GetFibonaci(int A, List<int> nums = null)
        {
            if (nums == null)
            {
                nums = new List<int>()
                {
                    0, 1,1
                };            
            }


            if (nums[nums.Count() - 1] + nums[nums.Count() - 2] > A)
            {
                throw new ArgumentException("Number is not in Finnac series");
            }

            if (nums[nums.Count()-1] + nums[nums.Count() - 2] == A)
            {
               return nums.Count();
            }

            nums.Add(nums[nums.Count() - 1] + nums[nums.Count() - 2]);

            return GetFibonaci(A, nums);
        }

        /// <summary>
        /// Returns the factorial of a a given number num
        /// </summary>
        static private int GetFactoriaWithRecursion(int num)
        {

            return GetFactorial(num);
        }

        static private int GetFactorial(int A, int factorial = 1)
        {
            if (A > 1)
            {
                factorial *= A;
                return GetFactorial(--A, factorial);
            }
            return factorial;
        }
    }
}
