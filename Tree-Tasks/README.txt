TREE
Tree is a data structure that is like the LinkedList where each data is first encaspulated in a TreeNode object before being
added to the collection. Unlike the LinkedList where each LinkedList Node has a pointer to whatever node is added next
In trees each TreeNode has more than one pointer and depending on some condition, a new node added to the collection
can be either pointed to by the Left or right of the treeNode.Hence  a tree is not a linear data structure since travesing a Tree 
will not go on a straight line but branched out. 


This is because in a tree, data is not 
collected/acessed in a linear fashion like structures like arrays but the structure has direction 
included to. 

BINARY SEARCH TREE (BST)

A Binary Search Tree is a data structure that collects and sorts items in a binary hierachial manner.
The purpose for such sorting is to allow for an efficient and fast insertion,removal, and lookup of items.
In A Binary search tree, as items are added to the Tree, they are sorted to either the right or the left of 
one of the existing items in the tree. Lets say we are collecting Peoples' records and we want
to sort them by age in a binary tree. To have a Binary Tree we have to have a way of comparing items
and designating one item greater than another. We could for example use poeples Age

Person1, Age = 20
Person2  Age = 17
Person3  Age = 55

As Person1 is the first addition to the Tree then any other subsequent additions will be added to the left or right of Person1 
depending on the Age. So Person2 will be added to the left of Person1 and Person3 will be added to the right of Person1

         Person1
           20
           /\
          /  \
         /    \
        17    55
    Person2  Person3

After Person3 is added, if we then added a Person4 Age = 34, Person4's age will be compared first with the 
Root Person in the Tree i.e Person1. As age 34 (Person4) is greater than age 20(Person1) Person4 will be directed
to the right of hand of Person1. And On the right, Age 34 of Person4 will be compared with age 55 of Person3. As this is
less then Person4 will be directed to the left of Person3.
        Person1
           20
           /\
          /  \
         /    \
        17    55
    Person2  Person3
                /
               /
              34
            Person4


Binary Search Tree Look up

Lookup on a binary search tree is performed by traversing the tree down from the root and by choosing, at each step, 
if we want to continue by going right or left. We repeat this process until we find our value or the current node doesn’t
have a right/left child.

The above example is a balanced Search Tree because items added to the Tree come randomly. ie some are greater and some 
are smaller and they are always added either to the right or to the left of thier parent. We can however have a situation
where the items being added to the collection continous come greater and they are therefore repeateyl being added to the 
the right of each parent effectively making the Tree linear, a linked list where there are no branches. 

Mutiple duplicates in a tree https://www.geeksforgeeks.org/how-to-handle-duplicates-in-binary-search-tree/