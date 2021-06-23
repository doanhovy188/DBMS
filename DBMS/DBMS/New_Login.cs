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
    public partial class New_Login : Form {
        public New_Login() {
            InitializeComponent();
        }
        private void Add_button_Click(object sender, EventArgs e) {
            DBMain db = new DBMain();
            string query = "CREATE LOGIN " + userName_Textbox.Text + " WITH PASSWORD = '" + passWord_Textbox.Text + "'";
            db.ExecuteQueryDataSet(query, CommandType.Text);
            string query2 = "use PhoneDBMS Create user " + userName_Textbox.Text + " for login " + userName_Textbox.Text;
            db.ExecuteQueryDataSet(query2, CommandType.Text);
            MessageBox.Show("Da tao login voi username =" + userName_Textbox.Text);
            this.Close();
        }
    }
}
