
namespace StepTestLatestVersion
{
    partial class Form3
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.btnBackForm3 = new System.Windows.Forms.Button();
            this.textBoxMHR85 = new System.Windows.Forms.TextBox();
            this.lbl85MaxHR = new System.Windows.Forms.Label();
            this.textBoxAutoMHR = new System.Windows.Forms.TextBox();
            this.lblMaxHR = new System.Windows.Forms.Label();
            this.btnCalculateHR = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblNewParticipant = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnStartTest);
            this.panel3.Controls.Add(this.btnBackForm3);
            this.panel3.Controls.Add(this.textBoxMHR85);
            this.panel3.Controls.Add(this.lbl85MaxHR);
            this.panel3.Controls.Add(this.textBoxAutoMHR);
            this.panel3.Controls.Add(this.lblMaxHR);
            this.panel3.Controls.Add(this.btnCalculateHR);
            this.panel3.Controls.Add(this.textBoxAge);
            this.panel3.Controls.Add(this.textBoxLastName);
            this.panel3.Controls.Add(this.textBoxFirstName);
            this.panel3.Controls.Add(this.lblAge);
            this.panel3.Controls.Add(this.lblLastName);
            this.panel3.Controls.Add(this.lblFirstName);
            this.panel3.Controls.Add(this.lblNewParticipant);
            this.panel3.Location = new System.Drawing.Point(69, 229);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(724, 308);
            this.panel3.TabIndex = 4;
            // 
            // btnStartTest
            // 
            this.btnStartTest.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStartTest.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTest.ForeColor = System.Drawing.Color.Snow;
            this.btnStartTest.Location = new System.Drawing.Point(512, 234);
            this.btnStartTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(130, 39);
            this.btnStartTest.TabIndex = 13;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = false;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // btnBackForm3
            // 
            this.btnBackForm3.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackForm3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackForm3.ForeColor = System.Drawing.Color.White;
            this.btnBackForm3.Location = new System.Drawing.Point(25, 234);
            this.btnBackForm3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackForm3.Name = "btnBackForm3";
            this.btnBackForm3.Size = new System.Drawing.Size(151, 39);
            this.btnBackForm3.TabIndex = 12;
            this.btnBackForm3.Text = "Previous Page";
            this.btnBackForm3.UseVisualStyleBackColor = false;
            this.btnBackForm3.Click += new System.EventHandler(this.btnBackForm3_Click);
            // 
            // textBoxMHR85
            // 
            this.textBoxMHR85.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxMHR85.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.textBoxMHR85.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxMHR85.Location = new System.Drawing.Point(560, 136);
            this.textBoxMHR85.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMHR85.Name = "textBoxMHR85";
            this.textBoxMHR85.ReadOnly = true;
            this.textBoxMHR85.Size = new System.Drawing.Size(125, 27);
            this.textBoxMHR85.TabIndex = 11;
            this.textBoxMHR85.Text = "Auto Calculated";
            this.textBoxMHR85.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl85MaxHR
            // 
            this.lbl85MaxHR.AutoSize = true;
            this.lbl85MaxHR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl85MaxHR.Location = new System.Drawing.Point(410, 139);
            this.lbl85MaxHR.Name = "lbl85MaxHR";
            this.lbl85MaxHR.Size = new System.Drawing.Size(153, 20);
            this.lbl85MaxHR.TabIndex = 10;
            this.lbl85MaxHR.Text = "85% Max Heart Rate";
            // 
            // textBoxAutoMHR
            // 
            this.textBoxAutoMHR.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxAutoMHR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.textBoxAutoMHR.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxAutoMHR.Location = new System.Drawing.Point(558, 96);
            this.textBoxAutoMHR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAutoMHR.Name = "textBoxAutoMHR";
            this.textBoxAutoMHR.ReadOnly = true;
            this.textBoxAutoMHR.Size = new System.Drawing.Size(125, 27);
            this.textBoxAutoMHR.TabIndex = 9;
            this.textBoxAutoMHR.Text = "Auto Calculated";
            this.textBoxAutoMHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaxHR
            // 
            this.lblMaxHR.AutoSize = true;
            this.lblMaxHR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaxHR.Location = new System.Drawing.Point(412, 103);
            this.lblMaxHR.Name = "lblMaxHR";
            this.lblMaxHR.Size = new System.Drawing.Size(118, 20);
            this.lblMaxHR.TabIndex = 8;
            this.lblMaxHR.Text = "Max Heart Rate";
            // 
            // btnCalculateHR
            // 
            this.btnCalculateHR.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalculateHR.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateHR.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCalculateHR.Location = new System.Drawing.Point(407, 49);
            this.btnCalculateHR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculateHR.Name = "btnCalculateHR";
            this.btnCalculateHR.Size = new System.Drawing.Size(276, 43);
            this.btnCalculateHR.TabIndex = 7;
            this.btnCalculateHR.Text = "Calculate Predicted Heart Rate";
            this.btnCalculateHR.UseVisualStyleBackColor = false;
            this.btnCalculateHR.Click += new System.EventHandler(this.btnCalculateHR_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.textBoxAge.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxAge.Location = new System.Drawing.Point(130, 169);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(186, 27);
            this.textBoxAge.TabIndex = 6;
            this.textBoxAge.Text = "Enter Age Here";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.textBoxLastName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxLastName.Location = new System.Drawing.Point(130, 119);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(186, 27);
            this.textBoxLastName.TabIndex = 5;
            this.textBoxLastName.Text = "Enter Last Name Here";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxFirstName.Location = new System.Drawing.Point(131, 69);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(185, 27);
            this.textBoxFirstName.TabIndex = 4;
            this.textBoxFirstName.Text = "Enter First Name Here";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(23, 171);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 23);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblLastName.Location = new System.Drawing.Point(22, 122);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 23);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.Location = new System.Drawing.Point(23, 73);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 23);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblNewParticipant
            // 
            this.lblNewParticipant.AutoSize = true;
            this.lblNewParticipant.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lblNewParticipant.Location = new System.Drawing.Point(20, 24);
            this.lblNewParticipant.Name = "lblNewParticipant";
            this.lblNewParticipant.Size = new System.Drawing.Size(150, 25);
            this.lblNewParticipant.TabIndex = 0;
            this.lblNewParticipant.Text = "New Participant";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StepTestLatestVersion.Properties.Resources.BrookfieldImg1;
            this.pictureBox1.Location = new System.Drawing.Point(199, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelHeader.Location = new System.Drawing.Point(111, 196);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(571, 28);
            this.labelHeader.TabIndex = 6;
            this.labelHeader.Text = "Brookfield Fitness and Physiotherapy Step Test Application";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(869, 548);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Button btnBackForm3;
        private System.Windows.Forms.TextBox textBoxMHR85;
        private System.Windows.Forms.Label lbl85MaxHR;
        private System.Windows.Forms.TextBox textBoxAutoMHR;
        private System.Windows.Forms.Label lblMaxHR;
        private System.Windows.Forms.Button btnCalculateHR;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblNewParticipant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHeader;
    }
}