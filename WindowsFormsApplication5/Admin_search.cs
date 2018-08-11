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
    public partial class Admin_Search : Form
    {
        SqlConnection con = new SqlConnection();
        public Admin_Search()
        {
            InitializeComponent();
        }

        private void Admin_Search_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=GSRD-PC\\SSQLEXPRESS;Initial Catalog=time_table;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from student_reg where username like'" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
  
        }

        private void button2_Click(object sender, EventArgs e)

        {
            con.Open();
            SqlDataAdapter adp=new SqlDataAdapter("select * from teacher_reg where username like'"+textBox2.Text+"%'",con );
            DataTable dt=new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource=dt;
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
