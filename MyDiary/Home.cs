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
        DateTime time = DateTime.Now;
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
            string sq1 = "SELECT * FROM DiaryEvent";
            SqlCommand commands = new SqlCommand(sq1, connection);
            SqlDataReader reader = commands.ExecuteReader();
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
                user.CreatedTime = reader["CreatedTime"].ToString();
                user.ModfiedTime = reader["ModfiedTime"].ToString();

                list.Add(user);
                
            }
            dataGridView1.DataSource = list;
            connection.Close();




        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            UpdaterichTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string ab = time.ToString("h:mm:ss tt");
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DiaryEvent"].ConnectionString);
            connection.Open();
            string sql = "UPDATE DiaryEvent SET Diary='" + UpdaterichTextBox1.Text + "'WHERE Id=" + id;
            string sq3 = "UPDATE DiaryEvent SET ModfiedTime='" + ab + "'WHERE Id=" + id;
            string sq4 = "UPDATE DiaryEvent SET Event='" + textBox2.Text + "'WHERE Id=" + id;
            SqlCommand command1 = new SqlCommand(sq3, connection);
            SqlCommand command = new SqlCommand(sql, connection);
            SqlCommand command2 = new SqlCommand(sq4, connection);

            int diary = command.ExecuteNonQuery();
            int diarys = command1.ExecuteNonQuery();
            int diarys1 = command2.ExecuteNonQuery();

            if (diary > 0)
            {
                MessageBox.Show("Diary Modified");
                string sq2 = "SELECT * FROM DiaryEvent";
                SqlCommand commands = new SqlCommand(sq2, connection);
                SqlDataReader reader = commands.ExecuteReader();
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
                    user.CreatedTime = reader["CreatedTime"].ToString();
                    user.ModfiedTime = reader["ModfiedTime"].ToString();

                    list.Add(user);
                }
                dataGridView1.DataSource = list;
                connection.Close();
                UpdaterichTextBox1.Text = pictureBox1.ImageLocation=textBox2.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error");
            }
            
            string a = time.ToString("h:mm:ss tt");
        }

        private void Dltbutton1_Click(object sender, EventArgs e)
        {
            if(DlttextBox2.Text!="")
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DiaryEvent"].ConnectionString);
                connection.Open();
                string sql = "DELETE FROM DiaryEvent WHERE Id=" + Int32.Parse(DlttextBox2.Text);


                SqlCommand command = new SqlCommand(sql, connection);
                int diary = command.ExecuteNonQuery();

                if (diary > 0)
                {
                    MessageBox.Show("Diary Deleted");
                    string sq2 = "SELECT * FROM DiaryEvent";
                    SqlCommand commands = new SqlCommand(sq2, connection);
                    SqlDataReader reader = commands.ExecuteReader();
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
                        user.CreatedTime = reader["CreatedTime"].ToString();
                        user.ModfiedTime = reader["ModfiedTime"].ToString();

                        list.Add(user);
                    }
                    dataGridView1.DataSource = list;
                    connection.Close();
                    DlttextBox2.Text = UpdaterichTextBox1.Text = textBox2.Text = pictureBox1.ImageLocation = string.Empty;
                    


                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("There Is Nothing To Delete");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DiaryEvent"].ConnectionString);
            connection.Open();
            string sq1 = "SELECT * FROM DiaryEvent WHERE Event LIKE '"+textBox1.Text+"%'";
            SqlCommand commands = new SqlCommand(sq1, connection);
            SqlDataReader reader = commands.ExecuteReader();
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
                    user.CreatedTime = reader["CreatedTime"].ToString();
                    user.ModfiedTime = reader["ModfiedTime"].ToString();

                list.Add(user);

            }
            dataGridView2.DataSource = list;

            connection.Close();

        }

        

        private void DlttextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdaterichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
