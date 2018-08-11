using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Search obj = new Admin_Search();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_additions obj = new Admin_additions();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Details obj = new Admin_Details();
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
