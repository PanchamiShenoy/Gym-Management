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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
            txt_yrid3.Text = Form1.custid;
        }

        private void payment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-BH7ASV3C;Initial Catalog=example;Integrated Security=True");
            SqlCommand cmd;
            SqlDataAdapter adapter;
            DataTable table;
            con.Open();
            string s = "exec payment_det  @cust_id= '" + txt_yrid3.Text + "'";
            cmd = new SqlCommand(s, con);
            adapter = new SqlDataAdapter(s, con);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btn_hm3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm4 = new Form2();
            frm4.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
