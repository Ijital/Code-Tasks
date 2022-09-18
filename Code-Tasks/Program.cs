

int[] nums = { 1, 2, 3,4,5};
int[] nums2 = { 3,2 };


string[] names = { "Melvin", "Hannah", "Jonah", "Sena", "Yuana" };

List<string> ati = new List<string> { "mel", "Jona", "Yauna" };

//Fill an array with thesame value
int[] nums3 = new int[20];
Array.Fill(nums3, 1);


void DrawTriangl()
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

















