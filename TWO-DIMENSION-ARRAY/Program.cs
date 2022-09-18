
using System.Diagnostics;
using System;

namespace TWO_DIMENSION_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ddd = Exponential(10, 3);

            PrintFirstNaturalss(20);

            //var sena = GetSum(5);
             var dese = GetFiba(5);

            //Declaring a two dimention array also known as Matrix
            // This defines a an array with 2 rows and 3 columns
            int[,] myArray = new int[5,4];

            int sss = myArray.GetUpperBound(0);
            int sxx = myArray.GetUpperBound(1);

            for (int i = 0; i <5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myArray[i,j]= i+j;
                }
            }

         //   Console.WriteLine(myArray.Length);
            Console.Read(  ); 

        }

        private static int GetFiba(int n)
        {
            if (n <= 1) 
            {
                return 1;
            }

            return GetFiba(n - 1) + GetFiba(n - 2);
        }

        static void PrintFirstNaturals(int num, int printNum= 1)
        {
            if(printNum>num)
            {
                return;

            }
            Console.Write(printNum+" ");

            PrintFirstNaturals(num, ++printNum);
        }

        static void PrintFirstNaturalss(int num)
        {
            if (num < 1)
            {
                return;

            }
            Console.Write(num + " ");

            PrintFirstNaturalss(--num);
        }


        static int Exponential(int num, int power, int result = 1)
        {
            if (power < 1)
            {
                return result;
            }
         
            return Exponential(num, --power, result*num);
        }


    }
}
