using System.Collections.Generic;
using System;
using System.Linq;

namespace Code_Test_Framework
{
    public static class Test_Stack
    {

        public static void GetSolution()
        {
            LinkedList<int> lists = new LinkedList<int>();
            lists.AddFirst(1);
            lists.AddLast(2);

            Console.WriteLine(lists.Last.Previous.Value);


            Queue<char> strQ = new Queue<char>();
            strQ.Enqueue('H');
            strQ.Enqueue('e');
            strQ.Enqueue('l');
            strQ.Enqueue('l');
            strQ.Enqueue('0');

            var Appl= strQ.Peek();
            var sese = strQ.ToList();

           Console.ReadLine();


        }
    }
}
