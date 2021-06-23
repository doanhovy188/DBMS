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
    public partial class Remove_Acc : Form {
        public Remove_Acc() {
            InitializeComponent();
        }

        private void Remove_Button_Click(object sender, EventArgs e) {
            DBMain db = new DBMain();
            string query = "exec Remove_Acc " + UserName_Textbox.Text;
            db.ExecuteQueryDataSet(query, CommandType.Text);
            this.Close();
        }
    }
}
