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
    public partial class Login : Form
    {
        public int take;
        private SqlConnection main_form;
       
        public Login()
        {
            InitializeComponent();
            
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Signup sp = new Signup();
            sp.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Signinbutton_Click(object sender, EventArgs e)
        {
           
            if (Namebox.Text=="")
            {
                MessageBox.Show("ERROR Username Is Empty");

            }
            else if(PasswordBox.Text=="")
            {
                MessageBox.Show("ERROR Password Is Empty");

            }
            else
            {




                
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SignUp"].ConnectionString);
                

                SqlCommand cmd = new SqlCommand("SELECT * FROM SignUp WHERE Name = '" + Namebox.Text+"' AND [Password] = '"+PasswordBox.Text+"' ", connection);
                


                connection.Open();


                SqlDataReader sdr = cmd.ExecuteReader();


                if ((sdr.Read() == true))

                {

                    string sq1 = "SELECT * FROM SignUp WHERE Name = '" + Namebox.Text + "'";
                    SqlCommand commands = new SqlCommand(sq1, connection);

                    take = (int)sdr["Id"];
                    Diary d = new Diary(take);

                    d.Show();

                    this.Hide();


                }

                else

                {

                    MessageBox.Show("Invalid username or password!");

                }

            }



            
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
