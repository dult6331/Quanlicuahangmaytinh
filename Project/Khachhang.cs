using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Khachhang : Form
    {
        private DataTable khachhang = null;
        public Khachhang()
        {
            InitializeComponent();
            loaddata();
        }
        private void loaddata()
        {
            khachhang = DBContext.GetDataBySQL("SELECT * FROM [tblKhachhang]");
            dgvkhachhang.DataSource = khachhang;
        }

        private void dgvkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow = e.RowIndex;
            DataRow row = khachhang.Rows[indexrow];
            String Makh = row["MaKH"].ToString();
            String Tenkh = row["TenKH"].ToString();
            String Diachi = row["Diachi"].ToString();
            String gioitinh = row["Gioitinh"].ToString();
            String Sdt = row["Sdt"].ToString();

            txtmakh.Text = Makh;
            txtdiachi.Text = Diachi;
            txtsdt.Text = Sdt;
            txttenkh.Text = Tenkh;
            txtgioitinh.Text = gioitinh;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            String Makh = txtmakh.Text;
            String Tenkh = txttenkh.Text;
            String Diachi = txtdiachi.Text;
            String gioitinh = txtgioitinh.Text;
            String Sdt = txtsdt.Text;

            String sql = @"INSERT INTO [dbo].[tblKhachhang]
                        ([MaKH]
                        ,[TenKH]
                        ,[Gioitinh]
                        ,[Diachi]
                        ,[Sdt])
                      VALUES
                        ( @MaKH
                        , @TenKH
                        , @Gioitinh
                        , @Diachi
                        , @Sdt)";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@MaKH", SqlDbType.VarChar),
                new SqlParameter("@TenKH", SqlDbType.NVarChar),
                new SqlParameter("@Gioitinh", SqlDbType.NVarChar),
                new SqlParameter("@Diachi", SqlDbType.NVarChar),
                new SqlParameter("@Sdt", SqlDbType.VarChar)
            };
            param[0].Value = Makh;
            param[1].Value = Tenkh;
            param[2].Value = gioitinh;
            param[3].Value = Diachi;
            param[4].Value = Sdt;

            DBContext.ExcuteSQL(sql, param);
            loaddata();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmakh.Clear();
            txttenkh.Clear();
            txtgioitinh.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
            loaddata();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            String Makh = txtmakh.Text;
            String Tenkh = txttenkh.Text;
            String Diachi = txtdiachi.Text;
            String gioitinh = txtgioitinh.Text;
            String Sdt = txtsdt.Text;

            String sql = @"UPDATE [dbo].[tblKhachhang]
                        SET 
		                [TenKH] = @TenKH
                        ,[Diachi] = @Diachi
                        ,[Gioitinh] = @Gioitinh
                        ,[Sdt] = @Sdt
                        WHERE [MaKH]=@MaKH";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@MaKH", SqlDbType.VarChar),
                new SqlParameter("@TenKH", SqlDbType.NVarChar),
                new SqlParameter("@Gioitinh", SqlDbType.NVarChar),
                new SqlParameter("@Diachi", SqlDbType.NVarChar),
                new SqlParameter("@Sdt", SqlDbType.VarChar)
            };
            param[0].Value = Makh;
            param[1].Value = Tenkh;
            param[2].Value = gioitinh;
            param[3].Value = Diachi;
            param[4].Value = Sdt;

            DBContext.ExcuteSQL(sql, param);
            loaddata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            String MaNV = txtmakh.Text.Trim();
            if (MaNV.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã một khách hàng");
                return;
            }
            String sql = "DELETE FROM [dbo].[tblKhachhang] WHERE MaKH=@MaKH";
            SqlParameter parameter = new SqlParameter("@MaKH", SqlDbType.VarChar);
            parameter.Value = MaNV;
            DBContext.ExcuteSQL(sql, parameter);
            loaddata();
        }
    }
}
