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
    public partial class Login : Form
    {
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
            if(Namebox.Text=="")
            {
                MessageBox.Show("ERROR Username Is Empty");

            }
            else if(PasswordBox.Text=="")
            {
                MessageBox.Show("ERROR Password Is Empty");

            }
            else
            {
                Diary dr = new Diary();
                dr.Show();
                this.Hide();
            }
            
        }
    }
}
