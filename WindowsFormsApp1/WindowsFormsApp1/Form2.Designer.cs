namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_trainer = new System.Windows.Forms.Label();
            this.lbl_facilities = new System.Windows.Forms.Label();
            this.lbl_aboutme = new System.Windows.Forms.Label();
            this.lblpayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_trainer
            // 
            this.lbl_trainer.AutoSize = true;
            this.lbl_trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trainer.Location = new System.Drawing.Point(139, 97);
            this.lbl_trainer.Name = "lbl_trainer";
            this.lbl_trainer.Size = new System.Drawing.Size(75, 17);
            this.lbl_trainer.TabIndex = 0;
            this.lbl_trainer.Text = "TRAINER";
            this.lbl_trainer.Click += new System.EventHandler(this.lbl_trainer_Click);
            // 
            // lbl_facilities
            // 
            this.lbl_facilities.AutoSize = true;
            this.lbl_facilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_facilities.Location = new System.Drawing.Point(499, 97);
            this.lbl_facilities.Name = "lbl_facilities";
            this.lbl_facilities.Size = new System.Drawing.Size(106, 20);
            this.lbl_facilities.TabIndex = 1;
            this.lbl_facilities.Text = "FACILITIES";
            this.lbl_facilities.Click += new System.EventHandler(this.lbl_facilities_Click);
            // 
            // lbl_aboutme
            // 
            this.lbl_aboutme.AutoSize = true;
            this.lbl_aboutme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aboutme.Location = new System.Drawing.Point(138, 264);
            this.lbl_aboutme.Name = "lbl_aboutme";
            this.lbl_aboutme.Size = new System.Drawing.Size(105, 20);
            this.lbl_aboutme.TabIndex = 2;
            this.lbl_aboutme.Text = "ABOUT ME";
            this.lbl_aboutme.Click += new System.EventHandler(this.lbl_aboutme_Click);
            // 
            // lblpayment
            // 
            this.lblpayment.AutoSize = true;
            this.lblpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayment.Location = new System.Drawing.Point(499, 264);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(95, 20);
            this.lblpayment.TabIndex = 3;
            this.lblpayment.Text = "PAYMENT";
            this.lblpayment.Click += new System.EventHandler(this.lblpayment_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblpayment);
            this.Controls.Add(this.lbl_aboutme);
            this.Controls.Add(this.lbl_facilities);
            this.Controls.Add(this.lbl_trainer);
            this.Name = "Form2";
            this.Text = "homepage";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_trainer;
        private System.Windows.Forms.Label lbl_facilities;
        private System.Windows.Forms.Label lbl_aboutme;
        private System.Windows.Forms.Label lblpayment;
    }
}