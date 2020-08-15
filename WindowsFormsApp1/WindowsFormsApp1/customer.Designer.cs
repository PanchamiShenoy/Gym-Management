namespace WindowsFormsApp1
{
    partial class customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_yrid2 = new System.Windows.Forms.Label();
            this.txt_yrid2 = new System.Windows.Forms.TextBox();
            this.btn_hm4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(467, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_yrid2
            // 
            this.lbl_yrid2.AutoSize = true;
            this.lbl_yrid2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_yrid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yrid2.Location = new System.Drawing.Point(49, 34);
            this.lbl_yrid2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_yrid2.Name = "lbl_yrid2";
            this.lbl_yrid2.Size = new System.Drawing.Size(59, 13);
            this.lbl_yrid2.TabIndex = 1;
            this.lbl_yrid2.Text = "YOUR ID";
            // 
            // txt_yrid2
            // 
            this.txt_yrid2.Location = new System.Drawing.Point(116, 34);
            this.txt_yrid2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_yrid2.Name = "txt_yrid2";
            this.txt_yrid2.Size = new System.Drawing.Size(113, 20);
            this.txt_yrid2.TabIndex = 2;
            // 
            // btn_hm4
            // 
            this.btn_hm4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hm4.Location = new System.Drawing.Point(52, 330);
            this.btn_hm4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_hm4.Name = "btn_hm4";
            this.btn_hm4.Size = new System.Drawing.Size(56, 19);
            this.btn_hm4.TabIndex = 3;
            this.btn_hm4.Text = "home";
            this.btn_hm4.UseVisualStyleBackColor = false;
            this.btn_hm4.Click += new System.EventHandler(this.btn_hm4_Click);
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_hm4);
            this.Controls.Add(this.txt_yrid2);
            this.Controls.Add(this.lbl_yrid2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "customer";
            this.Text = "customer";
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_yrid2;
        private System.Windows.Forms.TextBox txt_yrid2;
        private System.Windows.Forms.Button btn_hm4;
    }
}