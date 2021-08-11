using QLcuahangbanmaytinh;
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
    public partial class Form1 : Form
    {
        private bool isAdmin = false;
        public Form1(bool isAdmin)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                tatTinhNang();
            }
        }

        private void tatTinhNang()
        {
            thốngKêToolStripMenuItem.Enabled = false;
            thôngTinMáyTínhToolStripMenuItem.Enabled = false;
            thôngTinNhânViênToolStripMenuItem.Enabled = false;
            thôngTinNhàCungCấpToolStripMenuItem.Enabled = false;
            hóaĐơnNhậpToolStripMenuItem.Enabled = false;
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hoadonnhap frm = new hoadonnhap();
            frm.MdiParent = this;
            // hiển thị form con
            frm.Show();
        }

        private void thôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhacungcap frm = new Nhacungcap();
            frm.MdiParent = this;
            // hiển thị form con
            frm.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // khởi tạo form con
            frmhoadonban frm = new frmhoadonban();
            //gán form con vào trong form cha
            frm.MdiParent = this;
            // hiển thị form con
            frm.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien frm = new Nhanvien();
            frm.MdiParent = this;
            // hiển thị form con
            frm.Show();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khachhang frm = new Khachhang();
            frm.MdiParent = this;
            // hiển thị form con
            frm.Show();
        }

        private void thôngTinMáyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongtinmaytinh frm = new Thongtinmaytinh();
            frm.MdiParent = this;
            // hiển thị form con
            frm.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongke frm = new Thongke();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TKNhanVien frm = new TKNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thôngTinNhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TKNhacungcap frm = new TKNhacungcap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quayLaijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap frm = new DangNhap();
            frm.Show();
            this.Hide();
        }

        private void thôngTinKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TKKhachHang frm = new TKKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thôngTinMáyTínhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimKiemThongTinMayTinh frm = new TimKiemThongTinMayTinh();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
