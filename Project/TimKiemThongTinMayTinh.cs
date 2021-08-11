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
    public partial class TimKiemThongTinMayTinh : Form
    {
        private DataTable dttbThongTinMayTinh = null;
        private DataTable dttbNhaCungCap = null;
        public TimKiemThongTinMayTinh()
        {
            InitializeComponent();
            loadDataGridView();
            loadComboBoxNhaCungCap();
        }

        private void loadComboBoxNhaCungCap()
        {
            dttbNhaCungCap = DBContext.GetDataBySQL("select * from tblNhaCC");
            //foreach (DataRow row in dttbNhaCungCap.Rows)
            //{
            //    cboMaNhaCungCap.Items.Add(row.ItemArray[0]);
            //}
            cboMaNhaCungCap.DataSource = dttbNhaCungCap;
            cboMaNhaCungCap.SelectedIndex=0;
            cboMaNhaCungCap.DisplayMember = "MaNCC";
            cboMaNhaCungCap.ValueMember = "MaNCC";
        }

        private void loadDataGridView()
        {
            dataGridView1.Columns.Add("MaMt","Mã Máy Tính");
            dataGridView1.Columns.Add("TenMT","Tên Máy Tính");
            dataGridView1.Columns.Add("MaNCC","Mã Nhà Cung Cấp");
            dataGridView1.Columns.Add("Soluong","Số lượng");
            dataGridView1.Columns.Add("Giaban","Giá bán");
            dttbThongTinMayTinh=DBContext.GetDataBySQL("SELECT * FROM [tblThongtinMT]");
            foreach( DataRow dataRow in dttbThongTinMayTinh.Rows)
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

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string textSearch = textBox1.Text.Trim();
            dttbThongTinMayTinh = DBContext.GetDataBySQL("select * "+
                            " from tblThongtinMT " +
                    "where MaMT like '%"+textSearch+ "%' or TenMT like '%" + textSearch + "%'");
            foreach (DataRow dataRow in dttbThongTinMayTinh.Rows)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > 0 && index < dataGridView1.RowCount-1)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                txtmamaytinh.Text = row.Cells[0].Value.ToString();
                txttenmaytinh.Text = row.Cells[1].Value.ToString();
                cboMaNhaCungCap.SelectedValue = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txtsoluong.Text = row.Cells[3].Value.ToString();
                txtgiaban.Text = row.Cells[4].Value.ToString();
            }
            
            
        }

        private void cbomancc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
