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
    public partial class Teacher_Login : Form
    {
        SqlConnection con = new SqlConnection();
        public Teacher_Login()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=GSRD-PC\\SSQLEXPRESS;Initial Catalog=time_table;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    



            
            

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        Teacher_Registration obj=new Teacher_Registration();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher_Registration obj = new Teacher_Registration();
            obj.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           Teacher_change_pswd obj = new Teacher_change_pswd();
            obj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from teacher_reg where username=@username and password=@password", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmd.Dispose();
            if(textBox1.Text=="aman_k" && textBox2.Text=="pass@123")
            {
                MessageBox.Show("welcome Mrs Amandeep kaur");
                Mrs_Amandeep_Kaur obj = new Mrs_Amandeep_Kaur();
                obj.Show();
                        }
            else if(textBox1.Text=="arunima_ci" && textBox2.Text=="arunima@12")
            {
                MessageBox.Show("welcome Mrs Arunima");
                Mrs_Arunima obj = new Mrs_Arunima();
                obj.Show();
                        }
            else if (textBox1.Text == "ranjeet_s" && textBox2.Text == "rs@123")
            {
                MessageBox.Show("welcome Mr Ranjeet");
                Mr_Ranjeet_Singh obj = new Mr_Ranjeet_Singh();
                obj.Show();
            }
            else  if (textBox1.Text == "harpreet_ss" && textBox2.Text == "hss@123")
            {
                MessageBox.Show("welcome Mr Harpreet Singh");
                Mr_Harpreet_Singh_Sodhi obj = new Mr_Harpreet_Singh_Sodhi();
                obj.Show();
            }
            else if (textBox1.Text == "rs_walia" && textBox2.Text == "rsw@123")
            {
                MessageBox.Show("welcome Mr R.S. Walia");
                Mr_R_S_Walia   obj = new Mr_R_S_Walia();
                obj.Show();
            }

                else
            {
                MessageBox.Show("not valid");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }





            /*SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
         
            adp.Fill(dt);

            if(dt.Rows.Count>0)
            {
                Teacher_time_table obj = new Teacher_time_table();
                obj.Show();

            }

            else
            {
                MessageBox.Show("invalid");
            }
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();*/

        }
    }


