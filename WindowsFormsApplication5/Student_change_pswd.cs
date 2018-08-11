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
    public partial class Student_change_pswd : Form
    {


        SqlConnection con = new SqlConnection();

        public Student_change_pswd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string str="select * from student_reg where password='" +textBox2.Text+"'";
            SqlCommand cmd=new SqlCommand(str,con);
            SqlDataReader dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "Data Source=GSRD-PC\\SSQLEXPRESS;Initial Catalog=time_table;Integrated Security=True";
                con1.Open();
                string str1 = "update student_reg set password='" + textBox4.Text + "' where password='" + textBox2.Text + "'";

                SqlCommand cmd1 = new SqlCommand(str1, con1);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("your password has been changed");
                con1.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("not changed");
            }


            }
            


        private void Password_Enter(object sender, EventArgs e)
        {

        }

        private void Student_change_pswd_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=GSRD-PC\\SSQLEXPRESS;Initial Catalog=time_table;Integrated Security=True";
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
