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
    public partial class Admin_additions : Form
    {
        SqlConnection con = new SqlConnection();
        public Admin_additions()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ins", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@t_name", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@lecture", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@day", comboBox3.SelectedItem);
            cmd.Parameters.AddWithValue("@subject", listBox1.SelectedItem);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            listBox1.SelectedIndex = -1;

            Show_t_time_table obj = new Show_t_time_table();
            obj.Show();
        }


        private void Admin_additions_Load(object sender, EventArgs e)
        {
            con.ConnectionString="Data Source=GSRD-PC\\SSQLEXPRESS;Initial Catalog=time_table;Integrated Security=True";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
