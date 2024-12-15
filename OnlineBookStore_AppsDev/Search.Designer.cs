namespace OnlineBookStore_AppsDev
{
    partial class Search
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
            comboBoxAuthor = new ComboBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            comboBoxSort = new ComboBox();
            label6 = new Label();
            comboBoxChapterCount = new ComboBox();
            label5 = new Label();
            comboBoxYear = new ComboBox();
            label4 = new Label();
            dgvBooks = new DataGridView();
            btnSearch = new Button();
            comboBoxStatus = new ComboBox();
            comboBoxGenre = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // comboBoxAuthor
            // 
            comboBoxAuthor.FormattingEnabled = true;
            comboBoxAuthor.Location = new Point(79, 334);
            comboBoxAuthor.Name = "comboBoxAuthor";
            comboBoxAuthor.Size = new Size(151, 28);
            comboBoxAuthor.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 342);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 32;
            label1.Text = "Author";
            // 
            // button2
            // 
            button2.Location = new Point(680, 451);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 31;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(550, 451);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 30;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(79, 264);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(151, 28);
            comboBoxSort.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 272);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 28;
            label6.Text = "Sort";
            // 
            // comboBoxChapterCount
            // 
            comboBoxChapterCount.FormattingEnabled = true;
            comboBoxChapterCount.Location = new Point(122, 193);
            comboBoxChapterCount.Name = "comboBoxChapterCount";
            comboBoxChapterCount.Size = new Size(108, 28);
            comboBoxChapterCount.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 201);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 26;
            label5.Text = "Chapter Count";
            // 
            // comboBoxYear
            // 
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(79, 120);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(151, 28);
            comboBoxYear.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 123);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 24;
            label4.Text = "Year";
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(308, 26);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(496, 384);
            dgvBooks.TabIndex = 23;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 451);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(79, 37);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 21;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(79, -30);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(151, 28);
            comboBoxGenre.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 19;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, -22);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 18;
            label2.Text = "Genre";
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 556);
            Controls.Add(comboBoxAuthor);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxSort);
            Controls.Add(label6);
            Controls.Add(comboBoxChapterCount);
            Controls.Add(label5);
            Controls.Add(comboBoxYear);
            Controls.Add(label4);
            Controls.Add(dgvBooks);
            Controls.Add(btnSearch);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxGenre);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Search";
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAuthor;
        private Label label1;
        private Button button2;
        private Button button1;
        private ComboBox comboBoxSort;
        private Label label6;
        private ComboBox comboBoxChapterCount;
        private Label label5;
        private ComboBox comboBoxYear;
        private Label label4;
        private DataGridView dgvBooks;
        private Button btnSearch;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxGenre;
        private Label label3;
        private Label label2;
    }
}