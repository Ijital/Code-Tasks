using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Threading;

namespace Searchin_Tasks
{
    internal class Program
    {
        static int[] numsArray = { 1,2,3,4,5,6,7,9,12,13,16,18,23,45,45,56, 60,65,73,80,99,110,115,122,125,130,140,145,156,160,170,175,187,200,212,233,240,250,255,260,270,300,311,312,322,324,325,330,331,332,333,334,335,336,337,338,339,350 };
        static void Main(string[] args)
        {

            Stopwatch s = new Stopwatch();
            s.Start();
            var des = numsArray.First(d=>d==350);
            s.Stop();
            Console.WriteLine("Time is took for Normail search to complete is " + s.Elapsed.TotalMilliseconds);

            Stopwatch t = new Stopwatch();
            t.Start();
            var dese= GetItemByBinary(numsArray, 350);
            t.Stop();
            Console.WriteLine("Time is took for Binary Search to complete is "+ t.Elapsed.TotalMilliseconds);


            Console.Read();
        }

        #region LINEAER SEARCH
        // Linear search is done traversing a linear collection by i,e you go from the first
        // element to the next untill you find the target value 
        // or untill all the items in the collections are checked
        // Worse case scenario is
        // BIG O = O(N)
        // All the Linear searches have been mentioned in Linear Collections
        // i.e Array, List, LinkedList

        #endregion

        #region BINARY SEARCH
        // If an array is sorted then it is more efficient to use binary search. 
        // Binary search involes picking a middle item, compary it with the target value
        // If the middle item is less that the target value then you pick the middle item 
        // from first item to the last muiddle. You contiune untill you arrive at the target value
        // BIG O = O(LOG N)
        static private int GetItemByBinary(int[] nums, int target)
        {
            int lower = 0;
            int upper = nums.Length - 1;
            int index = -1;

            while (index < 0)
            {
                int mid = (upper + lower) / 2;

                if (nums[mid] == target)
                {
                    index = mid;
                    break;
                }

                if (mid == 0)
                {
                    index = nums[0] == target ? 0 : 1;
                    break;
                }
                if (mid == nums.Length - 2)
                {
                    index = nums[nums.Length - 2] == target ? nums.Length - 2 : nums.Length - 1;
                    break;
                }
                if (target > nums[mid])
                {
                    lower = mid;
                }
                else if (target < nums[mid])
                {
                    upper = mid;
                }

            }
            return index;
        }
        #endregion

    }
}
