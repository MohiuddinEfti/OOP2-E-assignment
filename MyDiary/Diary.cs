using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiary
{
    public partial class Diary : Form
    {
        public int Test { get; set; }



        public Diary()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Today;

        }

        private void Namebox_TextChanged(object sender, EventArgs e)
        {
        }
        public string abc;
        private void Uploadbutton1_Click(object sender, EventArgs e)
        {
            string img;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    img = ofd.FileName;
                    if(img!="")
                    {
                        abc = img;
                    }
                    else
                    {
                        abc = string.Empty;
                    }
                   
                    pictureBox1.ImageLocation = img;
                    
                    
                    
                }

            }
            catch(Exception)
            {
                MessageBox.Show("An ERROR Occured");
            }

        }

        private void Diary_Load(object sender, EventArgs e)
        {

        }

        private void Diary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Homebutton1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }
        private void Savebutton1_Click(object sender, EventArgs e)
        {
            
            if (Eventbox.Text=="")
            {
                
                MessageBox.Show("ERROR Event Is Empty");
                
            }
            else if(DiaryrichTextBox1.Text == "")
            {
                MessageBox.Show("ERROR Diary Is Empty");
            }            
            else 
            {
                
                DateTime time = DateTime.Now;
                string ab = time.ToString("h:mm:ss tt");
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Event"].ConnectionString);
                connection.Open();
                string sq1 = "INSERT INTO Event(Event,Importance,Date,Diary,Picture,CreatedTime) VALUES('" + Eventbox.Text + "','" + ImportancecomboBox1.Text + "','" + dateTimePicker1.Text + "','" + DiaryrichTextBox1.Text + "','"+ abc + "','"+ ab+ "')";
                SqlCommand command = new SqlCommand(sq1, connection);
                int diary = command.ExecuteNonQuery();
                connection.Close();
                if (diary > 0)
                {
                    MessageBox.Show("Diary Saved");

                    Eventbox.Text = DiaryrichTextBox1.Text = dateTimePicker1.Text= ImportancecomboBox1.Text = string.Empty;
                    ImportancecomboBox1.BackColor = Color.White;
                    pictureBox1.ImageLocation = null;
                    abc = string.Empty;
                    
                   
                    
                    
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            
        }

        private void Logoutbutton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure","Log Out", MessageBoxButtons.YesNo);
            if(dialogResult==DialogResult.Yes)
            {
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            else if(dialogResult==DialogResult.No)
            {
                this.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            
        }
    }
}

