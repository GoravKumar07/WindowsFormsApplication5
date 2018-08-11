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
    public partial class Teacher_time_table : Form
    {

        public Teacher_time_table()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_t_time_table obj = new Show_t_time_table();
            obj.Show();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[1].Value = "Maths";
            dataGridView1.Rows[1].Cells[1].Value = "Maths";

        }

        private void Teacher_time_table_Load(object sender, EventArgs e)
        {
            loadTimes();
        }




        public void loadTimes()
        {
            bool noon = false;
            int t = 9;
            string[] lunch = new string[6];
            lunch[0] = "12:20pm";
            for (int l = 1; l < 6; l++)
            {
                lunch[l] = "Lunch";
            }

            string str = ":00am";
            for (int i = 0; i < 7; i++)
            {
                if (t == 12 && !noon)
                {
                    noon = true;
                    str = ":00pm";
                    t = 0;
                    dataGridView1.Rows.Add(lunch);
                }
                else
                {
                    dataGridView1.Rows.Add(t.ToString() + str);
                }

                t++;
            }

        }
    }
}

