namespace OnlineBookStore
{
    partial class Entry
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
            Username = new Label();
            Password = new Label();
            UserText = new TextBox();
            PassText = new TextBox();
            Login = new Button();
            SignUp = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(178, 115);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(177, 160);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // UserText
            // 
            UserText.Location = new Point(248, 117);
            UserText.Name = "UserText";
            UserText.Size = new Size(100, 23);
            UserText.TabIndex = 5;
            // 
            // PassText
            // 
            PassText.Location = new Point(248, 157);
            PassText.Name = "PassText";
            PassText.Size = new Size(100, 23);
            PassText.TabIndex = 6;
            PassText.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            Login.Location = new Point(203, 199);
            Login.Name = "Login";
            Login.Size = new Size(75, 23);
            Login.TabIndex = 7;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += button_Login;
            // 
            // SignUp
            // 
            SignUp.Location = new Point(298, 199);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(75, 23);
            SignUp.TabIndex = 8;
            SignUp.Text = "Sign up";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // Entry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(SignUp);
            Controls.Add(Login);
            Controls.Add(PassText);
            Controls.Add(UserText);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "Entry";
            Text = "Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Username;
        private Label Password;
        private TextBox UserText;
        private TextBox PassText;
        private Button Login;
        private Button SignUp;
    }
}
