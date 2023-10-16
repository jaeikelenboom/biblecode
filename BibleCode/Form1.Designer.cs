namespace BibleCode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBoxHebrew = new RichTextBox();
            richTextBox2 = new RichTextBox();
            btnFirstTav = new Button();
            richTextBoxDebug = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            richTextBoxHebrewConcise = new RichTextBox();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            txtSearchFromVerse = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSearchChar = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSearchDirection = new TextBox();
            txtSearchDistance = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // richTextBoxHebrew
            // 
            richTextBoxHebrew.Font = new Font("Dubai", 17.95F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxHebrew.Location = new Point(23, 90);
            richTextBoxHebrew.Name = "richTextBoxHebrew";
            richTextBoxHebrew.RightToLeft = RightToLeft.Yes;
            richTextBoxHebrew.Size = new Size(457, 202);
            richTextBoxHebrew.TabIndex = 3;
            richTextBoxHebrew.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(23, 489);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.RightToLeft = RightToLeft.Yes;
            richTextBox2.Size = new Size(457, 158);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // btnFirstTav
            // 
            btnFirstTav.Location = new Point(569, 90);
            btnFirstTav.Name = "btnFirstTav";
            btnFirstTav.Size = new Size(189, 23);
            btnFirstTav.TabIndex = 5;
            btnFirstTav.Text = "First Tav and next 50 chars";
            btnFirstTav.UseVisualStyleBackColor = true;
            btnFirstTav.Click += Firsttavandfifty_Click;
            // 
            // richTextBoxDebug
            // 
            richTextBoxDebug.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxDebug.Location = new Point(546, 412);
            richTextBoxDebug.Name = "richTextBoxDebug";
            richTextBoxDebug.RightToLeft = RightToLeft.Yes;
            richTextBoxDebug.Size = new Size(242, 146);
            richTextBoxDebug.TabIndex = 6;
            richTextBoxDebug.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(23, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Genesis";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Genesis_Click;
            // 
            // button2
            // 
            button2.Location = new Point(125, 28);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Exodus";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Exodus_Click;
            // 
            // button3
            // 
            button3.Location = new Point(248, 28);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Leviticus";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Leviticus_Click;
            // 
            // button4
            // 
            button4.Location = new Point(373, 28);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "Numbers";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Numbers_Click;
            // 
            // button5
            // 
            button5.Location = new Point(482, 28);
            button5.Name = "button5";
            button5.Size = new Size(105, 23);
            button5.TabIndex = 11;
            button5.Text = "Deuternomy";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Deuteronomy_Click;
            // 
            // button6
            // 
            button6.Location = new Point(844, 269);
            button6.Name = "button6";
            button6.Size = new Size(163, 23);
            button6.TabIndex = 12;
            button6.Text = "Number of tavs";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Numberoftavs_Click;
            // 
            // button7
            // 
            button7.Location = new Point(844, 227);
            button7.Name = "button7";
            button7.Size = new Size(163, 23);
            button7.TabIndex = 13;
            button7.Text = "Number of hebrew characters";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // richTextBoxHebrewConcise
            // 
            richTextBoxHebrewConcise.Font = new Font("Dubai", 20F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxHebrewConcise.Location = new Point(23, 332);
            richTextBoxHebrewConcise.Name = "richTextBoxHebrewConcise";
            richTextBoxHebrewConcise.RightToLeft = RightToLeft.Yes;
            richTextBoxHebrewConcise.Size = new Size(425, 96);
            richTextBoxHebrewConcise.TabIndex = 14;
            richTextBoxHebrewConcise.Text = "";
            // 
            // button8
            // 
            button8.Location = new Point(893, 144);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 15;
            button8.Text = "AllTavs";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Alltavs_Click;
            // 
            // button9
            // 
            button9.Location = new Point(844, 306);
            button9.Name = "button9";
            button9.Size = new Size(163, 23);
            button9.TabIndex = 16;
            button9.Text = "Number of vavs";
            button9.UseVisualStyleBackColor = true;
            button9.Click += numberofvavs_Click;
            // 
            // button10
            // 
            button10.Location = new Point(844, 349);
            button10.Name = "button10";
            button10.Size = new Size(163, 23);
            button10.TabIndex = 17;
            button10.Text = "Number of Reesh";
            button10.UseVisualStyleBackColor = true;
            button10.Click += numberofreesh_Click;
            // 
            // button11
            // 
            button11.Location = new Point(844, 391);
            button11.Name = "button11";
            button11.Size = new Size(163, 23);
            button11.TabIndex = 18;
            button11.Text = "Number of He";
            button11.UseVisualStyleBackColor = true;
            button11.Click += numberofhe_Click;
            // 
            // button12
            // 
            button12.Location = new Point(580, 204);
            button12.Name = "button12";
            button12.Size = new Size(178, 23);
            button12.TabIndex = 19;
            button12.Text = "FirstHeandEarlier50";
            button12.UseVisualStyleBackColor = true;
            button12.Click += FirstHeandEarlier50_Click;
            // 
            // button13
            // 
            button13.Location = new Point(580, 144);
            button13.Name = "button13";
            button13.Size = new Size(178, 23);
            button13.TabIndex = 20;
            button13.Text = "JahWeh";
            button13.UseVisualStyleBackColor = true;
            button13.Click += JahWeh_Click;
            // 
            // txtSearchFromVerse
            // 
            txtSearchFromVerse.Location = new Point(652, 42);
            txtSearchFromVerse.Name = "txtSearchFromVerse";
            txtSearchFromVerse.Size = new Size(100, 23);
            txtSearchFromVerse.TabIndex = 21;
            txtSearchFromVerse.TextChanged += searchfromverse_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(652, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 22;
            label1.Text = "SearchFromVerse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(793, 14);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 23;
            label2.Text = "SearchChar";
            // 
            // txtSearchChar
            // 
            txtSearchChar.Location = new Point(797, 45);
            txtSearchChar.Name = "txtSearchChar";
            txtSearchChar.Size = new Size(72, 23);
            txtSearchChar.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(899, 19);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 25;
            label3.Text = "SearchDirection";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1033, 21);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 26;
            label4.Text = "SearchDistance";
            // 
            // txtSearchDirection
            // 
            txtSearchDirection.Location = new Point(909, 46);
            txtSearchDirection.Name = "txtSearchDirection";
            txtSearchDirection.Size = new Size(100, 23);
            txtSearchDirection.TabIndex = 27;
            // 
            // txtSearchDistance
            // 
            txtSearchDistance.Location = new Point(1043, 45);
            txtSearchDistance.Name = "txtSearchDistance";
            txtSearchDistance.Size = new Size(100, 23);
            txtSearchDistance.TabIndex = 28;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(871, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "btnSearch";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 706);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchDistance);
            Controls.Add(txtSearchDirection);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSearchChar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearchFromVerse);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(richTextBoxHebrewConcise);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBoxDebug);
            Controls.Add(btnFirstTav);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBoxHebrew);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void FirstHeandnext50_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private RichTextBox richTextBoxHebrew;
        private RichTextBox richTextBox2;
        private Button btnFirstTav;
        private RichTextBox richTextBoxDebug;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private RichTextBox richTextBoxHebrewConcise;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private TextBox txtSearchFromVerse;
        private Label label1;
        private Label label2;
        private TextBox txtSearchChar;
        private Label label3;
        private Label label4;
        private TextBox txtSearchDirection;
        private TextBox txtSearchDistance;
        private Button btnSearch;
    }
}