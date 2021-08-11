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
    public partial class TKNhacungcap : Form
    {
        private DataTable dttbThongTinNhaCC = null;
        public TKNhacungcap()
        {
            InitializeComponent();
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            dataGridView1.Columns.Add("MaNCC", "Mã Nhà Cung Cấp");
            dataGridView1.Columns.Add("TenNCC", "Tên Nhà Cung Cấp");
            dataGridView1.Columns.Add("Diachi", "Địa Chỉ");
            dataGridView1.Columns.Add("sdt", "Số Điện Thoại");
            dttbThongTinNhaCC = DBContext.GetDataBySQL("SELECT * FROM [tblNhaCC]");
            foreach (DataRow dataRow in dttbThongTinNhaCC.Rows)
            {
                dataGridView1.Rows.Add(
                    dataRow.ItemArray[0],
                    dataRow.ItemArray[1],
                    dataRow.ItemArray[2],
                    dataRow.ItemArray[3]
                    );
            }
        }

        private void lblMaNCC_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string textSearch = textBox1.Text.Trim();
            dttbThongTinNhaCC = DBContext.GetDataBySQL("select * " +
                            " from tblNhaCC " +
                    "where MaNCC like '%" + textSearch + "%' or TenNCC like '%" + textSearch + "%'");
            foreach (DataRow dataRow in dttbThongTinNhaCC.Rows)
            {
                dataGridView1.Rows.Add(
                    dataRow.ItemArray[0],
                    dataRow.ItemArray[1],
                    dataRow.ItemArray[2],
                    dataRow.ItemArray[3]
                   );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView1.RowCount - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                txtmancc.Text = row.Cells[0].Value.ToString();
                txttenncc.Text = row.Cells[1].Value.ToString();
                txtdiachi.Text = row.Cells[2].Value.ToString();
                txtsdt.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
