using Microsoft.VisualBasic.Logging;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BibleCode
{
    public partial class BibleCode : Form
    {
        public BibleCode()
        {
            InitializeComponent();
            richTextBoxHebrew.LoadFile("Moses\\Numbers.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("Moses\\NumbersConcise.rtf", RichTextBoxStreamType.RichText);
            txtSearchFromVerse.Text = "Num 1:1";
            txtXthCharacter.Text = 3.ToString();
            txtSearchDistance.Text = 50.ToString();
            txtNumberofCharacters.Text = 4.ToString();

            List<Item> items =
            [
                new Item() { Text = "Alef", Value = '\x05D0' },
                new Item() { Text = "Bet", Value = '\x05D1' },
                new Item() { Text = "Gimel", Value = '\x05D2' },
                new Item() { Text = "Dalet", Value = '\x05D3' },
                new Item() { Text = "He", Value = '\x05D4' },
                new Item() { Text = "Vav", Value = '\x05D5' },
                new Item() { Text = "Zayin", Value = '\x05D6' },
                new Item() { Text = "Het", Value = '\x05D7' },
                new Item() { Text = "Tet", Value = '\x05D8' },
                new Item() { Text = "Yod", Value = '\x05D9' },
                new Item() { Text = "Final Kaf", Value = '\x05DA' },
                new Item() { Text = "Kaf", Value = '\x05DB' },
                new Item() { Text = "Lamed", Value = '\x05DC' },
                new Item() { Text = "Final Mem", Value = '\x05DD' },
                new Item() { Text = "Mem", Value = '\x05DE' },
                new Item() { Text = "Final Nun", Value = '\x05DF' },
                new Item() { Text = "Nun", Value = '\x05E0' },
                new Item() { Text = "Samekh", Value = '\x05E1' },
                new Item() { Text = "Ayin", Value = '\x05E2' },
                new Item() { Text = "Final Pe", Value = '\x05E3' },
                new Item() { Text = "Pe", Value = '\x05E4' },
                new Item() { Text = "Final Tsadi", Value = '\x05E5' },
                new Item() { Text = "Tsadi", Value = '\x05E6' },
                new Item() { Text = "Qof", Value = '\x05E7' },
                new Item() { Text = "Resh", Value = '\x05E8' },
                new Item() { Text = "Sjin", Value = '\x05E9' },
                new Item() { Text = "Tav", Value = '\x05EA' }
            ];

            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedItem = null;
            comboBox1.SelectedIndex = 4;

        }

        public class Item
        {
            public Item() { Text = "Tav"; Value = '\x05EA'; }

            public char Value { set; get; }
            public string Text { set; get; }
        }
        private void Genesis_Click(object sender, EventArgs e)
        {
            richTextBoxHebrew.LoadFile("Moses\\Genesis.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("Moses\\GenesisConcise.rtf", RichTextBoxStreamType.RichText);
        }

        private void Exodus_Click(object sender, EventArgs e)
        {
            richTextBoxHebrew.LoadFile("Moses\\Exodus.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("Moses\\ExodusConcise.rtf", RichTextBoxStreamType.RichText);
        }

        private void Leviticus_Click(object sender, EventArgs e)
        {
            richTextBoxHebrew.LoadFile("Moses\\Leviticus.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("Moses\\LeviticusConcise.rtf", RichTextBoxStreamType.RichText);
        }

        private void Numbers_Click(object sender, EventArgs e)
        {
            richTextBoxHebrew.LoadFile("Moses\\Numbers.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("Moses\\NumbersConcise.rtf", RichTextBoxStreamType.RichText);
        }

        private void Deuteronomy_Click(object sender, EventArgs e)
        {
            richTextBoxHebrew.LoadFile("Moses\\Deuteronomy.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("Moses\\DeuteronomyConcise.rtf", RichTextBoxStreamType.RichText);
        }


        private void Thora_Click(object sender, EventArgs e)
        {
            richTextBoxHebrew.LoadFile("Moses\\Thora.rtf", RichTextBoxStreamType.RichText);
            richTextBoxHebrewConcise.LoadFile("Moses\\ThoraConcise.rtf", RichTextBoxStreamType.RichText);

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
            richTextBox2.Text = tohracounter.ToString() + " number of tavs and " + tavcounter.ToString() + " number of Tohras";
        }
        private void BibleSearch(string searchfromverse, char searchforcharacter, int xthcharacter, int searchdistance, int numberofcharacters)
        {
            int consizesize = (int)(searchdistance * 8) + 28;

            richTextBoxHebrewConcise.Size = new System.Drawing.Size(consizesize, 176);
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
            File.WriteAllText("c:\\intel\\text.rft", hebrewconsise);

            int startpoint;
            int textpointer = 0;
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
                // https://en.wikipedia.org/wiki/Unicode_and_HTML_for_the_Hebrew_alphabet
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
                            textpointer = i + 1;
                            break;
                        }
                    }
                    if (thetext[i] < '\x05D0')
                    {
                        nothebrewcharacters++;
                    }
                }
                if (textpointer == 0)
                    richTextBox2.Text = "This search combination cannot find the " + xthcharacter + " of " + searchforcharacter + " searching from " + searchfromverse;
            }
            else
            {
                richTextBox2.Text = "Verse " + searchfromverse + " not found in text.";
            }
            if (textpointer != 0)
            {
                int endofreading;
                endofreading = thetext.Length;

                for (int textcounter = textpointer; textcounter < endofreading; textcounter++)
                {
                    if (thetext[textcounter] > '\x05CF')
                    {
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
                    if (thetext[textcounter] < '\x05D0')
                    {
                        nothebrewcharacters++;
                    }
                    if (solution.Length > (numberofcharacters - 1))
                    {
                        break;
                    }
                }
                richTextBox2.Text = solution;
            }
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
            bool valuesOK = true;
            Item hebrewletter = new();
            if (comboBox1.SelectedItem != null)
            {
                hebrewletter = (Item)comboBox1.SelectedItem;
            }
            bool succes = int.TryParse(txtXthCharacter.Text, out int xthcharacter);
            if (!succes)
            {
                richTextBox2.Text = "Xth Character field is not numeric";
                valuesOK = false;
            }
            if (xthcharacter < 1)
            {
                richTextBox2.Text = "Xth Character field cannot be 0 or negative";
                valuesOK = false;
            }
            succes = int.TryParse(txtSearchDistance.Text, out int searchdistance);
            if (!succes)
            {
                richTextBox2.Text = "Search distance is not numberic";
                valuesOK = false;
            }
            if (searchdistance < 1)
            {
                richTextBox2.Text = "Search distance cannot be 0 or negative";
                valuesOK = false;
            }

            succes = int.TryParse(txtNumberofCharacters.Text, out int numberOfCharacters);
            if (!succes)
            {
                richTextBox2.Text = "Number of characters is not numeric";
                valuesOK = false;
            }
            if (numberOfCharacters < 1)
            {
                richTextBox2.Text = "Number Of Characters cannot be 0 or negative";
                valuesOK = false;
            }
            if (valuesOK)
                BibleSearch(txtSearchFromVerse.Text, hebrewletter.Value, xthcharacter, searchdistance, numberOfCharacters);
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
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
