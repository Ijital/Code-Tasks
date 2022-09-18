using System;
namespace CODE_TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawTriangl();

            Console.ReadLine();
        }

        private static void DrawTriangl()
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (i == 0 && j == 6)
                    {
                        Console.Write("*");
                        break;
                    }
                    else if (j == 6 - i || j == 6 + i)
                    {
                        Console.Write("*");
                    }
                    else if (i != 6)
                    {
                        Console.Write(" ");
                    }
                    else if (i == 6 && j < 7)
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
