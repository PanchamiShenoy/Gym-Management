using System;

namespace WindowsFormsApp1
{
    partial class facilites
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_1 = new System.Windows.Forms.CheckBox();
            this.cb_2 = new System.Windows.Forms.CheckBox();
            this.cb_3 = new System.Windows.Forms.CheckBox();
            this.cb_4 = new System.Windows.Forms.CheckBox();
            this.txt_yrid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_1
            // 
            this.cb_1.AutoSize = true;
            this.cb_1.Location = new System.Drawing.Point(124, 44);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(56, 17);
            this.cb_1.TabIndex = 0;
            this.cb_1.Text = "YOGA";
            this.cb_1.UseVisualStyleBackColor = true;
            // 
            // cb_2
            // 
            this.cb_2.AutoSize = true;
            this.cb_2.Location = new System.Drawing.Point(124, 67);
            this.cb_2.Name = "cb_2";
            this.cb_2.Size = new System.Drawing.Size(64, 17);
            this.cb_2.TabIndex = 1;
            this.cb_2.Text = "ZUMBA";
            this.cb_2.UseVisualStyleBackColor = true;
            // 
            // cb_3
            // 
            this.cb_3.AutoSize = true;
            this.cb_3.Location = new System.Drawing.Point(124, 90);
            this.cb_3.Name = "cb_3";
            this.cb_3.Size = new System.Drawing.Size(67, 17);
            this.cb_3.TabIndex = 2;
            this.cb_3.Text = "CARDIO";
            this.cb_3.UseVisualStyleBackColor = true;
            // 
            // cb_4
            // 
            this.cb_4.AutoSize = true;
            this.cb_4.Location = new System.Drawing.Point(124, 113);
            this.cb_4.Name = "cb_4";
            this.cb_4.Size = new System.Drawing.Size(77, 17);
            this.cb_4.TabIndex = 3;
            this.cb_4.Text = "WEIGHTS";
            this.cb_4.UseVisualStyleBackColor = true;
            // 
            // txt_yrid
            // 
            this.txt_yrid.Location = new System.Drawing.Point(16, 9);
            this.txt_yrid.Name = "txt_yrid";
            this.txt_yrid.Size = new System.Drawing.Size(100, 20);
            this.txt_yrid.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // facilites
            // 
            this.ClientSize = new System.Drawing.Size(659, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_yrid);
            this.Controls.Add(this.cb_4);
            this.Controls.Add(this.cb_3);
            this.Controls.Add(this.cb_2);
            this.Controls.Add(this.cb_1);
            this.Name = "facilites";
            this.Load += new System.EventHandler(this.facilites_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      //private void facilites_Load(object sender, EventArgs e)
        //{
              private System.Windows.Forms.CheckBox cb_1;
        private System.Windows.Forms.CheckBox cb_2;
        private System.Windows.Forms.CheckBox cb_3;
        private System.Windows.Forms.CheckBox cb_4;
        private System.Windows.Forms.TextBox txt_yrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
     
       
    
        //throw new NotImplementedException();
    }

    #endregion

   // private System.Windows.Forms.DataGridView dataGridView1;
       // private exampleDataSet1 example;
        //private System.Windows.Forms.BindingSource facility1BindingSource;
        //private exampleDataSet1TableAdapters.facility1TableAdapter facilitesTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn facilitynoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn facilitynameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn facilitytimeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn facilitycostDataGridViewTextBoxColumn;
        //private System.Windows.Forms.CheckBox cb_1;
        //private System.Windows.Forms.CheckBox cb_2;
        //private System.Windows.Forms.CheckBox cb_3;
        //private System.Windows.Forms.CheckBox cb_4;
        //private System.Windows.Forms.CheckBox cb_5;
        //private System.Windows.Forms.Button btn_done;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.TextBox txt_yrid;
        //private System.Windows.Forms.Button btn_hm1;
    
//}