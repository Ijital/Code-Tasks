MAP

• A Map is an abstract data structure (ADT) • it stores key-value (k,v) pairs.
• there cannot be duplicate keys. • Maps are useful in situations where a key 
can be viewed as a unique identifier for the object.
• the key is used to decide where to store the object in the structure.

C# implementation of Map is the Dictionary and HashTable. Dictionary is preferred
because it is generic and there is no need for boxing and unboxing as required 
in HashTable as HashTable stores key values as object and not specific types

Dictionary combines the advantages of LinkedList and Arrays as follows;

Dictionary offer time cost free insertion and deletion which are expnsive 
in Arrays. An Advantage the LinkedList has

Dictionay offers super fast look up using keys just like Arrays use indexes. 
This operation is costly in LinkedList as the entire LinkedList can be traveresed
in worse case scenario

The Dictionary does not index items hence you cannot access elements by indexes
but you can travers the dictionary using forEach loop. 

The beauty of Dictionary is that you dont have to loop the entire collection
to find an item, you simple try to acess the key or value of the like an object property

In a Dictionary, keys are the indexes an they are unique and there is no concept of insertion

List Look up is highly efficient because a list creates mapping from keys to value and 
when searching for a value, it doesnt step over every item untill the target item is discovered
Its simply gets the value. 
