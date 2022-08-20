using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StepTestLatestVersion
{
    public partial class Form2 : Form
    {

        public Form2()
        {
          
            InitializeComponent();
        }

        private void btnBackForm2_click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
        private void btnPreviousRecords_Click(object sender, EventArgs e)
        {
            Previous_Members previous_Members = new Previous_Members();
            previous_Members.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
