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
    public partial class ThemDienThoai : Form
    {
        public ThemDienThoai()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            DBMain db = new DBMain();
            if (tbxVanTay.Text != "Y" && tbxVanTay.Text != "y")
                tbxVanTay.Text = "No";
            else tbxVanTay.Text = "Yes";
            string query = "exec Them_Phone '" + tbxTen.Text + "', '" + tbxRam.Text + " GB', '" + tbxCamTruoc.Text + " MP', '"
                + tbxManHinh.Text + " inch', '" + cbbSim.Text + "','" + cbbMang.Text + "', '" + tbxGia.Text + "', '" + tbxVanTay.Text
                + "', '" + tbxBNT.Text + " GB', '" + tbxBNN.Text + " GB', '" + tbxCamSau.Text + "'";
            db.MyExecuteNonQuery(query, CommandType.Text);
            MessageBox.Show("Thêm điện thoại thành công");
            CleanForm();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxRam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void CleanForm()
        {
            foreach (var c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

        private void ThemDienThoai_Load(object sender, EventArgs e)
        {
            cbbMang.SelectedIndex = 0;
            cbbSim.SelectedIndex = 0;
        }
    }
}
