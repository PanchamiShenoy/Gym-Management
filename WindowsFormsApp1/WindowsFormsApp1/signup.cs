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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void txt_sname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-BH7ASV3C;Initial Catalog=example;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
            string s = "insert into customer values(@p1,@p2,@p4,@p3)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", txt_scustid.Text);
            cmd.Parameters.AddWithValue("@p2", txt_sname.Text);
            cmd.Parameters.AddWithValue("@p3", txt_spass.Text);
            cmd.Parameters.AddWithValue("@p4", txt_sphno.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + " Row(s) Inserted ");
            this.Hide();
            Form1 ff1 = new Form1();
            ff1.Show();



        }

        private void signup_Load(object sender, EventArgs e)
        {

        }
    }
}
