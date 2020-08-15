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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
        public static string custid;
        // SqlConnection con = new SqlConnection("Data Source = LAPTOP - IHRMBHLQ; Initial Catalog = example; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {        
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-BH7ASV3C;Initial Catalog=example;Integrated Security=True");
                if (string.IsNullOrEmpty(this.txt_lcustid.Text) | string.IsNullOrEmpty(this.txt_pass.Text))
                {
                MessageBox.Show("provide User Name and Password");
                }  //facilities f = new facilities(txt_lcustid.Text);
                   //int cid;
                   // cid = int.Parse(txt_lcustid.Text);
            custid = txt_lcustid.Text;
        string query = "SELECT * FROM customer WHERE customer_id = '" + txt_lcustid.Text + "' and password = '" + txt_pass.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Form2 fr2 = new Form2();
                this.Hide();
                fr2.Show();

            }

            else
            {
                MessageBox.Show("check your username and password");
            }
             
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signup ss = new signup();
            ss.Show();
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
