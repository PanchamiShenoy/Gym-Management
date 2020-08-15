using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lbl_trainer_Click(object sender, EventArgs e)
        {
            this.Hide();
            trainer t = new trainer();
            t.Show();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
                  
        }

        private void lbl_facilities_Click(object sender, EventArgs e)
        {
            this.Hide();
            
           
            facilites fff = new facilites();
            fff.Show();
        }

        private void lbl_aboutme_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer cc = new customer();
            cc.Show();

        }

        private void lblpayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment pp = new payment();
            pp.Show();
        }
    }
}
