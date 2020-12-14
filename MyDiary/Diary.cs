using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if(Namebox.Text=="")
            {
                MessageBox.Show("ERROR Event Is Empty");
            }
            else if(richTextBox1.Text == "")
            {
                MessageBox.Show("ERROR Diary Is Empty");
            }
            else
            {
                MessageBox.Show("Diary Saved");
                Namebox.Text = richTextBox1.Text = dateTimePicker1.Text = string.Empty;
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
    }
}

