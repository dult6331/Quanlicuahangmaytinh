using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using ClosedXML.Excel;

namespace Project
{
    public partial class hoadonnhap : Form
    {
        DBContext data = new DBContext();
        DataTable dttbhoaDonNhap = null;
        String pathImport = "";
        XLWorkbook workbook ;
        public hoadonnhap()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {   setDataForcbMaMayTinh();
            setDataFordgvHoaDonNhap();
            setDataForcbMaNhanVien();
            txtmahoadonnhap.Text = "";
            txtsoluong.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtdiachi.Text = "";
            txtsodienthoai.Text = "";
            txtGiaNhap.Text = "";
            
            cboMaNV.SelectedIndex = 0;
        }

        private void setDataForcbMaNhaCungCap(String MaMT)
        {
            DataTable dt = DBContext.GetDataBySQL($"SELECT * FROM tblNhaCC AS c JOIN tblThongtinMT AS m ON m.MaNCC = c.MaNCC WHERE MaMT = '{MaMT}'");
            DataRow row = dt.Rows[0];
            txtNhaCC.Text = row["TenNCC"].ToString();
        }

        private void setDataForcbMaMayTinh()
        {
            DataTable dt = DBContext.GetDataBySQL("select * from tblThongtinMT");
            cbomamaytinh.DataSource = dt;
            // add indexchange event for prevent firing after change datasoucre
            this.cbomamaytinh.SelectedIndexChanged += new System.EventHandler(this.cbomamaytinh_SelectedIndexChanged);
            cbomamaytinh.DisplayMember = "TenMT";
            cbomamaytinh.ValueMember = "MaMT";
            cbomamaytinh.SelectedIndex = 0;
        }

        private void setDataForcbMaNhanVien()
        {
            cboMaNV.DataSource = DBContext.GetDataBySQL("select * from tblNhanVien");
            cboMaNV.DisplayMember = "TenNV";
            cboMaNV.ValueMember = "MaNV";
        }

        private void setDataFordgvHoaDonNhap()
        {
            String sql = @"SELECT MaHDN, MaNV, a.MaNCC, a.TenNCC , n.MaMT, a.TenMT, Soluong, Gianhap, Soluong*Gianhap AS TongTien, Ngaynhap, Diachi, Sdt FROM tblHoadonnhap AS n
                           JOIN
                           (SELECT MaMT, TenMT, m.MaNCC, TenNCC FROM tblThongtinMT AS m JOIN tblNhaCC AS c ON m.MaNCC = c.MaNCC) AS a
                           ON n.MaMT = a.MaMT";
            dttbhoaDonNhap = DBContext.GetDataBySQL(sql);
            dgvHoaDonNhap.DataSource = dttbhoaDonNhap;
        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex <= dgvHoaDonNhap.Rows.Count - 2 && e.RowIndex>-1)
            {
                int id = e.RowIndex;
                txtmahoadonnhap.Text = dttbhoaDonNhap.Rows[id].ItemArray[0].ToString();
                cboMaNV.SelectedValue = dttbhoaDonNhap.Rows[id].ItemArray[1].ToString();
                cbomamaytinh.SelectedValue = dttbhoaDonNhap.Rows[id].ItemArray[4].ToString();
                txtsoluong.Text = dttbhoaDonNhap.Rows[id].ItemArray[6].ToString();
                dateTimePicker1.Value = DateTime.Parse(dttbhoaDonNhap.Rows[id].ItemArray[9].ToString());
                txtdiachi.Text = dttbhoaDonNhap.Rows[id].ItemArray[10].ToString();
                txtsodienthoai.Text = dttbhoaDonNhap.Rows[id].ItemArray[11].ToString();
                txtGiaNhap.Text = dttbhoaDonNhap.Rows[id].ItemArray[7].ToString();
            }
            else
            {
                LoadData();
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    String sql = "INSERT INTO[dbo].[tblHoadonnhap]" +
            //                 "       ([MaHDN]                 " +
            //                 "      ,[MaNV]" +
            //                 "      ,[MaMT]" +
            //                 "      ,[Soluong]" +
            //                 "      ,[Ngaynhap]" +
            //                 "      ,[Diachi]" +
            //                 "      ,[Sdt]" +
            //                 "      ,[Gianhap])" +
            //                 "VALUES" +
            //                 "      (< MaHDN, '00007X',>" +
            //                 "      ,< MaNV, 'NV01',>" +
            //                 "      ,< MaMT, 'MT1',>" +
            //                 "      ,< Soluong, 1,>" +
            //                 "      ,< Ngaynhap, '2021-04-27',>" +
            //                 "      ,< Diachi, 'Ha Noi',>" +
            //                 "      ,< Sdt, '1203984756',>" +
            //                 "      ,< Gianhap, 1000000,>)";
            //    SqlParameter[] param = new SqlParameter[]{};
            //    int u=DBContext.ExcuteSQL(sql, param);
            //    setDataFordgvHoaDonNhap();
            //    MessageBox.Show(" Add success : "+u);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show(" Add Fail ");
            //}

            try
            {
                String maHoaDonNhap = txtmahoadonnhap.Text;
                String maNhanVien = cboMaNV.SelectedValue.ToString();
                String maMayTinh = cbomamaytinh.SelectedValue.ToString();
                int soLuong = int.Parse(txtsoluong.Text);
                DateTime ngayNhap = dateTimePicker1.Value;
                String diaChi = txtdiachi.Text;
                String soDienThoai = txtsodienthoai.Text;
                float giaNhap = float.Parse(txtGiaNhap.Text);

                String sql = "insert into tblHoadonnhap Values(@maHoaDonNhap, " +
                            " @maNhanVien, " +
                            " @maMayTinh, " +
                            " @soLuong, " +
                            " @ngayNhap, " +
                            " @diaChi, " +
                            " @soDienThoai, " +
                            " @giaNhap)";

                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@maHoaDonNhap", SqlDbType.VarChar),
                new SqlParameter("@maNhanVien", SqlDbType.VarChar),
                new SqlParameter("@maMayTinh", SqlDbType.VarChar),
                new SqlParameter("@soLuong", SqlDbType.Int),
                new SqlParameter("@ngayNhap", SqlDbType.DateTime),
                new SqlParameter("@diaChi", SqlDbType.NVarChar),
                new SqlParameter("@soDienThoai", SqlDbType.NVarChar),
                new SqlParameter("@giaNhap", SqlDbType.Float),
                };

                param[0].Value = maHoaDonNhap;
                param[1].Value = maNhanVien;
                param[2].Value = maMayTinh;
                param[3].Value = soLuong;
                param[4].Value = ngayNhap;
                param[5].Value = diaChi;
                param[6].Value = soDienThoai;
                param[7].Value = giaNhap;

                DBContext.ExcuteSQL(sql, param);
                MessageBox.Show(" Add success ");
                setDataFordgvHoaDonNhap();
            }
            catch
            {
                MessageBox.Show(" Add Fail ");
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                String maHoaDonNhap = txtmahoadonnhap.Text;
                String maNhanVien = cboMaNV.SelectedValue.ToString();
                String maMayTinh = cbomamaytinh.SelectedValue.ToString();
                int soLuong = int.Parse(txtsoluong.Text);
                DateTime ngayNhap = dateTimePicker1.Value;
                String diaChi = txtdiachi.Text;
                String soDienThoai = txtsodienthoai.Text;
                float giaNhap = float.Parse(txtGiaNhap.Text);

                String sql = "UPDATE  tblHoadonnhap Set " +
                            " MaHDN=@maHoaDonNhap, " +
                            " MaNV=@maNhanVien, " +
                            " MaMT=@maMayTinh, " +
                            " Soluong=@soLuong, " +
                            " Ngaynhap=@ngayNhap, " +
                            " Diachi=@diaChi, " +
                            " Sdt=@soDienThoai, " +
                            " Gianhap=@giaNhap " +
                            " Where MaHDN=@maHoaDonNhap ";

                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@maHoaDonNhap", SqlDbType.VarChar),
                new SqlParameter("@maNhanVien", SqlDbType.VarChar),
                new SqlParameter("@maMayTinh", SqlDbType.VarChar),
                new SqlParameter("@soLuong", SqlDbType.Int),
                new SqlParameter("@ngayNhap", SqlDbType.DateTime),
                new SqlParameter("@diaChi", SqlDbType.NVarChar),
                new SqlParameter("@soDienThoai", SqlDbType.NVarChar),
                new SqlParameter("@giaNhap", SqlDbType.Float),
                };

                param[0].Value = maHoaDonNhap;
                param[1].Value = maNhanVien;
                param[2].Value = maMayTinh;
                param[3].Value = soLuong;
                param[4].Value = ngayNhap;
                param[5].Value = diaChi;
                param[6].Value = soDienThoai;
                param[7].Value = giaNhap;

                DBContext.ExcuteSQL(sql, param);
                MessageBox.Show(" Update success ");
                setDataFordgvHoaDonNhap();
            }
            catch
            {
                MessageBox.Show(" Update Fail ");
            }
        }


        private void btnlammoi_MouseClick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbomamaytinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            String MaMT = cbomamaytinh.SelectedValue.ToString();
            setDataForcbMaNhaCungCap(MaMT);
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dttbhoaDonNhap.Rows.Count > 1)
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i <= dttbhoaDonNhap.Columns.Count; ++i)
                {
                    excelApp.Cells[1, i] = dttbhoaDonNhap.Columns[i - 1].ColumnName;
                }

                for (int i = 0; i < dttbhoaDonNhap.Rows.Count - 1; ++i)
                {
                    for (int j = 0; j < dttbhoaDonNhap.Columns.Count; ++j)
                    {
                        excelApp.Cells[i + 2, j + 1] = dttbhoaDonNhap.Rows[i].ItemArray[j].ToString();
                    }
                }
                excelApp.Columns.AutoFit();
                excelApp.Visible = true;
            }
            else{
                MessageBox.Show("Dont have data", "Message");
            }
        }

        private void btnImportToExcel_Click(object sender, EventArgs e)
        {
            using ( OpenFileDialog ofd=new OpenFileDialog() { Filter= "Excel Sheet (*.xlsx)|*.xlsx|All Files(*.*)|*.*", Multiselect=false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    
                    pathImport = ofd.FileName;
                    //Cursor.Current = Cursors.WaitCursor;
                    workbook = new XLWorkbook(pathImport);
                    
                    
                    for(int i=1;i<workbook.Worksheets.Count; ++i)
                    {
                        cbbSheet.Items.Add(workbook.Worksheet(i).Name);
                    }
                    cbbSheet.SelectedIndex = 0;
                    cbbSheet.Visible = true;
                    
                }
            }
        }

        private void cbbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSaveExcelToSql.Visible = true;
            ComboBox comboBox=sender as ComboBox;
            var rows = workbook.Worksheet(comboBox.SelectedIndex+1).RowsUsed();
            DataTable table = new DataTable();
            bool isFirstRow = true;
            foreach (var row in rows)
            {
                if (isFirstRow)
                {
                    foreach (IXLCell cell in row.Cells())
                    {
                        table.Columns.Add(cell.Value.ToString());
                    }
                    isFirstRow = false;
                }
                else
                {
                    table.Rows.Add();
                    int i = 0;
                    foreach (IXLCell cell in row.Cells())
                    {
                        table.Rows[table.Rows.Count - 1][i] = cell.Value.ToString();
                        ++i;
                    }
                }
            }
            dgvHoaDonNhap.DataSource = table;
        }

        private void txtSaveExcelToSql_Click(object sender, EventArgs e)
        {
            int numberInsert = 0;
            foreach ( DataGridViewRow row in dgvHoaDonNhap.Rows)
            {
                if (row.Cells[0].Value == null) continue;
                string sql1 = "select MaHDN,MaNV from tblHoadonnhap where MaHDN = '"+row.Cells[0].Value + "' and MaNV='"+ row.Cells[1].Value + "'";
                DataTable dataTable = DBContext.GetDataBySQL(sql1);
                if (dataTable.Rows.Count == 0 )
                {
                    try
                    {
                        Console.WriteLine(numberInsert);
                        String maHoaDonNhap = row.Cells[0].Value.ToString();
                        String maNhanVien = row.Cells[1].Value.ToString();
                        String maMayTinh = row.Cells[4].Value.ToString();
                        int soLuong = int.Parse(row.Cells[6].Value.ToString());
                        DateTime ngayNhap = DateTime.Parse(row.Cells[9].Value.ToString());
                        String diaChi = row.Cells[10].Value.ToString();
                        String soDienThoai = row.Cells[11].Value.ToString();
                        float giaNhap = float.Parse(row.Cells[7].Value.ToString());

                        String sql = "insert into tblHoadonnhap Values('"+maHoaDonNhap+"', " +
                                    " '"+maNhanVien+"', " +
                                    " '"+maMayTinh+"', " +
                                    " "+soLuong+", " +
                                    " '"+ngayNhap.Date+"', " +
                                    " '"+diaChi+"', " +
                                    " '"+soDienThoai+"', " +
                                    " "+giaNhap+")";

                                SqlParameter[] param = new SqlParameter[]
                                {
                                   
                                 };
                                DBContext.ExcuteSQL(sql, param);
                                ++numberInsert;
                    }
                    catch
                    {
                        MessageBox.Show(" Add Fail ");
                    }
                }
            }
            MessageBox.Show(numberInsert + " dữ liệu đã được lưu ");
        }
    }

}
