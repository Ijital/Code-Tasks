using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regex_Tasks
{
    public partial class Form1 : Form
    {
        // Matches any text that contains the patter dog. E.g dog, gdog, Iwantdog, Iseedogeating
        // it doest matters where in the text 'dog' occurs
        const string pat0 = "dog";

        // Matches any text that contains the pattern 'dog' However the text must begin with
        // 'd'. The carrot sign ^ means that Regex will first look for a character match on the first 
        // Charaters in the text and the first character in the pattern. Example matches: 'dogfood',  
        // it doest matters where in the text 'dog' occurs
        const string pat13 = "^dog";

        // Matches any text that contains the pattern 'dog' However the text must end with
        // 'g'. The dollar sign $ means that Regex will first look for a character match on the first 
        // Charaters in the text and the first character in the pattern. Example matches: 'foodfordog',  
        // it doest matters where in the text 'dog' occurs
        const string pat14 = "dog$";

        // a string that contains one character and the character in between a and d (lower casing)
        const string pat1 = "^[a-d]$";

        // a string that contains one character and the character in between a and d (Lower or Upper casing)
        const string pat2 = "^[a-dA-D]$";

        // a string that contains min 2 characters max 3 characters and the characters in between a and d (Lower or Upper casing)
        const string pat3 = "^[a-dA-D]{2,3}$";


        // a string that contains min 2 characters and no max characters and the characters in between a and d (Lower or Upper casing)
        const string pat4 = "^[a-dA-D]{2,}$";

        // a string that beging with M and contains min 2 characters and no max characters and the characters in between a and d (Lower or Upper casing)
        const string pat5 = "^M[a-dA-D]{2,}$";

        // a string that begins with M or N and contains min 2 characters and no max characters and the characters in between a and d (Lower or Upper casing)
        const string pat6 = "^(M|N)[a-dA-D]{2,}$";


        // a string that begins with 3 digists, each digit with the range 3-7. Followins an alphanumerica characters containing min 2 characters and no max characters and the characters in between a and d (Lower or Upper casing)
        const string pat7 = "^[3-7]{3}[a-dA-D]{2,}$";

        // a string that begins with 3 digists, each digit with the range 3-7. Followins an alphanumerica characters containing min 2 characters and no max characters and the characters in between a and d (Lower or Upper casing)
        const string pat8 = "^[a-]{2}$";

        public Form1()
        {
            InitializeComponent();
        }

        private void MatchBTN_Click(object sender, EventArgs e)
        {
           MatchCollection matches = Regex.Matches(TestTXT.Text, PatternTXT.Text);


            Regex r = new Regex(PatternTXT.Text);
            MessageBox.Show($"Does Test Text: {TestTXT.Text} Match Pattern...{r.IsMatch(TestTXT.Text)}");
        }

    }
}
