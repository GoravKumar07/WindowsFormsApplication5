using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication5
{
    public partial class Student_login : Form
    {
        SqlConnection con = new SqlConnection();
        public Student_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_Registration obj = new Student_Registration();
            obj.Show();
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=GSRD-PC\\SSQLEXPRESS;Initial Catalog=time_table;Integrated Security=True";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student_change_pswd obj = new Student_change_pswd();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from student_reg where username=@username and password=@password", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmd.Dispose();
            if(dt.Rows.Count>0)
            {
                MessageBox.Show("welcome");
                Student_time_table obj = new Student_time_table();
                obj.Show();
            }
            else
            {
                MessageBox.Show("not valid");
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        }
    }

