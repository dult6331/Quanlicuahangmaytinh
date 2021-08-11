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
    public partial class TKNhanVien : Form
    {
        private DataTable nhanvien = null;
        private DataTable dttbThongTinNhanVien = null;
        public TKNhanVien()
        {
            InitializeComponent();
            loaddata();
           // loadDataGridView();
        }
        private void loaddata()
        {
            nhanvien = DBContext.GetDataBySQL("SELECT * FROM [tblNhanVien]");
            dataGridView1.DataSource = nhanvien;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();lam
            string textSearch = textBox1.Text.Trim();
            dttbThongTinNhanVien = DBContext.GetDataBySQL("select * " +
                            " from tblNhanVien " +
                    "where MaNV like '%" + textSearch + "%' or TenNV like '%" + textSearch + "%'");
            dataGridView1.DataSource = dttbThongTinNhanVien;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow = e.RowIndex;
            DataRow row = nhanvien.Rows[indexrow];
            String Manv = row["MaNV"].ToString();
            String Tennv = row["TenNV"].ToString();
            String Diachi = row["Diachi"].ToString();
            String gioitinh = row["Gioitinh"].ToString();
            String Sdt = row["Sdt"].ToString();
            bool lamviec = (bool)row["Lamviec"];


            txtmanv.Text = Manv;
            txtdiachi.Text = Diachi;
            txtsdt.Text = Sdt;
            txttennv.Text = Tennv;
            txtGioiTinh.Text = gioitinh;
            cblamviec.Checked = lamviec;
        }

     
    }
}
