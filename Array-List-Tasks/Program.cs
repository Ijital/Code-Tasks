
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Array_List_Tasks
{
    public class Program
    {
        static List<int> nums1 = new List<int> { 1, 8, 8, 2, 3, 3, 4, 4, 5, 5, 6, 3, 2, 3, 3, 2, 3, 2, 4, 5, 6, 3, 2, 4, 5, 3 };
        static List<int> nums2 = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1, 10, 11, 12, 20, 23, 24, 34, 35, 38, 44, 47, 77, 78 };
        static int[] numsArray = { 9, 6, 8, 7, 6, 7, 5, 3, 4, 3, 2, 1, 10, 9, 11, 12, 20, 23, 24, 34, 35, 38, 44, 47, 77, 78 };
        static string[] names = { "Melvin", "Hannah", "Jonah", "Sena", "Yuana" };
        static List<string> namesList = new List<string> { "Melvin", "Hannah", "Jonah", "Sena", "Yuana" };
        static List<string> ati = new List<string> { "mel", "Jona", "Yauna" };
        static List<string> myWord = new List<string> { "Hello ", "World" };




        //PRIMITIVE TYPE COMPARERS

        // INT DOUBLE, FLOAT
        // These are compared by thier positions on the number line
        // e.g 2 is greater than 1

        // CHAR
        // These as also compared by thier positions in the alphabet line
        // The Alpha line is as follows a....z.A...Z

        // A-Z have corresponding decimal values from 60 - 90
        // a-z have have corresponding decimal values from 97 - 122

        // STRING, two strings are compared character for character starting
        // from the beging of the two words untill a character in one word
        // is greater than its positional counterpart in the other word
        // e.g   "abc" is less than "abd" because the third character in abc is less 
        // than the third character in abd


        static void Main(string[] args)
        {

            // Most Linq methods return an IEnumerable and if your algorthm wants to maintain the 
            // thier original type then you may want to not use Linq methods because converting
            // from IEnumerable back to the original type e.g ToList() has  Big O of O(n)

            #region CONVERSIONS

            // Converting to Dictionary would cause exception because Dictionay is not allowed to
            // Have two key to bethesame. However the method ToLookUp converts this into a dictionary
            // Of Arrays where values with thesame key are in thier on array in the dictionary.
            // Almost like a GroupBy method
            ILookup<int, int> myDikshon = nums1.ToLookup(a => a, b => b);

            //Convert integer array to Dictionary

            int s = 0;
            var myDictionary2 = numsArray.ToDictionary(x => s++, y => y);


            // Returns a bool indicating if array contains the value passes
            // BIG O = O(N)
            bool contains4 = nums1.Contains(4);

            // copies items in an array and forms a dictionary where x is the item used to make the key and y is the value
            // BIG O = O(N)
            var myDictionary = nums2.ToDictionary(x => x, y => (y + 2));

            // Instantiates a List using an Array. Behind the scences this calls the constructor 
            // new List<string>(names) and this loops through the array N timee to copy every item
            // BIG O = O(N)
            var arrToList = names.ToList();

            #endregion


            #region INSERTIONS

            // Behind the scenes, the add operation is creating a new array with bigger capacity
            // and then lopying through and copying the items from the old array into new, this should
            // be a B(N) however the copying over of items to a new array doesnt happen with every Add()
            // This is because whnever the old array runs out of space, its space is doubled before creating
            // the new array. so if an array has a size of 1000. if the size is exceeded, then the new array
            // will be created with a size of 2000. and its a long time before the 2000 is exceeded. Effectitves
            // this is amounts to a Big O of
            // BIG O = O(1)
            namesList.Add("Bobby");

            // Inserts a new element into a collection at the specified index, pushing all follwoing elements forward
            // BIG O = O(N)
            nums1.Insert(0, 6);


            // Inserts a collecton of itmes nums2 into another collection num1 starting from the specifed index
            // BIG O = O(N)
            nums1.InsertRange(1, nums2);


            // Returns a new IEnumerable which Adds a new element at begining of the nums1 pushing all exisiting elements forward by 1. 
            // Worst case BIG O = O(N)
            var newElem = nums1.Prepend(9);


            #endregion


            #region DELETIONS

            // Removes the first occurance of a specified vale in the collection
            // BIG O = O(N)
            nums1.Remove(3);

            // Removes the All elelements of a collection that specify the predicate 
            // BIG O = O(N)
            nums1.RemoveAll(e => e == 3);

            // Removes an element from collection nums1 at the specified index 2,
            // This would mean traversing elements from the index removed to the end of the array
            // This should be a Big O of O(N-index), but remove all constants and this becomes
            // BIG O = O(N)
            nums1.RemoveAt(2);

            //Starting from index 1, removes 2 elements from collection nums1
            // BIG O = O(N)
            nums1.RemoveRange(1, 2);

            // Remove the last element from the collection,There is no need to iterate the array
            // to reassing indexes do its 
            // BIG O =  O(1) 
            nums1.RemoveAt(nums1.Count - 1);

            #endregion


            #region SEARCHES

            //Gets the very first element in the collection 
            //BIG O =  O(1)
            var f = nums2.First();

            //Gets the very first element in the collection that is greater than 5, worst case scenario 
            // the element is the last item in the list and the entire array is iterated
            // BIG O = O(N)
            var f2 = nums2.First(d => d < 5);

            // Returns true if any element in the colleciotn satifies the predicate
            // BIG O =  O(N)
            bool any4 = nums1.Any(n => n == 4);

            // Returns a bool mama which indicates wether there exists an element in the collection nums1
            // That satisties the condition defined by the predicate. Similar to "Any"
            // Worst case BIG O = O(N)
            bool mama = nums1.Exists(i => i < 10);


            //Returns the first occurance of element in collection nums1 that satisfies the prdicate
            // BIG O    O(N)
            var item = nums1.Find(x => x > 8);


            // Returns the last occurance of an element that satifies the predicate
            // Worst case BIG O = O(N)
            var item5 = nums1.FindLast(x => x < 6);


            // Returns the index of the last occurance that satifies the predicate
            // Worst case BIG O = O(N)
            var indexm = nums1.FindLastIndex(i => i < 10);

            #endregion


            #region SORTING

            // Sorts an array using the default comparerr of the items in the collection
            // BIG O = 
            nums1.Sort();


            // Sorts 3 items starting from index 2 an array using the default comparerr given than null was provided
            // starting from index 2 and sorting 3 items
            // BIG O = O(N)
            nums2.Sort(2, 3, null);

            // Returns a new collection by sorting the collection nums1. Its sorts it by 
            // Arranging the elements from smallest to largest. Duplicates are placed consecutively
            // next to each other. In the case of object collections, 'd' would a comparar property used for the sort
            var des = nums1.OrderBy(d => d);

            // Return a collection of collection where the orded group of duplicates are arranges on thesame new array. In GroupBy, the grouped 
            //duplicates are placed in thier own seperate array. This means that 'dese' is an array of arrays
            var dese = nums1.GroupBy(d => d);

            // group by ranges
            var ranges = nums1.GroupBy(a => a);

            //Reverses the elements of the list nums1
            // Worst case BIG O = O(N/2) but removing constants we have O(N)
            nums1.Reverse();

            //Reverses the elements of the list nums1 from index 2 and lenght 3
            // Worst case BIG O = O(1)
            nums2.Reverse(2, 3);


            #endregion

            // Instantiate and populate all elements of new array with a given value
            // In example, 10 is the lenght of the array and 3 is the value of each of the 10 elements
            // BIG O =  O(N) N being the count in this example being 10
            List<int> myArr = Enumerable.Range(3, 10).ToList<int>();


            //Gets a new collection 'NewArray' from applying an action on corresponging elements of two other different arrays
            // Note: a is element from num1 and b is index corresponding element in nums2
            // Zip iterates over two arrays at thesame time for  a number of times equal to the lenght of the shorter of the two. 
            // BIG O, O(N)
            var newArray = nums1.Zip(nums2, (a, b) => a - b);


            // Returns true if all elements of collection nums1 satisfies the predicate
            // BIG O =  O(N)
            bool itemsLessThan6 = nums1.All(n => n < 6);


            // Returns a new collection newOne by skipping first specifed number of elements from another collection
            // BIG O = O(1) or BIG O = O(N).
            var newOne = names.Skip(3).ToList();


            // Use skip to pick the last specified number of elements e.g below picks the last 1 element
            var newOnes2 = nums1.Skip(nums1.Count() - 1);

            // iterate the itmes of a collection and runs the action specied
            nums1.ForEach(i => Console.WriteLine(i));

            // Returns a new collection newArray9 consiting of distict elements that occur in num and num2.
            // duplicate elements are not picked
            var newArray9 = nums1.Union(nums2);

            var indexOfNum = nums1.BinarySearch(2);

            // Returns an array that is produced from removing elements from num1 which are also in nums2
            // This includes removing duplicates as well
            // Worst case BIG O = O(N)
            var newArray4 = nums1.Except(nums2);
        }

        /// <summary>
        /// Manually reversing a string. Time complexity n/2 which is  O(log n)
        /// i.e worse case scenario is the array will be looped half its size
        /// BIG O = O(N)
        /// </summary>
        private static string ReverseStringManaually(string myString)
        {
            var temWord = string.Join("", myString).ToCharArray();
            int numOfExcahnges = temWord.Length / 2;

            for (int i = 0; i < numOfExcahnges; i++)
            {
                char tempChar = temWord[i];

                int LastInd = temWord.Length - (i + 1);

                temWord[i] = temWord[LastInd];

                temWord[LastInd] = tempChar;
            }
            return string.Join("", temWord);
        }

        /// <summary>
        /// Manually reversing a string with Linq
        /// BIG O = O(N)
        /// </summary>
        private static string ReverseStringManaually2(string myString)
        {
            var temWord = string.Join("", myString).ToCharArray();

            return string.Join("", temWord.Reverse());

        }

        /// <summary>
        /// Find first recurring value in an array
        /// </summary>

        private static int GetFirstRecurringValue(int[] arr)
        {
            var dic = new Dictionary<int, int>();

            int recuringVal = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    dic.Add(arr[i], arr[i]);
                }
                catch (Exception)
                {
                    recuringVal = arr[i];
                    break;
                }
            }
            return recuringVal;
        }

    }
}
