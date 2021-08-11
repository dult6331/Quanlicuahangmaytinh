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
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
            loadNgaythang();
            loaddata();
        }
        private void loadNgaythang()
        {
            DataTable dt = null;
            if (rdbHDB.Checked)
            {
                dt = DBContext.GetDataBySQL("SELECT FORMAT(Ngayban,'MM-yyyy') AS Ngaythang FROM tblHoadonban GROUP BY FORMAT(Ngayban,'MM-yyyy')");
            }
            else
            {
                dt = DBContext.GetDataBySQL(@"SELECT FORMAT(Ngaynhap,'MM-yyyy') AS Ngaythang FROM tblHoadonnhap GROUP BY FORMAT(Ngaynhap,'MM-yyyy')");
            }
            cboThangNam.DataSource = dt;
            cboThangNam.DisplayMember = "Ngaythang";
            cboThangNam.ValueMember = "Ngaythang";
        }
        private void loaddata()
        {
            String sql = "";
            String ngaythang = cboThangNam.SelectedValue as string;
            if (rdbHDB.Checked)
            {
                sql = $"SELECT a.MaHDB, MaNV, MaKH, Ngayban, Diachi, sdt, MaMT, Soluong, Giaban FROM (SELECT MaHDB, MaNV, MaKH, Ngayban, Diachi, sdt FROM tblHoadonban WHERE FORMAT(Ngayban,'MM-yyyy') = '{ngaythang}') AS a"
                        + @" INNER JOIN
                        tblThongTinHD AS b
                        ON a.MaHDB = b.MaHDB";
            }
            else
            {
                sql = $"SELECT * FROM tblHoadonnhap WHERE FORMAT(Ngaynhap,'MM-yyyy') = '{ngaythang}'";
            }
            dgvTimkiem.DataSource = DBContext.GetDataBySQL(sql);
        }
        private void rdbHDN_MouseClick(object sender, MouseEventArgs e)
        {
            rdbHDN.Checked = true;
            rdbHDB.Checked = false;
            loadNgaythang();
            loaddata();
        }

        private void rdbHDB_MouseClick(object sender, MouseEventArgs e)
        {
            rdbHDN.Checked = false;
            rdbHDB.Checked = true;
            loadNgaythang();
            loaddata();
        }

        private void cboThangNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
