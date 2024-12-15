namespace OnlineBookStore_AppsDev
{
    partial class WishList
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
            listBox1 = new ListBox();
            groupBoxWishlist = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            buttonBack = new Button();
            buttonNext = new Button();
            groupBoxWishlist.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(37, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(697, 300);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBoxWishlist
            // 
            groupBoxWishlist.Controls.Add(listBox1);
            groupBoxWishlist.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxWishlist.Location = new Point(37, 21);
            groupBoxWishlist.Name = "groupBoxWishlist";
            groupBoxWishlist.Size = new Size(838, 462);
            groupBoxWishlist.TabIndex = 1;
            groupBoxWishlist.TabStop = false;
            groupBoxWishlist.Text = "Wishlist";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(537, 415);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(677, 413);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 422);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 7;
            label2.Text = "Delete  choice";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(665, 498);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(781, 498);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(94, 29);
            buttonNext.TabIndex = 5;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            // 
            // WishList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 549);
            Controls.Add(buttonNext);
            Controls.Add(buttonBack);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(groupBoxWishlist);
            Name = "WishList";
            Text = "WishList";
            groupBoxWishlist.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private GroupBox groupBoxWishlist;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Button buttonBack;
        private Button buttonNext;
    }
}