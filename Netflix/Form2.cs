using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Netflix
{
    public partial class Form2 : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
        }
        private void uNameTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (userName.Text.Length < 5 && userName.Text.Length != 0)
            {
                MessageBox.Show("Username should be at least 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userName.Focus();

                e.Cancel = true;
            }
        }
        private void userName_TextChanged(object sender, EventArgs e)
        {
            if (userName.Text.Length >= 1 && userName.Text.Length < 5)
            {
                usernameValid.ForeColor = Color.Red;
            }
            if (userName.Text.Length >= 5)
            {
                usernameValid.ForeColor = Color.Green;
            }
        }
        private void passwordTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(passWord.Text.Length > 8 && passWord.Text.Any(char.IsUpper) && passWord.Text.Any(char.IsLower) && passWord.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more password criteria(s) hasn't been met", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passWord.SelectAll();
                e.Cancel = true;
            }
        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {
            if (!(passWord.Text.Length > 8 && passWord.Text.Any(char.IsUpper) && passWord.Text.Any(char.IsLower) && passWord.Text.Any(char.IsDigit)))
            {
                passwordValid.ForeColor = Color.Red;
            }
            else
            {
                passwordValid.ForeColor = Color.Green;
            }
        }


        private void loginButton_Click(object sender, EventArgs e)
        {


            cn = new SqlConnection(@"Data Source=LAB109PC12\SQLEXPRESS; Initial Catalog=Netflix; Integrated Security=True;");
            cn.Open();

            if (passWord.Text != string.Empty || rePassword.Text != string.Empty)
            {
                if (passWord.Text == rePassword.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from Register where Username='" + userName.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Register values(@Username, @Password)", cn);
                        cmd.Parameters.AddWithValue("Username", userName.Text);
                        cmd.Parameters.AddWithValue("Password", passWord.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Your have successfuly logged in", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void passwordLabel(object sender, EventArgs e)
        {

        }

        private void buttonGoLogin_Click(object sender, EventArgs e)
        {

            Login loginInstead = new Login();
            loginInstead.Show();
            Hide();

        }
    }
}
