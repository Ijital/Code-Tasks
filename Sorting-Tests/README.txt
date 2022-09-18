SORTING ALGORITHMS

Sorting is a way of arranging a collection of data so as to access data more efficiently.
Its sort of thesame reason why books are sorted in the library in order for Library users
to easily retrieve a book they are searching for. 

A sorting algorithm is an algorithm that puts elements of a list in a certain order.

BUBBLE SORT

This algorithm rearranges items in a collection from smallest to largest value based 
on some comparison logic. E.g Integers can be sorted by simply comparing thier values but
Other complex objects may need to define an IComparer or may be compared by a given property. 
The algorithm involves looping through each element in array and comparing its value with the
value of the element after it. If the value of the element after it is less then swapp both elements.
This continues untill there is no element in the array that is greater than the element in front of it.

         int[] arr = { 78, 55, 45, 98, 13 };
         int temp;

         for (int j = 0; j <= arr.Length - 2; j++) 
	   {
            for (int i = 0; i <= arr.Length - 2; i++) 
		{
               if (arr[i] > arr[i + 1])
		   {
                  temp= arr[i + 1];
                  arr[i + 1] = arr[i];
                  arr[i] = temp;
               }
            }
         } 

ARRAY.SORT();
If the size of an array is less than 16 elements then Array.Sort uses an insertion sort algorithm. If the size exceeds
2 * log^N, where N is the range of the input array, it uses a Heap Sort algorithm.Otherwise, it
uses a Quicksort algorithm.

HEAP SORT



