using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogReg
{
    public partial class CURD : Form
    {
        public CURD()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=QUINTESSENTIAL\SQLEXPRESS;Initial Catalog=MovieManagement;Integrated Security=True;");
        public int MovieSl;
        private void CURD_Load(object sender, EventArgs e)
        {
            GetMovieRecord();
        }

        private void GetMovieRecord()
        {

            SqlCommand cmd = new SqlCommand("Select * from MovieTbl", connection);
            DataTable dt = new DataTable();

            connection.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            connection.Close();

            MovieRecordDataGridView.DataSource = dt;
            MovieRecordDataGridView.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("insert into MovieTbl values (@id, @name, @unitAvailable, @unitPrice)", connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", p_id.Text);
                cmd.Parameters.AddWithValue("@name", p_name.Text);
                cmd.Parameters.AddWithValue("@unitAvailable", u_available.Text);
                cmd.Parameters.AddWithValue("@unitPrice", u_price.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Movie added successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetMovieRecord();
                ResetFormControls();

            }
        }

        private bool IsValid()
        {
            if (p_id.Text == string.Empty)
            {
                MessageBox.Show("Inter Movie id to Insert", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            MovieSl = 0;
            p_id.Clear();
            p_name.Clear();
            u_available.Clear();
            u_price.Clear();

            p_id.Focus();
        }

        private void MovieRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MovieSl = Convert.ToInt32(MovieRecordDataGridView.SelectedRows[0].Cells[0].Value);
            p_id.Text = MovieRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            p_name.Text = MovieRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            u_available.Text =MovieRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            u_price.Text = MovieRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MovieSl > 0)
            {
                SqlCommand cmd = new SqlCommand("update MovieTbl set MovieId = @id, MovieName = @name, SeatAvailable = @unitAvailable, TicketPrice = @unitPrice where MovieSl = @Sl", connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", p_id.Text);
                cmd.Parameters.AddWithValue("@name", p_name.Text);
                cmd.Parameters.AddWithValue("@unitAvailable", u_available.Text);
                cmd.Parameters.AddWithValue("@unitPrice", u_price.Text);
                cmd.Parameters.AddWithValue("@Sl", this.MovieSl);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Movie information is updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetMovieRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select a movie to update information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MovieSl > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from MovieTbl where MovieSl = @Sl", connection);

                cmd.Parameters.AddWithValue("@Sl", this.MovieSl);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Movie is deleted form list", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetMovieRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select a movie to delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void MovieRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
