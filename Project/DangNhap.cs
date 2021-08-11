using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void dangnhap()
        {
            String username = txttendangnhap.Text.Trim();
            String password = txtmatkhau.Text.Trim();
            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
                return;
            }
            DataTable dt = DBContext.GetDataBySQL($"SELECT * FROM tblTaiKhoan WHERE TTaiKhoan = '{username}'");
            if (dt == null)
            {
                MessageBox.Show("Tài khoản không tồn tại");
                return;
            }
            DataRow row = dt.Rows[0];
            if (!row["MatKhau"].ToString().Equals(password))
            {
                MessageBox.Show("Mật khẩu không đúng");
                return;
            }
            String value = row["Quanli"].ToString();
            bool isAdmin = row["Quanli"].ToString().Equals("True") ? true : false;
            Form1 frm = new Form1(isAdmin);
            frm.Show();
            this.Hide();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            dangnhap();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
