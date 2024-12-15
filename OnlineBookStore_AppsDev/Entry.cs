using System.Data.OleDb;

namespace OnlineBookStore
{
    public partial class Entry : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Entry()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kuya\OneDrive\Desktop\New folder\OnlineBookStore_AppsDev\Database.accdb;Persist Security Info=False;";

        }
        private void button_Login(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserText.Text) ||
                string.IsNullOrEmpty(PassText.Text))
            {
                MessageBox.Show("put something");
            }
            else
            {
                    string adminUser = UserText.Text;
                    string adminPass= PassText.Text;

                    if (adminUser == "team" || adminPass == "admin123")
                    {
                        this.Hide();
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.Show();
                    }
                    else
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;
                        string query = "SELECT * FROM USERS WHERE Username = '" + UserText.Text + "' and Password = '" + PassText.Text + "'";
                        command.CommandText = query;
                        OleDbDataReader reader = command.ExecuteReader();

                        int count = 0;
                        while (reader.Read())
                        {
                            count++;
                        }
                        if (count == 1)
                        {
                            MessageBox.Show("Login Success");
                            this.Hide();
                            UserMenu userMenu = new UserMenu();
                            userMenu.Show();
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Login");
                            connection.Close();
                        }


                    }

            }

        }


        private void SignUp_Click(object sender, EventArgs e)
        { 
            this.Hide();
            SignUpMenu signUpMenu = new SignUpMenu();   
            signUpMenu.Show();


        }





    }

}

