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
    public partial class Phone : Form {
        public Phone() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            Form1.name_phone = Phone_Textbox.Text;
            this.Close();
        }
    }
}
