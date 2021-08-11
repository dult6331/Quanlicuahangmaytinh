using Microsoft.SqlServer.Server;
using Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLcuahangbanmaytinh
{
    public partial class frmhoadonban : Form
    {
        private DataTable hd = null;
        private DataTable kh = null;
        public frmhoadonban()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            LoadData();
        }
        public void LoadData()
        {
            DataTable hdb = DBContext.GetDataBySQL("SELECT * FROM [tblHoadonban]");
            DataTable ttmt = DBContext.GetDataBySQL("SELECT * FROM [tblThongtinMT]");
            dgvDShdb.DataSource = null;
            dgvDShdb.Columns.Clear();
            dgvDShdb.DataSource = hdb;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Xem";
            //btn.Name = "Xem";
            btn.Text = "Xem";
            btn.UseColumnTextForButtonValue = true;
            dgvDShdb.Columns.Add(btn);
            cbomamaytinh.DataSource = ttmt;
            cbomamaytinh.DisplayMember = "TenMT";
            cbomamaytinh.ValueMember = "MaMT";
            cboMaNV.DataSource = DBContext.GetDataBySQL("SELECT * FROM tblNhanVien");
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";
            kh = DBContext.GetDataBySQL("SELECT * FROM tblKhachhang");
            cbMaKH.DataSource = kh;
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.ValueMember = "MaKH";
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            this.txtmahoadonban.Clear();
            this.txtsodienthoai.Clear();
            this.txtdiachi.Clear();
            this.cbomamaytinh.SelectedIndex = 0;
            this.txtsoluong.Clear();
            this.dgvThongTinHD.DataSource=null;
            this.dgvThongTinHD.Columns.Clear();
            this.txtTongtien.Clear();
            this.dateTimePicker1.Value= DateTime.Now;
            LoadData();
        }

        private void xoahd(String MaHDB)
        {   String sql1 = "DELETE FROM tblThongTinHD WHERE MaHDB =@MaHDB";
            String sql = "DELETE FROM tblHoadonban WHERE MaHDB =@MaHDB";
            SqlParameter parameter = new SqlParameter("@MaHDB", SqlDbType.NVarChar);
            SqlParameter parameter1 = new SqlParameter("@MaHDB", SqlDbType.NVarChar);
            parameter.Value = MaHDB;
            parameter1.Value = MaHDB;
            DBContext.ExcuteSQL(sql1, parameter);
            DBContext.ExcuteSQL(sql, parameter1);

            
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            String MaHDB = txtmahoadonban.Text;
            xoahd(MaHDB);
            
            String manv = cboMaNV.Text;
            String makh = cbMaKH.Text;
            DateTime ngayban = dateTimePicker1.Value;
            String diachi = txtdiachi.Text;
            String sdt = txtsodienthoai.Text;
            String sql = @"INSERT INTO [dbo].[tblHoadonban]
                        ([MaHDB]
                        ,[MaNV]
                        ,[MaKH]
                        ,[Ngayban]
                        ,[Diachi]
                        ,[sdt])
                    VALUES
                        ( @MaHDB
                        , @MaNV
                        , @MaKH
                        , @Ngayban
                        , @Diachi
                        , @sdt)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@MaHDB", SqlDbType.VarChar),
                new SqlParameter("@MaNV", SqlDbType.VarChar),
                new SqlParameter("@MaKH", SqlDbType.VarChar),
                new SqlParameter("@Ngayban", SqlDbType.DateTime),
                new SqlParameter("@Diachi", SqlDbType.NVarChar),
                new SqlParameter("@sdt", SqlDbType.NVarChar)
            };
            param[0].Value = MaHDB;
            param[1].Value = manv;
            param[2].Value = makh;
            param[3].Value = ngayban;
            param[4].Value = diachi;
            param[5].Value = sdt;

            DBContext.ExcuteSQL(sql, param);

            String sql1 = @"INSERT INTO [dbo].[tblThongTinHD]
                            ([MaHDB]
                            ,[MaMT]
                            ,[Soluong]
                            ,[Giaban])
                        VALUES
                        ( @MaHDB
                        , @MaMT
                        , @Soluong
                        , @Giaban)";
            
            foreach (DataRow dr in hd.Rows)
            {
                SqlParameter[] param1 = new SqlParameter[]
               {
                new SqlParameter("@MaHDB", SqlDbType.VarChar),
                new SqlParameter("@MaMT", SqlDbType.VarChar),
                new SqlParameter("@Soluong", SqlDbType.Int),
                new SqlParameter("@Giaban", SqlDbType.Float)
               };
                param1[0].Value = MaHDB;
                param1[1].Value = dr["MaMT"].ToString();
                param1[2].Value = int.Parse(dr["SoLuong"].ToString());
                param1[3].Value = float.Parse(dr["DonGia"].ToString());
                DBContext.ExcuteSQL(sql1, param1);
            }
            LoadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmahoadonban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã hoá đơn");
                return;
            }
             DialogResult traloi;
             traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
             if (traloi == DialogResult.OK)
             {
                xoahd(txtmahoadonban.Text);
             }
            LoadData();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void dgvDShdb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>dgvDShdb.Rows.Count-2)
            {
                return;
            }
            this.dgvThongTinHD.DataSource = null;
            this.dgvThongTinHD.Columns.Clear();
            int index = e.RowIndex;
            String mahdb = dgvDShdb.Rows[index].Cells["MaHDB"].Value.ToString();
            
            hd = DBContext.GetDataBySQL($"SELECT od.MaMT AS MaMT, p.TenMT AS TenMT, od.Soluong AS SoLuong, od.Giaban AS DonGia FROM tblThongTinHD AS od INNER JOIN tblThongtinMT AS p ON od.MaMT= p.MaMT WHERE od.MaHDB ='{mahdb}'");
            dgvThongTinHD.DataSource = hd;
            
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Xoá";
            btn.Text = "Xoá";
            btn.UseColumnTextForButtonValue = true;
            dgvThongTinHD.Columns.Add(btn);


            String manv = dgvDShdb.Rows[index].Cells["MaNV"].Value.ToString();
            String makh = dgvDShdb.Rows[index].Cells["MaKH"].Value.ToString();
            DateTime ngayban = Convert.ToDateTime(dgvDShdb.Rows[index].Cells["Ngayban"].Value);
            String diachi = dgvDShdb.Rows[index].Cells["Diachi"].Value.ToString();
            String sdt = dgvDShdb.Rows[index].Cells["sdt"].Value.ToString();
            
            txtmahoadonban.Text = mahdb;
            cboMaNV.SelectedIndex = cboMaNV.FindStringExact(manv);
            cbMaKH.SelectedIndex = cbMaKH.FindStringExact(makh);
            dateTimePicker1.Value = ngayban;
            txtdiachi.Text = diachi;
            txtsodienthoai.Text = sdt;
            tinhtongtien();
        }
        private void tinhtongtien()
        {
            decimal sum = 0;
            int soluong = 0;
            decimal dongia = 0;
            foreach (DataRow item in hd.Rows)
            {
                dongia = Convert.ToDecimal(item["DonGia"].ToString());
                soluong = Convert.ToInt32(item["SoLuong"].ToString());
                sum = sum + dongia * soluong;
            }
            txtTongtien.Text = sum.ToString();
        }
        private void dgvThongTinHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= hd.Rows.Count)
            {
                return;
            }
            if (e.ColumnIndex == 4)
            {
                hd.Rows.RemoveAt(e.RowIndex);
                return;
            }
            int index = e.RowIndex;
            String mamaytinh = dgvThongTinHD.Rows[index].Cells["TenMT"].Value.ToString();
            cbomamaytinh.SelectedIndex = cbomamaytinh.FindStringExact(mamaytinh);
            String dongia = dgvThongTinHD.Rows[index].Cells["DonGia"].Value.ToString();
            String soluong = dgvThongTinHD.Rows[index].Cells["SoLuong"].Value.ToString();

            txtsoluong.Text = soluong;


            tinhtongtien();
            txtdongia.Text = dongia;



        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            String mamt = cbomamaytinh.SelectedValue.ToString();
            String tenmt = cbomamaytinh.Text;
            String dongia = txtdongia.Text;
            String soluong = txtsoluong.Text;
            bool check = true;
            for (int i = 0; i < hd.Rows.Count; i++)
            {
                if (hd.Rows[i]["MaMT"].ToString().Equals(mamt))
                {
                    check = false;
                    hd.Rows[i]["SoLuong"] = int.Parse(soluong);
                    hd.Rows[i]["DonGia"] = float.Parse(dongia);
                    break;
                }

            }
            if (check)
            {
                DataRow row;
                row = hd.NewRow();
                row["MaMT"] = mamt;
                row["TenMT"] = tenmt;
                row["DonGia"] = float.Parse(dongia);
                row["SoLuong"] = int.Parse(soluong);
                hd.Rows.Add(row);
            }
            tinhtongtien();
        }

        private void cbomamaytinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            String mamt = cbomamaytinh.SelectedValue.ToString();
            DataTable ttmts = DBContext.GetDataBySQL("SELECT * FROM [tblThongtinMT]");
            foreach (DataRow dr in ttmts.Rows)
            {
                if (dr["MaMT"].ToString().Equals(mamt))
                {
                    txtdongia.Text = dr["Giaban"].ToString();
                    txtsoluong.Text = "1";
                    return;
                }
            }
        }
    }

}
