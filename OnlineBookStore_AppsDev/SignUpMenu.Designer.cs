namespace OnlineBookStore
{
    partial class SignUpMenu
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
            back3 = new Button();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            txt_Password2 = new TextBox();
            Submit = new Button();
            txt_Number = new TextBox();
            SuspendLayout();
            // 
            // back3
            // 
            back3.Location = new Point(101, 302);
            back3.Name = "back3";
            back3.Size = new Size(75, 23);
            back3.TabIndex = 0;
            back3.Text = "back";
            back3.UseVisualStyleBackColor = true;
            back3.Click += back3_Click;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(335, 87);
            txt_Username.Name = "txt_Username";
            txt_Username.PlaceholderText = "Username";
            txt_Username.Size = new Size(181, 23);
            txt_Username.TabIndex = 3;
            txt_Username.Tag = "";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(335, 116);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "Password";
            txt_Password.Size = new Size(181, 23);
            txt_Password.TabIndex = 4;
            txt_Password.Tag = "";
            // 
            // txt_Password2
            // 
            txt_Password2.Location = new Point(335, 145);
            txt_Password2.Name = "txt_Password2";
            txt_Password2.PlaceholderText = "Repeat Password";
            txt_Password2.Size = new Size(181, 23);
            txt_Password2.TabIndex = 5;
            txt_Password2.Tag = "";
            // 
            // Submit
            // 
            Submit.Location = new Point(387, 211);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 7;
            Submit.Text = "submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // txt_Number
            // 
            txt_Number.Location = new Point(335, 174);
            txt_Number.Name = "txt_Number";
            txt_Number.PlaceholderText = "phone number";
            txt_Number.Size = new Size(181, 23);
            txt_Number.TabIndex = 8;
            // 
            // SignUpMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Number);
            Controls.Add(Submit);
            Controls.Add(txt_Password2);
            Controls.Add(txt_Username);
            Controls.Add(txt_Password);
            Controls.Add(back3);
            Name = "SignUpMenu";
            Text = "SignUpMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back3;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private TextBox txt_Password2;
        private Button Submit;
        private TextBox txt_Number;
    }
}