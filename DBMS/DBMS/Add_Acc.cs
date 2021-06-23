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
    public partial class Add_Acc : Form {
        public Add_Acc() {
            InitializeComponent();
        }
        //public static string user;
        //public static string pass;
        private void Add_button_Click(object sender, EventArgs e) {
            DBMain db = new DBMain();
            string query = "exec Add_Acc "+ userName_Textbox.Text + "," +passWord_Textbox.Text;
            db.ExecuteQueryDataSet(query, CommandType.Text);
            this.Close();
        }
    }
}
