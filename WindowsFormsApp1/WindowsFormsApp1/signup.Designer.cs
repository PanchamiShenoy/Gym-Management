using System;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    partial class signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.lbl_sname = new System.Windows.Forms.Label();
            this.lbl_spass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.txt_spass = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_custid = new System.Windows.Forms.Label();
            this.lbl_phno = new System.Windows.Forms.Label();
            this.txt_scustid = new System.Windows.Forms.TextBox();
            this.txt_sphno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_sname
            // 
            this.lbl_sname.AutoSize = true;
            this.lbl_sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sname.Location = new System.Drawing.Point(112, 114);
            this.lbl_sname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sname.Name = "lbl_sname";
            this.lbl_sname.Size = new System.Drawing.Size(51, 17);
            this.lbl_sname.TabIndex = 0;
            this.lbl_sname.Text = "NAME";
            // 
            // lbl_spass
            // 
            this.lbl_spass.AutoSize = true;
            this.lbl_spass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spass.Location = new System.Drawing.Point(112, 151);
            this.lbl_spass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_spass.Name = "lbl_spass";
            this.lbl_spass.Size = new System.Drawing.Size(96, 17);
            this.lbl_spass.TabIndex = 1;
            this.lbl_spass.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "SIGN UP";
            // 
            // txt_sname
            // 
            this.txt_sname.Location = new System.Drawing.Point(237, 114);
            this.txt_sname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(122, 20);
            this.txt_sname.TabIndex = 3;
            this.txt_sname.TextChanged += new System.EventHandler(this.txt_sname_TextChanged);
            // 
            // txt_spass
            // 
            this.txt_spass.Location = new System.Drawing.Point(237, 151);
            this.txt_spass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_spass.Name = "txt_spass";
            this.txt_spass.Size = new System.Drawing.Size(122, 20);
            this.txt_spass.TabIndex = 4;
            // 
            // btn_signup
            // 
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.Location = new System.Drawing.Point(237, 243);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 20);
            this.btn_signup.TabIndex = 5;
            this.btn_signup.Text = "done";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // lbl_custid
            // 
            this.lbl_custid.AutoSize = true;
            this.lbl_custid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_custid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custid.Location = new System.Drawing.Point(112, 72);
            this.lbl_custid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_custid.Name = "lbl_custid";
            this.lbl_custid.Size = new System.Drawing.Size(114, 17);
            this.lbl_custid.TabIndex = 6;
            this.lbl_custid.Text = "CUSTOMER ID";
            // 
            // lbl_phno
            // 
            this.lbl_phno.AutoSize = true;
            this.lbl_phno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phno.Location = new System.Drawing.Point(112, 199);
            this.lbl_phno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_phno.Name = "lbl_phno";
            this.lbl_phno.Size = new System.Drawing.Size(90, 17);
            this.lbl_phno.TabIndex = 7;
            this.lbl_phno.Text = "PHONE NO";
            // 
            // txt_scustid
            // 
            this.txt_scustid.Location = new System.Drawing.Point(237, 72);
            this.txt_scustid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_scustid.Name = "txt_scustid";
            this.txt_scustid.Size = new System.Drawing.Size(122, 20);
            this.txt_scustid.TabIndex = 8;
            // 
            // txt_sphno
            // 
            this.txt_sphno.Location = new System.Drawing.Point(237, 197);
            this.txt_sphno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sphno.Name = "txt_sphno";
            this.txt_sphno.Size = new System.Drawing.Size(122, 20);
            this.txt_sphno.TabIndex = 9;
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txt_sphno);
            this.Controls.Add(this.txt_scustid);
            this.Controls.Add(this.lbl_phno);
            this.Controls.Add(this.lbl_custid);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.txt_spass);
            this.Controls.Add(this.txt_sname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_spass);
            this.Controls.Add(this.lbl_sname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "signup";
            this.Text = "signup";
            this.Load += new System.EventHandler(this.signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sname;
        private System.Windows.Forms.Label lbl_spass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.TextBox txt_spass;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lbl_custid;
        private System.Windows.Forms.Label lbl_phno;
        private System.Windows.Forms.TextBox txt_scustid;
        private System.Windows.Forms.TextBox txt_sphno;
    }
}