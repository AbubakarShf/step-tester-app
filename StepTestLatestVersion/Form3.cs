using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StepTestLatestVersion
{

    public partial class Form3 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Pictures\StepTestLatestVersion\StepTestLatestVersion\StepTestLatestVersion\stepTestDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
        }

        private void btnBackForm3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnCalculateHR_Click(object sender, EventArgs e)
        {
            saveMember();
            int age;
            int numberOne = 220;
            int maxHR;
            if (int.TryParse(textBoxAge.Text, out age))
            {
                maxHR = numberOne - age;

                textBoxAutoMHR.Text = maxHR.ToString();
                textBoxMHR85.Text = (maxHR * 0.85).ToString();
            }
            else
            {
                MessageBox.Show("Not a valid number");
            }

            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxAge.Text == "")
            {
                MessageBox.Show("Please Insert Valid Data");
                textBoxFirstName.Focus();
            }
            else
            {
                saveMember();
            }

        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();

        }
        private void saveMember()
        {
            String Query = "INSERT INTO Member"+
                "(FirstName,LastName,Age)"+
                "VALUES(@FirstName,@LastName,@Age)";
            cmd=new SqlCommand(Query,conn);
            cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
            cmd.Parameters.AddWithValue("@Age", Int32.Parse(textBoxAge.Text));
            cmd.ExecuteNonQuery();

        }

    }
}
