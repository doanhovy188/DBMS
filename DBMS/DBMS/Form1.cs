using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS {
    public partial class Form1 : Form {
        DBMain db = new DBMain();
        public Form1() {
            InitializeComponent();
        }
        public static string Ram;
        public static string NhanVien;
        public static string price;
        public static string name_phone;
        public static string Num_phone;
        private void label1_Click(object sender, EventArgs e) {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //string query = "set dateformat ymd select * from View_ChiTietGiaoDich";
            //dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e) {
            string query = "select * from View_ListNhanVien";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e) {
            string query = "select * from Phone";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void showToolStripMenuItem2_Click(object sender, EventArgs e) {
            string query = "select * from Customer";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void bánChạyToolStripMenuItem_Click(object sender, EventArgs e) {
            string query = "select * from Dien_Thoai_Ban_Chay_Hang_Thang";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void ramGiáTốtToolStripMenuItem_Click(object sender, EventArgs e) {
            RamCheap ramCheap = new RamCheap();
            ramCheap.ShowDialog();
            string query = "select * from sp_RamManhGiaRe ('" + Ram + " GB')";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void khôngBánĐượcToolStripMenuItem_Click(object sender, EventArgs e) {
            DateTime dateTime = DateTime.Now;
            string query = "exec Dien_Thoai_Chua_Ban_Duoc_Trong_Thang_Nam " + dateTime.Month + "," + dateTime.Year;
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void xuấtSắcNhấtCácThángToolStripMenuItem_Click(object sender, EventArgs e) {
            string query = "select * from Nhan_Vien_Xuat_Sac";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void kháchHàngThânThiếtToolStripMenuItem_Click(object sender, EventArgs e) {
            string query = "select * from View_top3_KH_Nap_Nhieu order by total_money_Spent desc";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            Add_Acc add_Acc = new Add_Acc();
            add_Acc.ShowDialog();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e) {
            Remove_Acc remove_Acc = new Remove_Acc();
            remove_Acc.ShowDialog();
        }

        private void rogPhoneBánĐượcthángToolStripMenuItem_Click(object sender, EventArgs e) {
            string query = "select * from View_Tong_ROG_Ban_Trong_Thang";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void giaoDịchthángToolStripMenuItem_Click(object sender, EventArgs e) {
            DateTime dateTime = DateTime.Now;
            Name_Check name_Check = new Name_Check();
            name_Check.ShowDialog();
            string query = "declare @sum_trans_on_emp int exec sp_Tong_So_GD_on_emps_by_Date '"+NhanVien+"','" + dateTime.Year + "/" + dateTime.Month + "/" + dateTime.Day + "',@sum_trans_on_emp out select @sum_trans_on_emp as 'Tổng số giao dịch'";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void điệnThoạiGiáRẻHơnToolStripMenuItem_Click(object sender, EventArgs e) {
            Price pricess = new Price();
            pricess.ShowDialog();
            string query = "select * from func_MauDTcoGiaDuoi ('"+price+"')";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void điệnThoạiGiáĐắtHơnToolStripMenuItem_Click(object sender, EventArgs e) {
            Price pricess = new Price();
            pricess.ShowDialog();
            string query = "select * from func_MauDTcoGiaTren ('" + price + "')";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void tìmKháchHàngQuaTênĐtToolStripMenuItem_Click(object sender, EventArgs e) {
            Phone phone = new Phone();
            phone.ShowDialog();
            string query = "select * from func_AiDaMuaDt ('" + name_phone + "')";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void tìmKháchHàngQuaSdtToolStripMenuItem_Click(object sender, EventArgs e) {
            Phone_Num phone_numm = new Phone_Num();
            phone_numm.ShowDialog();
            string query = "select * from Tim_Khach_Hang ('" + Num_phone + "')";
            dataGridView1.DataSource = db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        private void thêmUserToolStripMenuItem_Click(object sender, EventArgs e) {
            New_Login new_Login = new New_Login();
            new_Login.ShowDialog();
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e) {
            Grant grant = new Grant();
            grant.ShowDialog();
        }

        private void xoáPhânQuyềnToolStripMenuItem_Click(object sender, EventArgs e) {
            Revoke revoke = new Revoke();
            revoke.ShowDialog();
        }

        private void thêmĐiệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemDienThoai themDienThoai = new ThemDienThoai();
            themDienThoai.ShowDialog();
        }
    }
}
