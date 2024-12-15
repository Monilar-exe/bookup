using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace OnlineBookStore
{
    public partial class SignUpMenu : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public SignUpMenu()
        {
            InitializeComponent();
              connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kuya\OneDrive\Desktop\New folder\OnlineBookStore_AppsDev\Database.accdb;Persist Security Info=False;";

        }

        private void back3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entry entry = new Entry();
            entry.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string pass1 = txt_Password.Text;
            string pass2 = txt_Password2.Text;
            int num;

            if (string.IsNullOrEmpty(txt_Password.Text) ||
                string.IsNullOrEmpty(txt_Password2.Text) ||
                string.IsNullOrEmpty(txt_Username.Text) ||
                string.IsNullOrEmpty(txt_Number.Text))
            {
                MessageBox.Show("There is an empty box");

            }
            else if (!int.TryParse(txt_Number.Text, out num)) 
            {
                MessageBox.Show("Enter a valid number");
            }
            else
            {

                if (pass2 == pass1)
                {

                    try
                    {
                        connection.Open();

                        string query = "INSERT INTO [USERS] ([Username], [Password], [phone]) VALUES (@Username, @Password , @phone)";

                        OleDbCommand command = new OleDbCommand(query, connection);

                        command.Parameters.AddWithValue("@Username", txt_Username.Text);
                        command.Parameters.AddWithValue("@Password", txt_Password2.Text);
                        command.Parameters.AddWithValue("@phone", txt_Number.Text);


                        command.ExecuteNonQuery();
                        MessageBox.Show("SUCCESS");
                        this.Hide();
                        Entry entry = new Entry();
                        entry.Show();

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                        connection.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Password did not match!");
                    connection.Close();
                }
            }
        }


    }
}
