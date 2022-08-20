using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace StepTestLatestVersion
{
    public partial class Previous_Members : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        public Previous_Members()
        {
            InitializeComponent();
        }

        private void Previous_Members_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Pictures\StepTestLatestVersion\StepTestLatestVersion\StepTestLatestVersion\stepTestDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            getAllMember();
        }
        private void getAllMember()
        {
            cmd = new SqlCommand("select * from Member", conn);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btn_PM_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
