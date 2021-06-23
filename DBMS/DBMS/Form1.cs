using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class Form1 : Form
    {
        string connStr = "Data Source=(local);Initial Catalog = PHONEDBMS; Integrated Security = True";
        SqlCommand cmd = null;
        SqlConnection conn = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBMain db = new DBMain();
            string query = "select * from View_ChiTietGiaoDich";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query,CommandType.Text);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBMain db = new DBMain();
            string query = "select * from Accounts";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query,CommandType.Text);
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DBMain db = new DBMain();
            string query = "select * from Phone";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void showToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DBMain db = new DBMain();
            string query = "select * from Customer";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }
    }
}
