ARRAY, 

Array is a data strucrure that stores items in sequenctial memory locations. Because of this 
Array items inherit an index numbers corresponding to the position where they are entired. i,e first entry in
the collection will have an index of 0, Second will have an idex of 1 etc. Because of this it is time cheap to quickly
jump to a memory location when accessing items with Arrays by index. 

LIST

List is basically a class that wraps an Array, Internally it holds its items in an array which it re-instantiates
whenever the array runs out of space. So whenever you create an array you need to declare its length so that a 
continuous block of memory will be reserved for it. Whenever you need to expand the array length then there is a
need to make a fresh reservation of  memory blocks. i,e re instantiate a new array and copy the items in the old to the new.
    

COMPARISON: Array and LinkedList

Arrays and Lists is faster than LinkedList for accessing data as the processer can simply jump to the index position whereas
the linkedList would have to traverse the list from the begining untill it finds the element it it looking for. On the other 
hand the Array and List are slower at removing or inserting elements in the middle of the collection. Arrays and List use 
indexes when making entries and any deletion or addition in the middle would involve some operagion to shift all the affected
items to newer positions. LinkedList does care about postioning of items, the items can be anywhere in memory. 


