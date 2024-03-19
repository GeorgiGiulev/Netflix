using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netflix
{
    public partial class booking : Form
    {
        public string FilmTypeValue { get; set; }
        public string CategoryValue { get; set; }
        public string AgeRatingValue { get; set; }
        public booking()
        {
            InitializeComponent();
        }

        public void booking_Load(object sender, EventArgs e)
        {
            filmTypeBox.Text = FilmTypeValue;
            categoryBox.Text = CategoryValue;
            ageRatingBox.Text = AgeRatingValue;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC12\SQLEXPRESS; Initial Catalog=Netflix; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                string insertQuery = "INSERT INTO Bookings VALUES(@Name, @CardNumber, @ExpiryDate, @CVV)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                insertCmd.Parameters.AddWithValue("@Name", name.Text);
                insertCmd.Parameters.AddWithValue("@CardNumber", cardNumber.Text);
                insertCmd.Parameters.AddWithValue("@ExpiryDate", expiryDate.Text);
                insertCmd.Parameters.AddWithValue("@CVV", cvv.Text);


                insertCmd.ExecuteNonQuery();


                MessageBox.Show("Purchase Successful!");
                this.Close();
            }

        }

        private void categoryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void filmTypeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageRatingBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}


