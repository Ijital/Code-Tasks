using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue_Stack_Tasks
{
    public class Program
    {
        // Stack and Queue implement IEnumerable hence you can call the Linq methods on a Stack and Queue
        static void Main(string[] args)
        {

            //Think of Pile of plates to be washed when you think of stack
            //Last come last serve

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            // Add a new item to the end of the stack
            myStack.Push(6);

            // Get the last item in stack without removing it from the stack
            var item = myStack.Peek();

            //Get the last item added to the stack and also remove it from the stack
             var item2 = myStack.Pop();

            // Check if the stack contains a given element
            bool has4 = myStack.Contains(4);

            // Returns the number of items in the stack
            var stackCount = myStack.Count;

            // Returns a new Stack with the specified element prependeted to the specified stack
            // The original stack is not chnaged i.e items can only be added at the top of a stack
            var newStack =  myStack.Prepend(0);

            // Converts queue and Stack to array
            var myStackList = myStack.ToArray();

            // iterating a Stack
            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }

            // This of Line in a Bank ATM when you think of Queue
            // The First come first Serve
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            //Convert Queue into Array
            var myQueList = myQueue.ToArray();

            // Gets the first item added to the Queue without removing it from the queue
            var queItem = myQueue.Peek();

            //Get the first item added to the Queue and also remove it from the Queue
            var queuItem = myQueue.Dequeue();

            // iterating a Queue
            while (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }

            Console.Read();

        }
    }
}
