namespace WindowsFormsApp1
{
    partial class trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trainer));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.traineridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbtrainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exampleDataSet = new WindowsFormsApp1.exampleDataSet();
            this.db_trainerTableAdapter = new WindowsFormsApp1.exampleDataSetTableAdapters.db_trainerTableAdapter();
            this.btn_hm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtrainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.traineridDataGridViewTextBoxColumn,
            this.trainernameDataGridViewTextBoxColumn,
            this.phnoDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn});
            this.dgv1.DataSource = this.dbtrainerBindingSource;
            this.dgv1.Location = new System.Drawing.Point(80, 49);
            this.dgv1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(416, 202);
            this.dgv1.TabIndex = 1;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // traineridDataGridViewTextBoxColumn
            // 
            this.traineridDataGridViewTextBoxColumn.DataPropertyName = "trainer_id";
            this.traineridDataGridViewTextBoxColumn.HeaderText = "trainer_id";
            this.traineridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.traineridDataGridViewTextBoxColumn.Name = "traineridDataGridViewTextBoxColumn";
            this.traineridDataGridViewTextBoxColumn.ReadOnly = true;
            this.traineridDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainernameDataGridViewTextBoxColumn
            // 
            this.trainernameDataGridViewTextBoxColumn.DataPropertyName = "trainer_name";
            this.trainernameDataGridViewTextBoxColumn.HeaderText = "trainer_name";
            this.trainernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainernameDataGridViewTextBoxColumn.Name = "trainernameDataGridViewTextBoxColumn";
            this.trainernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.trainernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phnoDataGridViewTextBoxColumn
            // 
            this.phnoDataGridViewTextBoxColumn.DataPropertyName = "ph_no";
            this.phnoDataGridViewTextBoxColumn.HeaderText = "ph_no";
            this.phnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phnoDataGridViewTextBoxColumn.Name = "phnoDataGridViewTextBoxColumn";
            this.phnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.phnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "specialization";
            this.specializationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            this.specializationDataGridViewTextBoxColumn.ReadOnly = true;
            this.specializationDataGridViewTextBoxColumn.Width = 125;
            // 
            // dbtrainerBindingSource
            // 
            this.dbtrainerBindingSource.DataMember = "db_trainer";
            this.dbtrainerBindingSource.DataSource = this.exampleDataSet;
            // 
            // exampleDataSet
            // 
            this.exampleDataSet.DataSetName = "exampleDataSet";
            this.exampleDataSet.Namespace = "http://tempuri.org/exampleDataSet.xsd";
            this.exampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_trainerTableAdapter
            // 
            this.db_trainerTableAdapter.ClearBeforeFill = true;
            // 
            // btn_hm2
            // 
            this.btn_hm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hm2.Location = new System.Drawing.Point(80, 294);
            this.btn_hm2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_hm2.Name = "btn_hm2";
            this.btn_hm2.Size = new System.Drawing.Size(75, 30);
            this.btn_hm2.TabIndex = 2;
            this.btn_hm2.Text = "HOME";
            this.btn_hm2.UseVisualStyleBackColor = true;
            this.btn_hm2.Click += new System.EventHandler(this.btn_hm2_Click);
            // 
            // trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_hm2);
            this.Controls.Add(this.dgv1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "trainer";
            this.Text = "trainer";
            this.Load += new System.EventHandler(this.trainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtrainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv1;
        private exampleDataSet exampleDataSet;
        private System.Windows.Forms.BindingSource dbtrainerBindingSource;
        private exampleDataSetTableAdapters.db_trainerTableAdapter db_trainerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn traineridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_hm2;
    }
}