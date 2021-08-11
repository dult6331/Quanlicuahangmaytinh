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
    public partial class Nhanvien : Form
    {
        private DataTable nhanvien = null;
        public Nhanvien()
        {
            InitializeComponent();
            loaddata();
        }
        private void loaddata()
        {
            nhanvien = DBContext.GetDataBySQL("SELECT * FROM [tblNhanVien]");
            dgvnhanvien.DataSource = nhanvien;
        }

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            txtgioitinh.Text = gioitinh;
            cblamviec.Checked = lamviec;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                String Manv = txtmanv.Text;
                String Tennv = txttennv.Text;
                String Diachi = txtdiachi.Text;
                String gioitinh = txtgioitinh.Text;
                String Sdt = txtsdt.Text;
                bool lamviec = cblamviec.Checked;

                String sql = @"INSERT INTO [dbo].[tblNhanVien]
                        ([MaNV]
                        ,[TenNV]
                        ,[Gioitinh]
                        ,[Diachi]
                        ,[Sdt]
                        ,[lamviec])
                      VALUES
                        ( @MaNV
                        , @TenNV
                        , @Gioitinh
                        , @Diachi
                        , @Sdt
                        , @Lamviec)";

                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@MaNV", SqlDbType.VarChar),
                new SqlParameter("@TenNV", SqlDbType.NVarChar),
                new SqlParameter("@Gioitinh", SqlDbType.NVarChar),
                new SqlParameter("@Diachi", SqlDbType.NVarChar),
                new SqlParameter("@Sdt", SqlDbType.VarChar),
                new SqlParameter("@Lamviec", SqlDbType.Bit)
                };
                param[0].Value = Manv;
                param[1].Value = Tennv;
                param[2].Value = gioitinh;
                param[3].Value = Diachi;
                param[4].Value = Sdt;
                param[5].Value = lamviec;
                DBContext.ExcuteSQL(sql, param);
                loaddata();
            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            String Manv = txtmanv.Text;
            String Tennv = txttennv.Text;
            String Diachi = txtdiachi.Text;
            String gioitinh = txtgioitinh.Text;
            String Sdt = txtsdt.Text;
            bool lamviec = cblamviec.Checked;

            String sql = @"UPDATE [dbo].[tblNhanVien]
                        SET 
		                [TenNV] = @TenNV
                        ,[Diachi] = @Diachi
                        ,[Gioitinh] = @Gioitinh
                        ,[Sdt] = @Sdt
                        ,[lamviec] = @lamviec
                        WHERE [MaNV]=@MaNV";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@MaNV", SqlDbType.VarChar),
                new SqlParameter("@TenNV", SqlDbType.NVarChar),
                new SqlParameter("@Gioitinh", SqlDbType.NVarChar),
                new SqlParameter("@Diachi", SqlDbType.NVarChar),
                new SqlParameter("@Sdt", SqlDbType.VarChar),
                new SqlParameter("@lamviec", SqlDbType.Bit)
            };
            param[0].Value = Manv;
            param[1].Value = Tennv;
            param[2].Value = gioitinh;
            param[3].Value = Diachi;
            param[4].Value = Sdt;
            param[5].Value = lamviec;

            DBContext.ExcuteSQL(sql, param);
            loaddata();
        }


        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmanv.Clear();
            txttennv.Clear();
            txtgioitinh.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
            loaddata();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
