using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace My_Regrexs
{
    public partial class Form1 : Form
    {
        #region PATTERNS

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


        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void MatchBtn_Click(object sender, EventArgs e)
        {
            MatchCollection matches = Regex.Matches(TestText.Text, PatternTxt.Text);




            Regex r = new Regex(PatternTxt.Text);
            MessageBox.Show($"Does Test Text: {TestText.Text} Match Pattern...{r.IsMatch(TestText.Text)}");  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
