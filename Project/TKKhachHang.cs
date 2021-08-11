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
    public partial class TKKhachHang : Form
    {
        private DataTable dttbThongTinKH = null;
        public TKKhachHang()
        {
            InitializeComponent();
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            dataGridView1.Columns.Add("MaKH", "Mã khách hàng");
            dataGridView1.Columns.Add("TenKH", "Tên Nhà Cung Cấp");
            dataGridView1.Columns.Add("Gioitinh", "Giới tính");
            dataGridView1.Columns.Add("Diachi", "Địa chỉ khách hàng");
            dataGridView1.Columns.Add("Sdt", "Số điện thoại");
            dttbThongTinKH = DBContext.GetDataBySQL("SELECT * FROM [tblKhachhang]");
            foreach (DataRow dataRow in dttbThongTinKH.Rows)
            {
                dataGridView1.Rows.Add(
                    dataRow.ItemArray[0],
                    dataRow.ItemArray[1],
                    dataRow.ItemArray[2],
                    dataRow.ItemArray[3],
                    dataRow.ItemArray[4]
                    );
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView1.RowCount - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtGt.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtSdt.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string textSearch = textBox1.Text.Trim();
            dttbThongTinKH = DBContext.GetDataBySQL("select * " +
                            " from tblKhachhang " +
                    "where MaKH like '%" + textSearch + "%' or TenKH like '%" + textSearch + "%'");
            foreach (DataRow dataRow in dttbThongTinKH.Rows)
            {
                dataGridView1.Rows.Add(
                    dataRow.ItemArray[0],
                    dataRow.ItemArray[1],
                    dataRow.ItemArray[2],
                    dataRow.ItemArray[3],
                    dataRow.ItemArray[4]
                   );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
