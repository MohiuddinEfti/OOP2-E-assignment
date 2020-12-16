using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiary
{
    public partial class Home : Form
    {
        int id;
        public Home()
        {
            InitializeComponent();
        }

        private void Diarybutton1_Click(object sender, EventArgs e)
        {
            Diary dy = new Diary();
            dy.Show();
            this.Hide();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DiaryEvent"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM DiaryEvent";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Homedata> list = new List<Homedata>();
            while (reader.Read())
            {
                Homedata user = new Homedata();
                user.Id = (int)reader["Id"];
                user.Event = reader["Event"].ToString();
                user.Importance = reader["Importance"].ToString();
                user.Date = reader["Date"].ToString();
                user.Diary = reader["Diary"].ToString();
                user.Picture = reader["Picture"].ToString();
                
                list.Add(user);
            }
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            UpdaterichTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            DlttextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DiaryEvent"].ConnectionString);
            connection.Open();
            string sql = "UPDATE DiaryEvent SET Diary='" + UpdaterichTextBox1.Text + "'WHERE Id=" + id;
            SqlCommand command = new SqlCommand(sql, connection);
            int diary = command.ExecuteNonQuery();
            connection.Close();
            if (diary > 0)
            {
                MessageBox.Show("Diary Saved");
                

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Dltbutton1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DiaryEvent"].ConnectionString);
            connection.Open();
            string sql = "DELETE FROM DiaryEvent WHERE Id=" + id;
            SqlCommand command = new SqlCommand(sql, connection);
            int diary = command.ExecuteNonQuery();
            connection.Close();
            if (diary > 0)
            {
                MessageBox.Show("Diary Deleted");


            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
