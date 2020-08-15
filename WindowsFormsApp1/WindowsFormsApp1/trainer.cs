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
    public partial class trainer : Form
    {
       

        public trainer()
        {
            InitializeComponent();
        }
       
        
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void trainer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-BH7ASV3C;Initial Catalog=example;Integrated Security=True");
            SqlCommand cmd;
            SqlDataAdapter adapter;
            DataTable table;
            con.Open();
            string s = "select * from db_trainer";
            cmd = new SqlCommand(s, con);
            adapter = new SqlDataAdapter(s, con);
            table = new DataTable();
            adapter.Fill(table);
            dgv1.DataSource = table;

        }

        private void btn_hm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm3 = new Form2();
            frm3.Show();
        }
    }
}