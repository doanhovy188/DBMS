using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS {
    public partial class Revoke : Form {
        public Revoke() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DBMain db = new DBMain();
            string query = "revoke select, insert on Customer to " + textBox1.Text + " revoke select, insert on Accounts to " + textBox1.Text +
                " revoke select, insert on Phone to " + textBox1.Text + " revoke select, insert on Transactions to " + textBox1.Text + " revoke select, insert on Transaction_Details to " + textBox1.Text;
            db.ExecuteQueryDataSet(query, CommandType.Text);
            MessageBox.Show("Revoked select,insert on PhoneDB for " + textBox1.Text);
            this.Close();
        }
    }
}
