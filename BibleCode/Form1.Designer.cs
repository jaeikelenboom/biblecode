namespace BibleCode
{
    partial class BibleCode
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
            components = new System.ComponentModel.Container();
            richTextBoxHebrew = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnNumberOfChars = new Button();
            richTextBoxHebrewConcise = new RichTextBox();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            txtSearchFromVerse = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtSearchDistance = new TextBox();
            btnSearch = new Button();
            label3 = new Label();
            txtXthCharacter = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            menuStrip1 = new MenuStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip2 = new MenuStrip();
            comboBox1 = new ComboBox();
            Thora = new Button();
            SuspendLayout();
            // 
            // richTextBoxHebrew
            // 
            richTextBoxHebrew.Font = new Font("Dubai", 80F, FontStyle.Regular, GraphicsUnit.Point);
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
            richTextBox2.Location = new Point(23, 638);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.RightToLeft = RightToLeft.Yes;
            richTextBox2.Size = new Size(457, 158);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(23, 61);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Genesis";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Genesis_Click;
            // 
            // button2
            // 
            button2.Location = new Point(104, 61);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Exodus";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Exodus_Click;
            // 
            // button3
            // 
            button3.Location = new Point(185, 61);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Leviticus";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Leviticus_Click;
            // 
            // button4
            // 
            button4.Location = new Point(266, 61);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "Numbers";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Numbers_Click;
            // 
            // button5
            // 
            button5.Location = new Point(347, 61);
            button5.Name = "button5";
            button5.Size = new Size(105, 23);
            button5.TabIndex = 11;
            button5.Text = "Deuternomy";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Deuteronomy_Click;
            // 
            // button6
            // 
            button6.Location = new Point(810, 590);
            button6.Name = "button6";
            button6.Size = new Size(163, 23);
            button6.TabIndex = 12;
            button6.Text = "Number of tavs";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberOfTavs_Click;
            // 
            // btnNumberOfChars
            // 
            btnNumberOfChars.Location = new Point(810, 540);
            btnNumberOfChars.Name = "btnNumberOfChars";
            btnNumberOfChars.Size = new Size(273, 23);
            btnNumberOfChars.TabIndex = 13;
            btnNumberOfChars.Text = "Number of hebrew characters";
            btnNumberOfChars.UseVisualStyleBackColor = true;
            btnNumberOfChars.Click += NumberOfChars_Click;
            // 
            // richTextBoxHebrewConcise
            // 
            richTextBoxHebrewConcise.Font = new Font("Dubai", 30F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxHebrewConcise.Location = new Point(23, 349);
            richTextBoxHebrewConcise.Name = "richTextBoxHebrewConcise";
            richTextBoxHebrewConcise.RightToLeft = RightToLeft.Yes;
            richTextBoxHebrewConcise.Size = new Size(425, 176);
            richTextBoxHebrewConcise.TabIndex = 14;
            richTextBoxHebrewConcise.Text = "";
            // 
            // button8
            // 
            button8.Location = new Point(549, 638);
            button8.Name = "button8";
            button8.Size = new Size(166, 23);
            button8.TabIndex = 15;
            button8.Text = "Tavs and Thora counter";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Alltavs_Click;
            // 
            // button9
            // 
            button9.Location = new Point(810, 649);
            button9.Name = "button9";
            button9.Size = new Size(163, 23);
            button9.TabIndex = 16;
            button9.Text = "Number of vavs";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberOfVavs_Click;
            // 
            // button10
            // 
            button10.Location = new Point(810, 707);
            button10.Name = "button10";
            button10.Size = new Size(163, 23);
            button10.TabIndex = 17;
            button10.Text = "Number of Reesh";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumberOfReesh_Click;
            // 
            // button11
            // 
            button11.Location = new Point(810, 773);
            button11.Name = "button11";
            button11.Size = new Size(163, 23);
            button11.TabIndex = 18;
            button11.Text = "Number of He";
            button11.UseVisualStyleBackColor = true;
            button11.Click += NumberOfHe_Click;
            // 
            // txtSearchFromVerse
            // 
            txtSearchFromVerse.Location = new Point(553, 90);
            txtSearchFromVerse.Name = "txtSearchFromVerse";
            txtSearchFromVerse.Size = new Size(100, 23);
            txtSearchFromVerse.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(556, 65);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 22;
            label1.Text = "SearchFromVerse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(683, 65);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 23;
            label2.Text = "SearchChar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(950, 69);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 26;
            label4.Text = "SearchDistance";
            // 
            // txtSearchDistance
            // 
            txtSearchDistance.Location = new Point(950, 90);
            txtSearchDistance.Name = "txtSearchDistance";
            txtSearchDistance.Size = new Size(100, 23);
            txtSearchDistance.TabIndex = 28;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(553, 137);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += Search_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(824, 65);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 30;
            label3.Text = "Search xth character";
            // 
            // txtXthCharacter
            // 
            txtXthCharacter.Location = new Point(824, 90);
            txtXthCharacter.Name = "txtXthCharacter";
            txtXthCharacter.Size = new Size(100, 23);
            txtXthCharacter.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(553, 202);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 33;
            label6.Text = "Genesis: Gen 1:1 tav 1 50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(556, 229);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 34;
            label7.Text = "Exodus: Exo 1:1 tav 1 50";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(556, 258);
            label8.Name = "label8";
            label8.Size = new Size(136, 15);
            label8.TabIndex = 35;
            label8.Text = "Leviticus: Lev 1:1 yod 1 8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(556, 289);
            label9.Name = "label9";
            label9.Size = new Size(147, 15);
            label9.TabIndex = 36;
            label9.Text = "Numbers: Num 1:1 he 3 50";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(556, 322);
            label10.Name = "label10";
            label10.Size = new Size(159, 15);
            label10.TabIndex = 37;
            label10.Text = "Deuteronom: Deu 1:5 he 4 49";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(553, 172);
            label11.Name = "label11";
            label11.Size = new Size(355, 15);
            label11.TabIndex = 38;
            label11.Text = "https://www.answering-islam.org/Religions/Numerics/torah.html";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1168, 24);
            menuStrip1.TabIndex = 39;
            menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip2
            // 
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1168, 24);
            menuStrip2.TabIndex = 42;
            menuStrip2.Text = "menuStrip2";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(683, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 43;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // Thora
            // 
            Thora.Location = new Point(458, 61);
            Thora.Name = "Thora";
            Thora.Size = new Size(75, 23);
            Thora.TabIndex = 44;
            Thora.Text = "Thora";
            Thora.UseVisualStyleBackColor = true;
            Thora.Click += Thora_Click;
            // 
            // BibleCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 859);
            Controls.Add(Thora);
            Controls.Add(comboBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtXthCharacter);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchDistance);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearchFromVerse);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(richTextBoxHebrewConcise);
            Controls.Add(btnNumberOfChars);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBoxHebrew);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "BibleCode";
            Text = "Bible Code";
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnNumberOfChars;
        private RichTextBox richTextBoxHebrewConcise;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private TextBox txtSearchFromVerse;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtSearchDistance;
        private Button btnSearch;
        private Label label3;
        private TextBox txtXthCharacter;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip2;
        private ComboBox comboBox1;
        private Button Thora;
    }
}