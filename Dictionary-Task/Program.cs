using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace Dictionary_Task
{
    public class Program
    {
        // Dictionary is a collection of items but these are not refrenced with indexes. 
        // They are only indexed with uniques keys supplied when the entries are made. 
        // For this reason there cannot be duplicate keys

        static Dictionary<string, string> myDictionary = new Dictionary<string, string>()
         {
            {"UK", "London"},
            {"USA", "Washington"},
            {"Nigeria", "Abuja"},
            {"Japan", "Tokyo"}
         };

    
        // HashSet is a Dictionary with only keys and no value. 
        // For this reason there cannot be duplicate keys. Any publicate addition is ignore. 
        // Unlike Dictionary where duplicate addition throws an exception
        static HashSet<string> myHashSets = new HashSet<string>
        {
            "UK", "USA", "Nigeria", "Japan","UK"
        };

        // Sorted list is similar to Dictionary with the difference that sorted lists
        // Automatically sort thier elements
        static SortedList<char, string> mySortedItems = new SortedList<char, string>();

        static void Main(string[] args)
        {

            // Like dictionry we access a value from HashSet like we do in dictory using the TryGetValue method
            // Trying to acessing a non existant key in HasSet return null just like in Dictionay 
            // BIG O = O(1)
            myHashSets.TryGetValue("UKk", out string ss);


            foreach (var item in myHashSets)
            {
                Console.WriteLine(item);
            }

            // Adding an already exisiting key in Hashset will be ignored while dictionary wthis will throw ex
            myHashSets.Add("UK");

          
            // Key Search Worst case scenario
            // BIG O = O(N)   
            var gg = myDictionary.ContainsKey("USA");

            // Value Search, Worst case scenario
            // BIG O = O(N) 
            var gg2 = myDictionary.ContainsValue("USA");

            // Insertion, Worst case scenario
            //BIG O= O(N)
            myDictionary.Add("France", "Paris");

            // Deletion, Worst case scenario
            // BIG O = O(N)
            myDictionary.Remove("USA");


            // Look Up, Worst case scenario
            // BIG O = O(N)
            var myVal =  myDictionary["USA"];

            //Checks if a list contains specified key and returns true if key is found
            //Worst case scenario 
            // BIG O = O(N)
            bool myKeyss = myDictionary.TryGetValue("UK", out string city);

            // A sorted list sorts the elements as they are added so you dont have to sort them later.
            //The elements are sorted by thier key values. Integer keys are simply compared by thier values
            // Char key values are compared by thier decimal values e.g b is greater than a.
            mySortedItems.Add('!', "gd");
            mySortedItems.Add('Z', "gd");
            mySortedItems.Add('a', "Three");
            mySortedItems.Add('f', "One");
            mySortedItems.Add('g', "Two");
            mySortedItems.Add('s', null);
            mySortedItems.Add('m', "Ten");
            mySortedItems.Add('v', "Five");
            mySortedItems.Add('z', "Five");


            Console.Read();

        }
    }
}
