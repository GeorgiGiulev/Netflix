using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Netflix
{
    public partial class Login : Form
    {
        SqlConnection sqlCon;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                // Establish connection with the SQL Server database
                sqlCon = new SqlConnection(@"Data Source=LAB109PC12\SQLEXPRESS; Initial Catalog=Netflix; Integrated Security=True;");
                sqlCon.Open(); // Open the connection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = userName.Text;
            string pass = passWord.Text;

            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass))
            {
                // Query the database to check if the provided credentials are valid
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Register WHERE Username = @Username AND Password = @Password", sqlCon);
                cmd.Parameters.AddWithValue("@Username", user);
                cmd.Parameters.AddWithValue("@Password", pass);

                int count = (int)cmd.ExecuteScalar(); // Execute the query and get the count of matching rows

                if (count > 0)
                {
                    // Authentication successful
                    MessageBox.Show("Login successful!");
                    // You may navigate to the next form or perform any other action here
                    Form1 form1continue = new Form1();
                    form1continue.Show();
                    Hide();
                }
                else
                {
                    // Authentication failed
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form2 form2back = new Form2();
            form2back.Show();
            Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlCon.Close(); // Close the database connection when the form is closed
        }
    }
}
