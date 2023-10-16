using Microsoft.VisualBasic.Logging;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace BibleCode
{
    public partial class Form1 : Form
    {

        private string searchfromverse = "GEN 1:1";
        private char searchforcharacter = '\x05EA';
        private bool directionforward = true;
        private int searchdistance = 50;


        public Form1()
        {
            InitializeComponent();
            // public char searchtext = '\x05EA';
            richTextBoxHebrew.LoadFile("Genesis.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("GenesisConcise.rtf", RichTextBoxStreamType.RichText);
            txtSearchFromVerse.Text = searchfromverse;
            txtSearchChar.Text = searchforcharacter.ToString();
            txtSearchDirection.Text = directionforward.ToString();
            txtSearchDistance.Text = searchdistance.ToString();
        }


        private void Firsttavandfifty_Click(object sender, EventArgs e)
        {
            BibleSearch(this.searchfromverse, '\x05EA', true, 50);
        }


        private void JahWeh_Click(object sender, EventArgs e)
        {
            BibleSearch(this.searchfromverse, '\x05D9', true, 8);
        }

        private void FirstHeandEarlier50_Click(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
            string thetext = richTextBoxHebrew.Text;
            int counter = 0;

            for (int i = 0; i < thetext.Length; i++)
            {
                // https://en.wikipedia.org/wiki/Unicode_and_HTML_for_the_Hebrew_alphabet
                if (thetext[i] > '\x05CF')
                {
                    counter++;
                    richTextBoxHebrew.Select(i, 1);
                    richTextBoxHebrew.SelectionColor = Color.Red;
                }
            }

            richTextBox2.Text = counter.ToString();
        }


        private void Genesis_Click(object sender, EventArgs e)
        {
            richTextBoxHebrew.LoadFile("Genesis.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("GenesisConcise.rtf", RichTextBoxStreamType.RichText);
        }

        private void Exodus_Click(object sender, EventArgs e)
        {
            richTextBoxHebrew.LoadFile("Exodus.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("ExodusConcise.rtf", RichTextBoxStreamType.RichText);
        }

        private void Leviticus_Click(object sender, EventArgs e)
        {
            richTextBoxHebrew.LoadFile("Leviticus.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("LevConcise.rtf", RichTextBoxStreamType.RichText);
        }

        private void Numbers_Click(object sender, EventArgs e)
        {
            richTextBoxHebrew.LoadFile("Numbers.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("NumbersConcise.rtf", RichTextBoxStreamType.RichText);
        }


        private void Deuteronomy_Click(object sender, EventArgs e)
        {
            richTextBoxHebrew.LoadFile("Deuteronomy.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("DeuteronomyConcise.rtf", RichTextBoxStreamType.RichText);
        }


        private void Alltavs_Click(object sender, EventArgs e)
        {
            string thetext = richTextBoxHebrewConcise.Text;
            string solution = "";
            int tavcounter = 0;
            int tohracounter = 0;


            for (int i = 0; i < thetext.Length; i++)
            {
                // https://en.wikipedia.org/wiki/Unicode_and_HTML_for_the_Hebrew_alphabet
                if (thetext[i] == '\x05EA' && i + 150 < thetext.Length)
                {
                    tavcounter++;
                    Color colour = Color.Yellow;
                    if (thetext[i + 50] == '\x05D5')
                    {
                        colour = Color.Orange;
                        if (thetext[i + 100] == '\x05E8')
                        {
                            colour = Color.Magenta;
                            solution += tavcounter.ToString() + " " + thetext[i] + thetext[i + 50] + thetext[i + 100] + thetext[i + 150] + " ";
                            // richTextBox2.Text = solution + tohracounter.ToString();

                            if (thetext[i + 150] == '\x05D4')
                            {
                                colour = Color.Red;
                                tohracounter++;
                            }
                        }
                    }
                    richTextBoxHebrewConcise.Select(i, 1);
                    richTextBoxHebrewConcise.SelectionColor = colour;
                    richTextBoxHebrewConcise.Select(i + 50, 1);
                    richTextBoxHebrewConcise.SelectionColor = colour;
                    richTextBoxHebrewConcise.Select(i + 100, 1);
                    richTextBoxHebrewConcise.SelectionColor = colour;
                    richTextBoxHebrewConcise.Select(i + 150, 1);
                    richTextBoxHebrewConcise.SelectionColor = colour;
                }
            }
            richTextBox2.Text = solution + tohracounter.ToString();


        }

        private void Numberoftavs_Click(object sender, EventArgs e)
        {

            string thetext = richTextBoxHebrew.Text;
            int counter = 0;

            for (int i = 0; i < thetext.Length; i++)
            {
                // https://en.wikipedia.org/wiki/Unicode_and_HTML_for_the_Hebrew_alphabet
                if (thetext[i] == '\x05EA')
                {
                    counter++;
                    richTextBoxHebrew.Select(i, 1);
                    richTextBoxHebrew.SelectionColor = Color.Red;
                }
            }

            richTextBox2.Text = counter.ToString();
        }

        private void numberofvavs_Click(object sender, EventArgs e)
        {
            string thetext = richTextBoxHebrew.Text;
            int counter = 0;

            for (int i = 0; i < thetext.Length; i++)
            {
                // https://en.wikipedia.org/wiki/Unicode_and_HTML_for_the_Hebrew_alphabet
                if (thetext[i] == '\x05D5')
                {
                    counter++;
                    richTextBoxHebrew.Select(i, 1);
                    richTextBoxHebrew.SelectionColor = Color.Red;
                }
            }

            richTextBox2.Text = counter.ToString();
        }

        private void numberofreesh_Click(object sender, EventArgs e)
        {
            string thetext = richTextBoxHebrew.Text;
            int counter = 0;

            for (int i = 0; i < thetext.Length; i++)
            {
                // https://en.wikipedia.org/wiki/Unicode_and_HTML_for_the_Hebrew_alphabet
                if (thetext[i] == '\x05E8')
                {
                    counter++;
                    richTextBoxHebrew.Select(i, 1);
                    richTextBoxHebrew.SelectionColor = Color.Red;
                }
            }

            richTextBox2.Text = counter.ToString();
        }

        private void numberofhe_Click(object sender, EventArgs e)
        {
            string thetext = richTextBoxHebrew.Text;
            int counter = 0;

            for (int i = 0; i < thetext.Length; i++)
            {
                // https://en.wikipedia.org/wiki/Unicode_and_HTML_for_the_Hebrew_alphabet
                if (thetext[i] == '\x05D4')
                {
                    counter++;
                    richTextBoxHebrew.Select(i, 1);
                    richTextBoxHebrew.SelectionColor = Color.Red;
                }
            }

            richTextBox2.Text = counter.ToString();
        }

        private void searchfromverse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BibleSearch(this.searchfromverse, this.searchforcharacter, this.directionforward, this.searchdistance);
        }

        private void BibleSearch(string searchfromverse, char searchforcharacter, bool directionforward, int searchdistance)
        {
            string thetext = richTextBoxHebrew.Text;
            //searchtext = '\x05EA';
            string answer = "";
            string solution = "";
            string hebrewconsise = "";

            bool firsttavfound = false;
            int countertofifty = 0;
            int nothebrewcharacters = 0;
            string ii;
            for (int i = 0; i < thetext.Length; i++)
            {
                if (thetext[i] > '\x05CF')
                {
                    hebrewconsise += thetext[i];
                }
            }
            // richTextBoxHebrewConcise.Text = hebrewconsise;
            File.WriteAllText("c:\\intel\\text.rft", hebrewconsise);


            for (int i = 0; i < thetext.Length; i++)
            //for (int i = 0; i < hebrewconsise.Length; i++)
            {
                ii = thetext[i].ToString();
                answer += ((int)thetext[i]) + " ";


                if (firsttavfound == true && thetext[i] > '\x05CF')
                {
                    richTextBoxDebug.Text = thetext[i] + " " + thetext[i];
                    if (directionforward)
                    {
                        countertofifty++;
                    }
                    else
                    {
                        countertofifty--;
                    }

                    if (countertofifty == searchdistance)
                    {
                        solution += thetext[i];
                        countertofifty = 0;
                        richTextBoxHebrew.Select(i, 1);
                        richTextBoxHebrew.SelectionColor = Color.Red;
                        richTextBoxHebrewConcise.Select(i - nothebrewcharacters, 1);
                        richTextBoxHebrewConcise.SelectionColor = Color.Red;

                    }

                }
                // https://en.wikipedia.org/wiki/Unicode_and_HTML_for_the_Hebrew_alphabet
                if (thetext[i] == searchforcharacter && firsttavfound == false)
                {
                    firsttavfound = true;
                    solution += thetext[i];
                    richTextBoxHebrew.Select(i, 1);
                    richTextBoxHebrew.SelectionColor = Color.Red;
                    richTextBoxHebrewConcise.Select(i - nothebrewcharacters, 1);
                    richTextBoxHebrewConcise.SelectionColor = Color.Red;

                }
                if (thetext[i] < '\x05D0')
                {
                    nothebrewcharacters = nothebrewcharacters + 1;

                }
                if (solution.Length > 3)
                {
                    break;
                }
            }

            richTextBox2.Text = solution;

        }

    }
}
