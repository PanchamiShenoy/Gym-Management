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
using System.Data.Sql;


namespace WindowsFormsApp1
{
    public partial class facilites : Form
    {
        public facilites()
        {
            InitializeComponent();
            txt_yrid.Text = Form1.custid;

        }
        int faci;
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void facilites_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-BH7ASV3C;Initial Catalog=example;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
            Form1 frm1 = new Form1();
            if (cb_1.Checked == true)
            {
                MessageBox.Show("working");
                faci = 100;
                string s = "insert into custfaci values(@cust_id,@faci)";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@cust_id", txt_yrid.Text);
                cmd.Parameters.AddWithValue("@faci", faci);
                cmd.CommandType = CommandType.Text;
                 int i=cmd.ExecuteNonQuery();
                MessageBox.Show( " Row(s) Inserted ");
            }
            if (cb_2.Checked == true)
            {
                faci = 200;

                string s = "insert into custfaci values(@cust_id,@faci)";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@cust_id", txt_yrid.Text);
                cmd.Parameters.AddWithValue("@faci", faci);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " Row(s) Inserted ");

            }
            if (cb_3.Checked == true)
            {
                faci = 300;

                string s = "insert into custfaci values(@cust_id,@faci)";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@cust_id", txt_yrid.Text);
                cmd.Parameters.AddWithValue("@faci", faci);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " Row(s) Inserted ");
            }
            if (cb_4.Checked == true)
            {
                faci = 400;

                string s = "insert into custfaci values(@cust_id,@faci)";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@cust_id", txt_yrid.Text);
                cmd.Parameters.AddWithValue("@faci", faci);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " Row(s) Inserted ");
            }



        }
    }
}
