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
    public partial class Thongtinmaytinh : Form
    {
        private DataTable thongtinmt = null;
        private DataTable nhacc = null;
        public Thongtinmaytinh()
        {
            InitializeComponent();
            loaddata();
        }
        private void loaddata()
        {
            thongtinmt = DBContext.GetDataBySQL("SELECT * FROM [tblThongtinMT]");
            dgvmaytinh.DataSource = thongtinmt;
            nhacc= DBContext.GetDataBySQL("SELECT MaNCC, TenNCC FROM tblNhaCC");
            //load data vao combobox
            cbomancc.DataSource = nhacc;

            cbomancc.DisplayMember = "TenNCC"; // set ten hien thi o combox
            cbomancc.ValueMember = "MaNCC";   //  
        }

        private Boolean checkMaMT(String MaNCC)
        {
            DataTable temp = DBContext.GetDataBySQL($"SELECT * FROM tblThongtinMT WHERE MaMT='{MaNCC}'");
            return temp.Rows.Count == 1; // neu có thì gửi về true, ngược lại gửi về false
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmamaytinh.Clear();
            txttenmaytinh.Clear();
            txtsoluong.Clear();
            txtgiaban.Clear();
            loaddata();
        }

        private void dgvmaytinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow = e.RowIndex;
            DataRow row = thongtinmt.Rows[indexrow];
            String MaMT = row["MaMT"].ToString();
            String TenMT = row["TenMT"].ToString();
            String MaNCC = row["MaNCC"].ToString();
            String Soluong = row["Soluong"].ToString();
            String Giaban = row["Giaban"].ToString();
            
            txtmamaytinh.Text = MaMT;
            txttenmaytinh.Text = TenMT;
            int index = 0;
            for (int i = 0; i < nhacc.Rows.Count; i++)
            {
                if (nhacc.Rows[i]["MaNCC"].ToString().Equals(MaNCC))
                {
                    index = i;
                    break;
                }
            }
            cbomancc.SelectedIndex = index;
            txtsoluong.Text = Soluong;
            txtgiaban.Text = Giaban;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {


            String MaMT = txtmamaytinh.Text.Trim();
            if (MaMT.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã một máy tính ");
                return;
            }
            // delete form tblThongTinHD
            String sql = "DELETE FROM [dbo].[tblThongTinHD] WHERE MaMT=@MaMT";
            SqlParameter parameter = new SqlParameter("@MaMT", SqlDbType.VarChar);
            parameter.Value = MaMT;
            DBContext.ExcuteSQL(sql, parameter);

            // delete form tblHoadonnhap
            String sql2 = "DELETE FROM [dbo].[tblHoadonnhap] WHERE MaMT=@MaMT";
            SqlParameter parameter2 = new SqlParameter("@MaMT", SqlDbType.VarChar);
            parameter2.Value = MaMT;
            DBContext.ExcuteSQL(sql2, parameter2);
            
            // delete form tblThongtinMT
            String sql1 = "DELETE FROM [dbo].[tblThongtinMT] WHERE MaMT=@MaMT";
            SqlParameter parameter1 = new SqlParameter("@MaMT", SqlDbType.VarChar);
            parameter1.Value = MaMT;
            DBContext.ExcuteSQL(sql1, parameter1);
            loaddata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            String mamt = txtmamaytinh.Text;
            bool check = checkMaMT(mamt);
            if (check)
            {
                String Mamt = txtmamaytinh.Text;
                String Tenmt = txttenmaytinh.Text;
                String soluong = txtsoluong.Text;
                String gia = txtgiaban.Text;
                String manhacc = cbomancc.SelectedValue.ToString();

                String sql = @"UPDATE [dbo].[tblThongtinMT]
                        SET 
		                [TenMT] = @TenMT
                        ,[MaNCC] = @MaNCC
                        ,[Soluong] = @Soluong
                        ,[Giaban] = @Giaban
                        WHERE [MaMT]=@MaMT";

                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@MaMT", SqlDbType.VarChar),
                    new SqlParameter("@TenMT", SqlDbType.NVarChar),
                    new SqlParameter("@MaNCC", SqlDbType.NVarChar),
                    new SqlParameter("@Soluong", SqlDbType.NVarChar),
                    new SqlParameter("@Giaban", SqlDbType.VarChar)
                };
                param[0].Value = Mamt;
                param[1].Value = Tenmt;
                param[2].Value = manhacc;
                param[3].Value = soluong;
                param[4].Value = gia;

                DBContext.ExcuteSQL(sql, param);
                loaddata();
            }
            else
            {
                MessageBox.Show("Mã máy tính chưa có trong data vui lòng nhập mã khác");
            }
                
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            String mamt = txtmamaytinh.Text;
            bool check = checkMaMT(mamt);
            if (check)
            {
                MessageBox.Show("Mã máy tính đã có trong data vui lòng nhập mã khác");
            }
            else
            {
                String Mamt = txtmamaytinh.Text;
                String Tenmt = txttenmaytinh.Text;
                String soluong = txtsoluong.Text;
                String gia = txtgiaban.Text;
                String manhacc = cbomancc.SelectedValue.ToString();

                String sql = @"INSERT INTO [dbo].[tblThongtinMT]
                        ([MaMT]
                        ,[TenMT]
                        ,[MaNCC]
                        ,[Soluong]
                        ,[Giaban])
                      VALUES
                        ( @MaMT
                        , @TenMT
                        , @MaNCC
                        , @Soluong
                        , @Giaban)";

                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@MaMT", SqlDbType.VarChar),
                    new SqlParameter("@TenMT", SqlDbType.NVarChar),
                    new SqlParameter("@MaNCC", SqlDbType.NVarChar),
                    new SqlParameter("@Soluong", SqlDbType.NVarChar),
                    new SqlParameter("@Giaban", SqlDbType.VarChar)
                };
                param[0].Value = Mamt;
                param[1].Value = Tenmt;
                param[2].Value = manhacc;
                param[3].Value = soluong;
                param[4].Value = gia;

                DBContext.ExcuteSQL(sql, param);
                loaddata();
            }

        }
    }
}
