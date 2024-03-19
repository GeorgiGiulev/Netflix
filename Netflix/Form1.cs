using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Netflix.authenticate;

namespace Netflix
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilmType.SelectedText = "Film Type";
            Category.SelectedText = "Category";
            AgeRating.SelectedText = "Age Rating";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC12\SQLEXPRESS; Initial Catalog=Netflix; Integrated Security=True;"))
            {
                bool a = false;
                bool b = false;
                bool c = false;

                sqlCon.Open();
                string query = "SELECT * FROM NetflixTB WHERE 1 = 1";

                List<string> conditions = new List<string>();

                if (AgeRating.SelectedItem != null)
                {
                    a = true;
                    conditions.Add("AgeRating = @AgeRating");
                }


                if (Category.SelectedItem != null)
                {
                    b = true;
                    conditions.Add("Category = @Category");
                }


                if (FilmType.SelectedItem != null)
                {
                    c = true;
                    conditions.Add("FilmType = @FilmType");
                }


                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                if (a)
                    cmd.Parameters.AddWithValue("@AgeRating", AgeRating.SelectedItem.ToString());
                if (b)
                    cmd.Parameters.AddWithValue("@Category", Category.SelectedItem.ToString());
                if (c)
                    cmd.Parameters.AddWithValue("@FilmType", FilmType.SelectedItem.ToString());

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            FilmType.SelectedIndex = -1;
            Category.SelectedIndex = -1;
            AgeRating.SelectedIndex = -1;
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract data from the selected row
                string filmType = selectedRow.Cells["FilmType"].Value.ToString();
                string category = selectedRow.Cells["Category"].Value.ToString();
                string ageRating = selectedRow.Cells["AgeRating"].Value.ToString();

                // Pass the data to the booking form
                using (booking userInputForm = new booking())
                {
                    // Set the properties in the booking form
                    userInputForm.FilmTypeValue = filmType;
                    userInputForm.CategoryValue = category;
                    userInputForm.AgeRatingValue = ageRating;

                    // Show the booking form
                    userInputForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to book.");
            }
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Extract data from the selected row
                string filmType = selectedRow.Cells["FilmType"].Value.ToString();
                string category = selectedRow.Cells["Category"].Value.ToString();
                string ageRating = selectedRow.Cells["AgeRating"].Value.ToString();

                // Pass the data to the booking form
                using (booking userInputForm = new booking())
                {
                    // Set the fields in the booking form
                    userInputForm.FilmTypeValue = filmType;
                    userInputForm.CategoryValue = category;
                    userInputForm.AgeRatingValue = ageRating;

                    // Show the booking form
                    userInputForm.ShowDialog();
                }
            }
        }
    }
}