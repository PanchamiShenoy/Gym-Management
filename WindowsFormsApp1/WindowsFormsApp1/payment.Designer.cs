namespace WindowsFormsApp1
{
    partial class payment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.lbl_yrid3 = new System.Windows.Forms.Label();
            this.txt_yrid3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_hm3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_yrid3
            // 
            this.lbl_yrid3.AutoSize = true;
            this.lbl_yrid3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_yrid3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yrid3.Location = new System.Drawing.Point(36, 39);
            this.lbl_yrid3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_yrid3.Name = "lbl_yrid3";
            this.lbl_yrid3.Size = new System.Drawing.Size(59, 13);
            this.lbl_yrid3.TabIndex = 0;
            this.lbl_yrid3.Text = "YOUR ID";
            // 
            // txt_yrid3
            // 
            this.txt_yrid3.Location = new System.Drawing.Point(108, 36);
            this.txt_yrid3.Margin = new System.Windows.Forms.Padding(2);
            this.txt_yrid3.Name = "txt_yrid3";
            this.txt_yrid3.Size = new System.Drawing.Size(134, 20);
            this.txt_yrid3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(472, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_hm3
            // 
            this.btn_hm3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_hm3.Location = new System.Drawing.Point(39, 298);
            this.btn_hm3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hm3.Name = "btn_hm3";
            this.btn_hm3.Size = new System.Drawing.Size(81, 21);
            this.btn_hm3.TabIndex = 3;
            this.btn_hm3.Text = "home";
            this.btn_hm3.UseVisualStyleBackColor = true;
            this.btn_hm3.Click += new System.EventHandler(this.btn_hm3_Click);
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_hm3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_yrid3);
            this.Controls.Add(this.lbl_yrid3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_yrid3;
        private System.Windows.Forms.TextBox txt_yrid3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_hm3;
    }
}