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
    public partial class Phone_Num : Form {
        public Phone_Num() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            Form1.Num_phone = Phone_Num_Textbox.Text;
            this.Close();
        }
    }
}
