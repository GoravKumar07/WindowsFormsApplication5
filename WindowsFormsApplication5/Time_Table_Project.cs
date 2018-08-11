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
    public partial class Time_Table_Project : Form
    {
        public Time_Table_Project()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       


        private void Time_Table_Project_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Teacher_Login obj = new Teacher_Login();
            obj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin_Login obj = new Admin_Login();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_login obj = new Student_login();
            obj.Show();
        }
    }
}
    

