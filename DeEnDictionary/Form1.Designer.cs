namespace DeEnDictionary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbGermanWord = new System.Windows.Forms.TextBox();
            this.tbEnglishWord = new System.Windows.Forms.TextBox();
            this.lBoxGermanWords = new System.Windows.Forms.ListBox();
            this.tbTranslationEnglish = new System.Windows.Forms.TextBox();
            this.btnExportToCsv = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbSpanishWord = new System.Windows.Forms.TextBox();
            this.tbTranslationSpanish = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatAppearance.BorderSize = 4;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(31, 105);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(704, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(31, 40);
            this.tbGermanWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(219, 31);
            this.tbGermanWord.TabIndex = 1;
            this.tbGermanWord.Text = "German";
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.Location = new System.Drawing.Point(284, 40);
            this.tbEnglishWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(219, 31);
            this.tbEnglishWord.TabIndex = 2;
            this.tbEnglishWord.Text = "English";
            // 
            // lBoxGermanWords
            // 
            this.lBoxGermanWords.FormattingEnabled = true;
            this.lBoxGermanWords.ItemHeight = 27;
            this.lBoxGermanWords.Location = new System.Drawing.Point(31, 300);
            this.lBoxGermanWords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lBoxGermanWords.Name = "lBoxGermanWords";
            this.lBoxGermanWords.ScrollAlwaysVisible = true;
            this.lBoxGermanWords.Size = new System.Drawing.Size(494, 328);
            this.lBoxGermanWords.TabIndex = 4;
            this.lBoxGermanWords.Tag = " ";
            this.lBoxGermanWords.SelectedIndexChanged += new System.EventHandler(this.lBoxGermanWords_SelectedIndexChanged);
            // 
            // tbTranslationEnglish
            // 
            this.tbTranslationEnglish.Location = new System.Drawing.Point(568, 313);
            this.tbTranslationEnglish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTranslationEnglish.Name = "tbTranslationEnglish";
            this.tbTranslationEnglish.Size = new System.Drawing.Size(167, 31);
            this.tbTranslationEnglish.TabIndex = 5;
            // 
            // btnExportToCsv
            // 
            this.btnExportToCsv.Location = new System.Drawing.Point(558, 465);
            this.btnExportToCsv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportToCsv.Name = "btnExportToCsv";
            this.btnExportToCsv.Size = new System.Drawing.Size(177, 42);
            this.btnExportToCsv.TabIndex = 6;
            this.btnExportToCsv.Text = "Export to CSV";
            this.btnExportToCsv.UseVisualStyleBackColor = true;
            this.btnExportToCsv.Click += new System.EventHandler(this.btnExportToCsv_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatAppearance.BorderSize = 4;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(31, 209);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(316, 40);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(31, 159);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(316, 31);
            this.tbSearch.TabIndex = 9;
            this.tbSearch.Text = "type german word";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(516, 159);
            this.tbFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(219, 31);
            this.tbFind.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Location = new System.Drawing.Point(558, 519);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 42);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete All";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbSpanishWord
            // 
            this.tbSpanishWord.Location = new System.Drawing.Point(516, 40);
            this.tbSpanishWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSpanishWord.Name = "tbSpanishWord";
            this.tbSpanishWord.Size = new System.Drawing.Size(219, 31);
            this.tbSpanishWord.TabIndex = 12;
            this.tbSpanishWord.Text = "Spanish";
            // 
            // tbTranslationSpanish
            // 
            this.tbTranslationSpanish.Location = new System.Drawing.Point(568, 387);
            this.tbTranslationSpanish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTranslationSpanish.Name = "tbTranslationSpanish";
            this.tbTranslationSpanish.Size = new System.Drawing.Size(167, 31);
            this.tbTranslationSpanish.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 218);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 31);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(769, 736);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbTranslationSpanish);
            this.Controls.Add(this.tbSpanishWord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExportToCsv);
            this.Controls.Add(this.tbTranslationEnglish);
            this.Controls.Add(this.lBoxGermanWords);
            this.Controls.Add(this.tbEnglishWord);
            this.Controls.Add(this.tbGermanWord);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbGermanWord;
        private System.Windows.Forms.TextBox tbEnglishWord;
        private System.Windows.Forms.TextBox tbTranslationEnglish;
        private System.Windows.Forms.Button btnExportToCsv;
        private System.Windows.Forms.ListBox lBoxGermanWords;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbSpanishWord;
        private System.Windows.Forms.TextBox tbTranslationSpanish;
        private System.Windows.Forms.TextBox textBox1;
    }
}

