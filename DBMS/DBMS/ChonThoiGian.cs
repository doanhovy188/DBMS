using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class ChonThoiGian : Form
    {
        public ChonThoiGian()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DBMS.Program.formMain.nam = dateTimePicker1.Value.Year;
            DBMS.Program.formMain.thang = dateTimePicker1.Value.Month;
            Close();
        }
    }
}
