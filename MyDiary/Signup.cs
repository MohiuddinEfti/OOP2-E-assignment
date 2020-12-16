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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Namebox.Text=="")
            {
                MessageBox.Show("ERROR Name Is Empty");
            }
            else if(PasswordBox.Text=="")
            {
                MessageBox.Show("ERROR Password Is Empty");
            }
            else if (Emailbox.Text == "")
            {
                MessageBox.Show("ERROR Email Is Empty");

            }
            else if(PasswordBox.Text!=Confirmbox.Text)
            {
                MessageBox.Show("ERROR Password And Confirm Password Not Matched");

            }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DiarySignUp"].ConnectionString);
                connection.Open();
                string sql = "INSERT INTO DiarySignUp(Name,Password,Email) VALUES('" + Namebox.Text + "','" + PasswordBox.Text + "','" + Emailbox.Text + "')";
                SqlCommand command = new SqlCommand(sql, connection);
                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result > 0)
                {
                    MessageBox.Show("Account Created");
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();  

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
