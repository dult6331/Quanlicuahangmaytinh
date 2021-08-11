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
    public partial class Nhacungcap : Form
    {
        private DataTable nhacc = null;
        public Nhacungcap()
        {
            InitializeComponent();
            loaddata();
        }
        private void loaddata()
        {
            nhacc = DBContext.GetDataBySQL("SELECT * FROM [tblNhaCC]");
            dgvncc.DataSource = nhacc;
        }

        private void dgvncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow = e.RowIndex;
            DataRow row = nhacc.Rows[indexrow];
            String MaNCC = row["MaNCC"].ToString();
            String TenNCC = row["TenNCC"].ToString();
            String Diachi = row["Diachi"].ToString();
            String Sdt = row["Sdt"].ToString();

            txtmancc.Text = MaNCC;
            txtdiachi.Text = Diachi;
            txtsdt.Text = Sdt;
            txttenncc.Text = TenNCC;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            String MaNCC = txtmancc.Text;
            String TenNCC = txttenncc.Text;
            String Diachi = txtdiachi.Text;
            String Sdt = txtsdt.Text;

            String sql = @"INSERT INTO [dbo].[tblNhaCC]
                        ([MaNCC]
                        ,[TenNCC]
                        ,[Diachi]
                        ,[Sdt])
                      VALUES
                        ( @MaNCC
                        , @TenNCC
                        , @Diachi
                        , @Sdt)";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@MaNCC", SqlDbType.VarChar),
                new SqlParameter("@TenNCC", SqlDbType.NVarChar),
                new SqlParameter("@Diachi", SqlDbType.NVarChar),
                new SqlParameter("@Sdt", SqlDbType.VarChar)
            };
            param[0].Value = MaNCC;
            param[1].Value = TenNCC;
            param[2].Value = Diachi;
            param[3].Value = Sdt;

            DBContext.ExcuteSQL(sql, param);
            loaddata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            String MaNCC = txtmancc.Text;
            String TenNCC = txttenncc.Text;
            String Diachi = txtdiachi.Text;
            String Sdt = txtsdt.Text;

            String sql = @"UPDATE [dbo].[tblNhaCC]
                        SET 
		                [TenNCC] = @TenNCC
                        ,[Diachi] = @Diachi
                        ,[Sdt] = @Sdt
                        WHERE [MaNCC]=@MaNCC";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@MaNCC", SqlDbType.VarChar),
                new SqlParameter("@TenNCC", SqlDbType.NVarChar),
                new SqlParameter("@Diachi", SqlDbType.NVarChar),
                new SqlParameter("@Sdt", SqlDbType.VarChar)
            };
            param[0].Value = MaNCC;
            param[1].Value = TenNCC;
            param[2].Value = Diachi;
            param[3].Value = Sdt;

            DBContext.ExcuteSQL(sql, param);
            loaddata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            String MaNCC = txtmancc.Text.Trim();
            if (MaNCC.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã một nhà cung cấp");
                return;
            }
            String sql = "DELETE FROM [dbo].[tblNhaCC] WHERE MaNCC=@MaNCC";
            SqlParameter parameter = new SqlParameter("@MaNCC", SqlDbType.VarChar);
            parameter.Value = MaNCC;
            DBContext.ExcuteSQL(sql, parameter);
            loaddata();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmancc.Clear();
            txttenncc.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
            loaddata();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
