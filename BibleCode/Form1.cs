using Microsoft.VisualBasic.Logging;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace BibleCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // public char searchtext = '\x05EA';
            richTextBoxHebrew.LoadFile("Genesis.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("GenesisConcise.rtf", RichTextBoxStreamType.RichText);
            txtSearchFromVerse.Text = "Num 1:1";
            txtSearchChar.Text = '\x05D4'.ToString();
            txtXthCharacter.Text = 1.ToString();
            txtSearchDistance.Text = 50.ToString();
        }


        private void Firsttavandfifty_Click(object sender, EventArgs e)
        {
            txtSearchFromVerse.Text = "Gen 1:1";
            txtSearchChar.Text = '\x05EA'.ToString();
            txtXthCharacter.Text = 1.ToString();
            txtSearchDistance.Text = 50.ToString();
            BibleSearch("Gen 1:1", '\x05EA', 1, 50);
        }


        private void JahWeh_Click(object sender, EventArgs e)
        {
            BibleSearch("Lev 1:1", '\x05D9', 1, 8);
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

        private void BibleSearch(string searchfromverse, char searchforcharacter, int xthcharacter, int searchdistance)
        {
            string thetext = richTextBoxHebrew.Text;
            string solution = "";
            string hebrewconsise = "";

            int countertosearchdistance = 0;
            int nothebrewcharacters = 0;
            for (int i = 0; i < thetext.Length; i++)
            {
                if (thetext[i] > '\x05CF')
                {
                    hebrewconsise += thetext[i];
                }
            }
            // richTextBoxHebrewConcise.Text = hebrewconsise;
            File.WriteAllText("c:\\intel\\text.rft", hebrewconsise);

            int startpoint;
            int fred = 0;
            // Find the start bible verse
            if (thetext.Contains(searchfromverse))
            {
                startpoint = thetext.IndexOf(searchfromverse);
                richTextBoxHebrew.Select(startpoint, 5);
                richTextBoxHebrew.SelectionColor = Color.DarkGreen;
                for (int textcounter = 0; textcounter < startpoint; textcounter++)
                {
                    if (thetext[textcounter] < '\x05D0')
                    {
                        nothebrewcharacters++;

                    }
                }
                // Find the character to search for in the text
                int xthcharacterfound = 0;
                for (int i = startpoint; i < thetext.Length; i++)
                {
                    if (thetext[i] == searchforcharacter)
                    {
                        xthcharacterfound++;
                        if (xthcharacterfound == xthcharacter)
                        {
                            solution += thetext[i];
                            richTextBoxHebrew.Select(i, 1);
                            richTextBoxHebrew.SelectionColor = Color.Red;
                            richTextBoxHebrewConcise.Select(i - nothebrewcharacters, 1);
                            richTextBoxHebrewConcise.SelectionColor = Color.Red;
                            fred = i + 1;
                            break;
                        }
                    }
                    if (thetext[i] < '\x05D0')
                    {
                        nothebrewcharacters++;
                    }
                }
                // https://en.wikipedia.org/wiki/Unicode_and_HTML_for_the_Hebrew_alphabet


            }
            else
            {
                richTextBoxDebug.Text = "verse not found";
            }
            int endofreading;
            {
                endofreading = thetext.Length;

                for (int textcounter = fred; textcounter < endofreading; textcounter++)
                {


                    if (thetext[textcounter] > '\x05CF')
                    {
                        richTextBoxDebug.Text = thetext[textcounter] + " " + thetext[textcounter];
                        countertosearchdistance++;

                        if (countertosearchdistance == searchdistance)
                        {
                            solution += thetext[textcounter];
                            countertosearchdistance = 0;
                            richTextBoxHebrew.Select(textcounter, 1);
                            richTextBoxHebrew.SelectionColor = Color.Red;
                            richTextBoxHebrewConcise.Select(textcounter - nothebrewcharacters, 1);
                            richTextBoxHebrewConcise.SelectionColor = Color.Red;

                        }

                    }
                    // https://en.wikipedia.org/wiki/Unicode_and_HTML_for_the_Hebrew_alphabet
                    //if (thetext[textcounter] == searchforcharacter && firstcharacter == false)
                    //{
                    //    firstcharacter = true;
                    //    solution += thetext[textcounter];
                    //    richTextBoxHebrew.Select(textcounter, 1);
                    //    richTextBoxHebrew.SelectionColor = Color.Red;
                    //    richTextBoxHebrewConcise.Select(textcounter - nothebrewcharacters, 1);
                    //    richTextBoxHebrewConcise.SelectionColor = Color.Red;


                    //}


                    if (thetext[textcounter] < '\x05D0')
                    {
                        nothebrewcharacters++;

                    }
                    if (solution.Length > 3)
                    {
                        break;
                    }
                }


            }

            richTextBox2.Text = solution;

        }


        private void CountCharacter(char chartocount)
        {
            string thetext = richTextBoxHebrew.Text;
            int counter = 0;

            for (int i = 0; i < thetext.Length; i++)
            {
                // https://en.wikipedia.org/wiki/Unicode_and_HTML_for_the_Hebrew_alphabet
                if (thetext[i] == chartocount)
                {
                    counter++;
                    richTextBoxHebrew.Select(i, 1);
                    richTextBoxHebrew.SelectionColor = Color.Red;
                }
            }

            richTextBox2.Text = counter.ToString();
        }

        private void NumberOfVavs_Click(object sender, EventArgs e)
        {
            CountCharacter('\x05D5');
        }

        private void NumberOfReesh_Click(object sender, EventArgs e)
        {
            CountCharacter('\x05E8');
        }

        private void NumberOfHe_Click(object sender, EventArgs e)
        {
            CountCharacter('\x05D4');
        }

        private void NumberOfTavs_Click(object sender, EventArgs e)
        {
            CountCharacter('\x05EA');
        }

        private void Search_Click(object sender, EventArgs e)
        {
            BibleSearch(txtSearchFromVerse.Text, txtSearchChar.Text[0], int.Parse(txtXthCharacter.Text), int.Parse(txtSearchDistance.Text));
        }

        private void NumberOfChars_Click(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
