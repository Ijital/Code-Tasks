

using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;

namespace Code_Test_Framework
{
    // Regrex typicallly uses patterns to get values that match the pattern
    // To define a pattern we typically start the pattern with the Carrot sign and with the Dollar sign i.e   ^.....$
    // The patterns itself will then go in betweeen the two characters. 
    




    public static class Test_Regrex
    {
        static string nums = "1011000110101";
        public static void GetMatches()
        {

            //A string that contains only characters between a and e will match this pattern 
            string pattern1 = "^[a-e]$";
           
        }
    }
}
