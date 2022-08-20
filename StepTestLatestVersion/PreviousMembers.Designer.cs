namespace StepTestLatestVersion
{
    partial class Previous_Members
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stepTestDatabaseDataSet = new StepTestLatestVersion.stepTestDatabaseDataSet();
            this.stepTestDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_PM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepTestDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepTestDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // stepTestDatabaseDataSet
            // 
            this.stepTestDatabaseDataSet.DataSetName = "stepTestDatabaseDataSet";
            this.stepTestDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stepTestDatabaseDataSetBindingSource
            // 
            this.stepTestDatabaseDataSetBindingSource.DataSource = this.stepTestDatabaseDataSet;
            this.stepTestDatabaseDataSetBindingSource.Position = 0;
            // 
            // btn_PM
            // 
            this.btn_PM.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_PM.Location = new System.Drawing.Point(48, 12);
            this.btn_PM.Name = "btn_PM";
            this.btn_PM.Size = new System.Drawing.Size(121, 35);
            this.btn_PM.TabIndex = 1;
            this.btn_PM.Text = "Previous Page";
            this.btn_PM.UseVisualStyleBackColor = false;
            this.btn_PM.Click += new System.EventHandler(this.btn_PM_Click);
            // 
            // Previous_Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_PM);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Previous_Members";
            this.Text = "Previous_Members";
            this.Load += new System.EventHandler(this.Previous_Members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepTestDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepTestDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stepTestDatabaseDataSetBindingSource;
        private stepTestDatabaseDataSet stepTestDatabaseDataSet;
        private System.Windows.Forms.Button btn_PM;
    }
}