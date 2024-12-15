using OnlineBookStore_AppsDev;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace OnlineBookStore
{
    public partial class AdminPanel : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public AdminPanel()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kuya\OneDrive\Desktop\New folder\OnlineBookStore_AppsDev\Database.accdb;Persist Security Info=False;";
        }

        private void AddBttn_Click(object sender, EventArgs e)
        {
            ID_label.Visible = false;
            txt_updateID.Visible = false;
            btn_UPDATE.Visible = false;

            int Inputqty;
            int price;

            if (string.IsNullOrEmpty(TitleTxtBox.Text) ||
                string.IsNullOrEmpty(AuthorTxtBox.Text) ||
                string.IsNullOrEmpty(QuantityTxtBox.Text) ||
                string.IsNullOrEmpty(GenreCmbBox.Text) ||
                string.IsNullOrEmpty(txt_Price.Text))
            {
                MessageBox.Show("Please input details");
            }
            else if (!int.TryParse(QuantityTxtBox.Text, out Inputqty) ||
                     !int.TryParse(txt_Price.Text, out price))
            {
                MessageBox.Show("Please enter a valid value");
                return;
            }
            else if (Inputqty <= 0 || price <= 0)
            {
                MessageBox.Show("Please enter a valid value");
            }
            else
            {
                connection.Open();

                string query = "INSERT INTO [AdminTB] ([Quantity], [Title], [Author], [Genre], [Price]) VALUES (@Quantity, @Title , @Author, @Genre, @Price)";

                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@Quantity", QuantityTxtBox.Text);
                command.Parameters.AddWithValue("@Title", TitleTxtBox.Text);
                command.Parameters.AddWithValue("@Author", AuthorTxtBox.Text);
                command.Parameters.AddWithValue("@Genre", GenreCmbBox.Text);
                command.Parameters.AddWithValue("@Price", txt_Price.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("BOOK ADDED");
                TitleTxtBox.Clear();
                AuthorTxtBox.Clear();
                QuantityTxtBox.Clear();
                GenreCmbBox.SelectedItem = null;
                txt_Price.Clear();
                connection.Close();


                try
                {

                    string query2 = "SELECT * FROM AdminTB";
                    command.CommandText = query2;

                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    bookview.DataSource = dt;
                    connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                    connection.Close();
                }


            }
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entry entry = new Entry();
            entry.Show();
        }


        private void DeleteBttn_Click(object sender, EventArgs e)
        {
            int id;

            if (string.IsNullOrEmpty(txt_deleteID.Text))
            {
                MessageBox.Show("input ID");
            }
            else if (!int.TryParse(txt_deleteID.Text, out id))
            {
                MessageBox.Show("Please enter a valid value");
                return;
            }
            else if (id <= 0)
            {
                MessageBox.Show("Please enter a valid value");
            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "DELETE FROM AdminTB WHERE ID=" + txt_deleteID.Text + "";
                    command.CommandText = query;

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Book deleted");
                        txt_deleteID.Clear();

                        try
                        {

                            string query2 = "SELECT * FROM AdminTB";
                            command.CommandText = query2;

                            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            bookview.DataSource = dt;
                            connection.Close();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.Message);
                            connection.Close();
                        }

                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Book does not exist");
                        txt_deleteID.Clear();
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                    connection.Close();
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ID_label.Visible = true;
            txt_updateID.Visible = true;
            btn_UPDATE.Visible = true;

            TitleTxtBox.Clear();
            AuthorTxtBox.Clear();
            QuantityTxtBox.Clear();
            GenreCmbBox.SelectedItem = null;
            txt_Price.Clear();
        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            int id;
            int Inputqty;
            int price;

            if (string.IsNullOrEmpty(TitleTxtBox.Text) ||
                string.IsNullOrEmpty(AuthorTxtBox.Text) ||
                string.IsNullOrEmpty(QuantityTxtBox.Text) ||
                string.IsNullOrEmpty(GenreCmbBox.Text) ||
                string.IsNullOrEmpty(txt_Price.Text))
            {
                MessageBox.Show("Please input details");
            }
            else if (string.IsNullOrEmpty(txt_updateID.Text))
            {
                MessageBox.Show("Input ID");
            }
            else if (!int.TryParse(txt_updateID.Text, out id) ||
                     !int.TryParse(QuantityTxtBox.Text, out Inputqty) ||
                     !int.TryParse(txt_Price.Text, out price))
            {
                MessageBox.Show("Please enter a valid value");
                return;
            }
            else if (Inputqty <= 0 || price <= 0 || id <= 0)
            {
                MessageBox.Show("Please enter a valid value");
            }
            else
            {
                try
                {

                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "UPDATE AdminTB SET Title='" + TitleTxtBox.Text + "', Author='" + AuthorTxtBox.Text + "', Quantity='" + QuantityTxtBox.Text + "', Genre='" + GenreCmbBox.Text + "', Price ='" + txt_Price.Text + "' WHERE ID=" + txt_updateID.Text + "";
                    command.CommandText = query;

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Book Updatedss");
                        TitleTxtBox.Clear();
                        AuthorTxtBox.Clear();
                        QuantityTxtBox.Clear();
                        GenreCmbBox.SelectedItem = null;
                        txt_Price.Clear();

                        try
                        {

                            string query2 = "SELECT * FROM AdminTB";
                            command.CommandText = query2;

                            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            bookview.DataSource = dt;
                            connection.Close();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.Message);
                            connection.Close();
                        }

                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Book does not exist");
                        TitleTxtBox.Clear();
                        AuthorTxtBox.Clear();
                        QuantityTxtBox.Clear();
                        GenreCmbBox.SelectedItem = null;
                        txt_Price.Clear();
                        connection.Close();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                    connection.Close();

                }
            }
        }

        
        private void AdminPanel_Load_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM AdminTB";
                command.CommandText = query;

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                bookview.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                connection.Close();
            }

        }
    }
}
