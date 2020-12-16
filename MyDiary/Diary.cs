﻿using System;
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
        public Diary()
        {
            InitializeComponent();
        }

        private void Namebox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Uploadbutton1_Click(object sender, EventArgs e)
        {
            string imageLocation;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = ofd.FileName;
                    pictureBox1.ImageLocation = imageLocation;
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
            if(Eventbox.Text=="")
            {
                MessageBox.Show("ERROR Event Is Empty");
            }
            else if(DiaryrichTextBox1.Text == "")
            {
                MessageBox.Show("ERROR Diary Is Empty");
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Png);
                byte[] pic_arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(pic_arr, 0, pic_arr.Length);

                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DiaryEvent"].ConnectionString);
                connection.Open();
                string sq2 = "INSERT INTO DiaryEvent(Event,Importance,Date,Diary,Picture) VALUES('" + Eventbox.Text + "','" + ImportancecomboBox1.Text + "','" + dateTimePicker1.Text + "','" + DiaryrichTextBox1.Text + "','"+ pic_arr + "')";
                
                SqlCommand command = new SqlCommand(sq2, connection);
                int diary = command.ExecuteNonQuery();
                connection.Close();
                if (diary > 0)
                {
                    MessageBox.Show("Diary Saved");
                    Eventbox.Text = DiaryrichTextBox1.Text = dateTimePicker1.Text= ImportancecomboBox1.Text = string.Empty;
                    pictureBox1 = null;
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
            if(ImportancecomboBox1.Text== "High")
            {
                ImportancecomboBox1.BackColor = Color.Green;
            }
            else if(ImportancecomboBox1.Text== "Moderate")
            {
                ImportancecomboBox1.BackColor = Color.Yellow;
            }
            else if(ImportancecomboBox1.Text=="Less")
            {
                ImportancecomboBox1.BackColor = Color.Red;
            }
            else
            {
                ImportancecomboBox1.BackColor = Color.White;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
