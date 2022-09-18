using System.Collections.Generic;
using System;
using System.Linq;

namespace Linked_List_Tasks
{ 
    public class Program
    {
        static string[] names = { "Melvin", "Hannah", "Jonah", "Sena", "Yuana" };

        static LinkedList<int> myLinked = new LinkedList<int>();
        // A LinkedList is a data strucures where each entry contains its primary data
        // But also contains the memory address of the entry that will be made after it. 
        static void Main(string[] args)
        {
            #region INSERTIONS

            // Initialises a linked list using an IEnumberable, 
            // BIG O = O(N)
            LinkedList<string> list = new LinkedList<string>(names);

            // Adds the very first item in the Linked list. 
            // BIG O = O(1)
            myLinked.AddFirst(2);

            //  If there is already a first item in LinkedList, adding new first item will
            //  displace the initial first and push the first to second position
            // BIG O = O(1)
            myLinked.AddFirst(1);

            // Appends a new item to the end of the the linked list, this means traversing to the end and 
            // then making the addition
            // BIG O = O(N)
            myLinked.AddLast(3);

            // BIG O = O(N)
            myLinked.AddLast(5);

            // Inserts a new LinkedList node with value 4, just before the first node having the value 5
            // Worst case scenrio would involving adding at the end of the list which would mean traversing
            // to the end of the list
            // BIG O = O(N)
            myLinked.AddBefore(myLinked.Find(5), 4);

            // Inserts a new LinkedList node with value 6, just after the first node having the value 5
            // BIG O = O(N)
            myLinked.AddAfter(myLinked.Find(5), 6);

            #endregion


            #region SEARCHES
            // How to get linked list element at index, 
            // BIG O = O(N)
            myLinked.ElementAt(2);

            // Gets the first Node that has the specified value
            // BIG O = O(N)
            var gus = myLinked.Find(2);
      
            // Traversing the linked list using foreach
            foreach (var item in myLinked)
            {
                Console.WriteLine(item);
            }

            #endregion

            // Get element at memory location 2 from the linked list head
            var see = myLinked.ElementAt(2);

            #region SORT

            //Retruns an INumerable
            var hhh = new LinkedList<int>(myLinked.Reverse());
            #endregion

            Console.Read();
        }
    }
}
