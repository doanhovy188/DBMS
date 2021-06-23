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
    public partial class RamCheap : Form {
        public RamCheap() {
            InitializeComponent();
        }
        
        private void OK_Button_Click(object sender, EventArgs e) {
            Form1.Ram = Ram_Textbox.Text;
            this.Close();
        }
    }
}
