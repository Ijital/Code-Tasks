   
LINKEDLIST

A linked list is a data strucure where each data item in the collection is first encapspulatted as a property inside of the 'LinkedListNode' object before 
being added to the collection. Each LinkedListNode object contains the data itself as a property but also contains a porperty called Next 
which is the memory location address reserved for the next item to be added afters it. This way, every item in the collection
'Knows' about the next item added to the collection. 
LinkedList Items are indexed like arrays according to the position they added but their memory locations are random and not contigious
in a contigious block like arrays so when a new item in inserted in the middle of the array, the eniter list dosent have to be 
itereated to adjust indexe, the item before the new item is made to point its next to it and the new item is made to point its
next property to the one after and the remainded of the linked list remains untouched. This is why insertions in LinkedList 
have a time complexity of O(1)

COMPARISON: Array/List Vs LinkedList

Arrays and Lists are faster than LinkedList for accessing data as the processer can simply jump to the index position whereas
the linkedList would have to traverse the list from the begining untill it finds the indext it it looking for. On the other 
hand the Array and List are slower at removing or inserting elements in the middle of the collection. Arrays and List use 
indexes when making entries and any deletion or addition in the middle would involve some operagion to shift all the affected
items to newer positions. LinkedList does care about postioning of items, the items can be anywhere in memory. 
