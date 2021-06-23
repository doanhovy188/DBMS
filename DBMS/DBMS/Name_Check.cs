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
    public partial class Name_Check : Form {
        public Name_Check() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form1.NhanVien = Name_Textbox.Text;
            this.Close();
        }
    }
}
