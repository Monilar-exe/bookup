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
using OnlineBookStore_AppsDev;


namespace OnlineBookStore
{
    public partial class UserMenu : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public UserMenu()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kuya\OneDrive\Desktop\New folder\OnlineBookStore_AppsDev\Database.accdb;Persist Security Info=False;";

        }

       

        private void UserMenu_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Title  From AdminTB";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listbooksAVB.Items.Add(reader["Title"].ToString());
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                connection.Close();

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBookTitle.Text))
            {
                MessageBox.Show("Please enter Valid Information");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Title FROM AdminTB WHERE Title = @BookTitle";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("Title", textBoxBookTitle.Text);


                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable bookDetails = new DataTable();
                    adapter.Fill(bookDetails);

                    if (bookDetails.Rows.Count > 0)
                    {
                        listBoxFoundBook.Items.Clear(); // Clear any existing items
                        DataRow row = bookDetails.Rows[0];


                        listBoxFoundBook.Items.Add(row["Title"].ToString());


                        MessageBox.Show("Book found and added to the list.");

                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Book found with the given title");
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);

                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxBookTitle.Clear();
            listBoxFoundBook.Items.Clear();
            dataGridViewBookDetail.DataSource = null;
        }

        private void buttonAddToWishlist_Click(object sender, EventArgs e)
        {
            this.Hide();

            WishList wishList = new WishList();

            wishList.Show();


        }

        private void listbooksAVB_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from AdminTB where Title = '" + listbooksAVB.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Title_Label.Text = reader["Title"].ToString();
                    Price_Label.Text = reader["Price"].ToString();
                    Author_Label.Text = reader["Author"].ToString();
                    qty_Label.Text = reader["Quantity"].ToString();

                    if (Title_Label.Text == "Dune")
                    {
                        fiction1.Visible = true;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Fortress Blood")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = true;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "The Calculating Stars")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = true;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "The Sound Of the Hours")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = true;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "The Past Is Rising")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = true;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "A Brief History of Time")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = true;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Ancient Wonders")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = true;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "500 Facts History")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = true;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Butch Cassidy")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = true;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "A Slave No More")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = true;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Social Science")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = true;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Forensic Psychology")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = true;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Writing Successful Academic Books")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = true;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Application Essay")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = true;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Application Essay")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = true;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "The Elements of Style")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = true;
                    }



                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);

            }

        }

        private void listBoxFoundBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from AdminTB where Title = '" + listBoxFoundBook.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Title_Label.Text = reader["Title"].ToString();
                    Price_Label.Text = reader["Price"].ToString();
                    Author_Label.Text = reader["Author"].ToString();
                    qty_Label.Text = reader["Quantity"].ToString();

                    if (Title_Label.Text == "Dune")
                    {
                        fiction1.Visible = true;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Fortress Blood")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = true;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "The Calculating Stars")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = true;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "The Sound Of the Hours")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = true;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "The Past Is Rising")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = true;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "A Brief History of Time")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = true;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Ancient Wonders")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = true;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "500 Facts History")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = true;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Butch Cassidy")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = true;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "A Slave No More")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = true;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Social Science")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = true;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Forensic Psychology")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = true;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Writing Successful Academic Books")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = true;
                        academic4.Visible = false;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Application Essay")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = true;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "Application Essay")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = true;
                        academic5.Visible = false;
                    }
                    else if (Title_Label.Text == "The Elements of Style")
                    {
                        fiction1.Visible = false;
                        fiction2.Visible = false;
                        fiction3.Visible = false;
                        fiction4.Visible = false;
                        fiction5.Visible = false;
                        nonfiction.Visible = false;
                        nonfiction2.Visible = false;
                        nonfiction3.Visible = false;
                        nonfiction4.Visible = false;
                        nonfiction5.Visible = false;
                        academic.Visible = false;
                        academic2.Visible = false;
                        academic3.Visible = false;
                        academic4.Visible = false;
                        academic5.Visible = true;
                    }



                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);

            }


        }

        private void back2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entry entry = new Entry();
            entry.Show();
        }
    }
}
