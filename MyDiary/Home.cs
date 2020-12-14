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
    public partial class Home : Form
    {
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
    }
}
