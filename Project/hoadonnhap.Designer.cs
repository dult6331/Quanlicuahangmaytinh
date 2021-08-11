
namespace Project
{
    partial class hoadonnhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.grphoadonban = new System.Windows.Forms.GroupBox();
            this.btnAn = new System.Windows.Forms.Button();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbomamaytinh = new System.Windows.Forms.ComboBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmahoadonnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.lblsodienthoai = new System.Windows.Forms.Label();
            this.lbldongia = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lblmamaytinh = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblngaynhap = new System.Windows.Forms.Label();
            this.lblmahoadonnhap = new System.Windows.Forms.Label();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnImportToExcel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbbSheet = new System.Windows.Forms.ComboBox();
            this.txtSaveExcelToSql = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.grphoadonban.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(605, 12);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(1243, 519);
            this.dgvHoaDonNhap.TabIndex = 27;
            this.dgvHoaDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonNhap_CellClick);
            // 
            // grphoadonban
            // 
            this.grphoadonban.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grphoadonban.Controls.Add(this.btnAn);
            this.grphoadonban.Controls.Add(this.txtNhaCC);
            this.grphoadonban.Controls.Add(this.btnThem);
            this.grphoadonban.Controls.Add(this.cboMaNV);
            this.grphoadonban.Controls.Add(this.dateTimePicker1);
            this.grphoadonban.Controls.Add(this.cbomamaytinh);
            this.grphoadonban.Controls.Add(this.txtsoluong);
            this.grphoadonban.Controls.Add(this.txtmahoadonnhap);
            this.grphoadonban.Controls.Add(this.label2);
            this.grphoadonban.Controls.Add(this.lblmanv);
            this.grphoadonban.Controls.Add(this.txtsodienthoai);
            this.grphoadonban.Controls.Add(this.lblsodienthoai);
            this.grphoadonban.Controls.Add(this.lbldongia);
            this.grphoadonban.Controls.Add(this.lbldiachi);
            this.grphoadonban.Controls.Add(this.txtGiaNhap);
            this.grphoadonban.Controls.Add(this.txtdiachi);
            this.grphoadonban.Controls.Add(this.btnlammoi);
            this.grphoadonban.Controls.Add(this.lblsoluong);
            this.grphoadonban.Controls.Add(this.lblmamaytinh);
            this.grphoadonban.Controls.Add(this.btnLuu);
            this.grphoadonban.Controls.Add(this.lblngaynhap);
            this.grphoadonban.Controls.Add(this.lblmahoadonnhap);
            this.grphoadonban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grphoadonban.Location = new System.Drawing.Point(12, 12);
            this.grphoadonban.Name = "grphoadonban";
            this.grphoadonban.Size = new System.Drawing.Size(587, 548);
            this.grphoadonban.TabIndex = 26;
            this.grphoadonban.TabStop = false;
            this.grphoadonban.Text = "Hóa đơn Nhập";
            // 
            // btnAn
            // 
            this.btnAn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAn.Location = new System.Drawing.Point(498, 435);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(83, 32);
            this.btnAn.TabIndex = 58;
            this.btnAn.Text = "Ẩn";
            this.btnAn.UseVisualStyleBackColor = false;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaCC.Location = new System.Drawing.Point(149, 240);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.ReadOnly = true;
            this.txtNhaCC.Size = new System.Drawing.Size(123, 22);
            this.txtNhaCC.TabIndex = 57;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(10, 435);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 32);
            this.btnThem.TabIndex = 56;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // cboMaNV
            // 
            this.cboMaNV.BackColor = System.Drawing.Color.White;
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(149, 126);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(123, 24);
            this.cboMaNV.TabIndex = 49;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(441, 73);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 2, 16, 51, 19, 0);
            // 
            // cbomamaytinh
            // 
            this.cbomamaytinh.BackColor = System.Drawing.Color.White;
            this.cbomamaytinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomamaytinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomamaytinh.FormattingEnabled = true;
            this.cbomamaytinh.Location = new System.Drawing.Point(149, 183);
            this.cbomamaytinh.Name = "cbomamaytinh";
            this.cbomamaytinh.Size = new System.Drawing.Size(123, 24);
            this.cbomamaytinh.TabIndex = 33;
            // 
            // txtsoluong
            // 
            this.txtsoluong.BackColor = System.Drawing.Color.White;
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(149, 291);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(123, 22);
            this.txtsoluong.TabIndex = 16;
            // 
            // txtmahoadonnhap
            // 
            this.txtmahoadonnhap.BackColor = System.Drawing.Color.White;
            this.txtmahoadonnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahoadonnhap.Location = new System.Drawing.Point(149, 71);
            this.txtmahoadonnhap.Name = "txtmahoadonnhap";
            this.txtmahoadonnhap.Size = new System.Drawing.Size(123, 22);
            this.txtmahoadonnhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nhà Cung Cấp";
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanv.ForeColor = System.Drawing.Color.Black;
            this.lblmanv.Location = new System.Drawing.Point(6, 126);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(114, 20);
            this.lblmanv.TabIndex = 44;
            this.lblmanv.Text = "Tên Nhân Viên";
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.BackColor = System.Drawing.Color.White;
            this.txtsodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsodienthoai.Location = new System.Drawing.Point(441, 188);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(123, 22);
            this.txtsodienthoai.TabIndex = 31;
            // 
            // lblsodienthoai
            // 
            this.lblsodienthoai.AutoSize = true;
            this.lblsodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsodienthoai.ForeColor = System.Drawing.Color.Black;
            this.lblsodienthoai.Location = new System.Drawing.Point(312, 192);
            this.lblsodienthoai.Name = "lblsodienthoai";
            this.lblsodienthoai.Size = new System.Drawing.Size(102, 20);
            this.lblsodienthoai.TabIndex = 30;
            this.lblsodienthoai.Text = "Số điện thoại";
            // 
            // lbldongia
            // 
            this.lbldongia.AutoSize = true;
            this.lbldongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldongia.ForeColor = System.Drawing.Color.Black;
            this.lbldongia.Location = new System.Drawing.Point(312, 243);
            this.lbldongia.Name = "lbldongia";
            this.lbldongia.Size = new System.Drawing.Size(80, 20);
            this.lbldongia.TabIndex = 29;
            this.lbldongia.Text = "Giá Nhập ";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.ForeColor = System.Drawing.Color.Black;
            this.lbldiachi.Location = new System.Drawing.Point(312, 130);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(57, 20);
            this.lbldiachi.TabIndex = 29;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.Color.White;
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(441, 243);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(123, 22);
            this.txtGiaNhap.TabIndex = 28;
            // 
            // txtdiachi
            // 
            this.txtdiachi.BackColor = System.Drawing.Color.White;
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(441, 130);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(123, 22);
            this.txtdiachi.TabIndex = 28;
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlammoi.Location = new System.Drawing.Point(160, 435);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(83, 32);
            this.btnlammoi.TabIndex = 20;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_MouseClick);
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoluong.ForeColor = System.Drawing.Color.Black;
            this.lblsoluong.Location = new System.Drawing.Point(6, 293);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(72, 20);
            this.lblsoluong.TabIndex = 15;
            this.lblsoluong.Text = "Số lượng";
            // 
            // lblmamaytinh
            // 
            this.lblmamaytinh.AutoSize = true;
            this.lblmamaytinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmamaytinh.ForeColor = System.Drawing.Color.Black;
            this.lblmamaytinh.Location = new System.Drawing.Point(6, 183);
            this.lblmamaytinh.Name = "lblmamaytinh";
            this.lblmamaytinh.Size = new System.Drawing.Size(94, 20);
            this.lblmamaytinh.TabIndex = 13;
            this.lblmamaytinh.Text = "Mã máy tính";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuu.Location = new System.Drawing.Point(316, 435);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(83, 32);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Sửa";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblngaynhap
            // 
            this.lblngaynhap.AutoSize = true;
            this.lblngaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngaynhap.ForeColor = System.Drawing.Color.Black;
            this.lblngaynhap.Location = new System.Drawing.Point(312, 73);
            this.lblngaynhap.Name = "lblngaynhap";
            this.lblngaynhap.Size = new System.Drawing.Size(85, 20);
            this.lblngaynhap.TabIndex = 2;
            this.lblngaynhap.Text = "Ngày nhập";
            // 
            // lblmahoadonnhap
            // 
            this.lblmahoadonnhap.AutoSize = true;
            this.lblmahoadonnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmahoadonnhap.ForeColor = System.Drawing.Color.Black;
            this.lblmahoadonnhap.Location = new System.Drawing.Point(6, 71);
            this.lblmahoadonnhap.Name = "lblmahoadonnhap";
            this.lblmahoadonnhap.Size = new System.Drawing.Size(133, 20);
            this.lblmahoadonnhap.TabIndex = 0;
            this.lblmahoadonnhap.Text = "Mã hóa đơn nhập";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(1754, 537);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(94, 23);
            this.btnExportToExcel.TabIndex = 29;
            this.btnExportToExcel.Text = "Exprot To Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnImportToExcel
            // 
            this.btnImportToExcel.Location = new System.Drawing.Point(1651, 537);
            this.btnImportToExcel.Name = "btnImportToExcel";
            this.btnImportToExcel.Size = new System.Drawing.Size(97, 23);
            this.btnImportToExcel.TabIndex = 30;
            this.btnImportToExcel.Text = "Import To Excel";
            this.btnImportToExcel.UseVisualStyleBackColor = true;
            this.btnImportToExcel.Click += new System.EventHandler(this.btnImportToExcel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbbSheet
            // 
            this.cbbSheet.FormattingEnabled = true;
            this.cbbSheet.Location = new System.Drawing.Point(1524, 538);
            this.cbbSheet.Name = "cbbSheet";
            this.cbbSheet.Size = new System.Drawing.Size(121, 21);
            this.cbbSheet.TabIndex = 31;
            this.cbbSheet.Visible = false;
            this.cbbSheet.SelectedIndexChanged += new System.EventHandler(this.cbbSheet_SelectedIndexChanged);
            // 
            // txtSaveExcelToSql
            // 
            this.txtSaveExcelToSql.Location = new System.Drawing.Point(1445, 536);
            this.txtSaveExcelToSql.Name = "txtSaveExcelToSql";
            this.txtSaveExcelToSql.Size = new System.Drawing.Size(73, 23);
            this.txtSaveExcelToSql.TabIndex = 32;
            this.txtSaveExcelToSql.Text = "lưu dữ liệu";
            this.txtSaveExcelToSql.UseVisualStyleBackColor = true;
            this.txtSaveExcelToSql.Visible = false;
            this.txtSaveExcelToSql.Click += new System.EventHandler(this.txtSaveExcelToSql_Click);
            // 
            // hoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1859, 570);
            this.Controls.Add(this.txtSaveExcelToSql);
            this.Controls.Add(this.cbbSheet);
            this.Controls.Add(this.btnImportToExcel);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.dgvHoaDonNhap);
            this.Controls.Add(this.grphoadonban);
            this.Name = "hoadonnhap";
            this.Text = "hoadonnhap";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.grphoadonban.ResumeLayout(false);
            this.grphoadonban.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDonNhap;
        private System.Windows.Forms.GroupBox grphoadonban;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbomamaytinh;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.Label lblsodienthoai;
        private System.Windows.Forms.Label lbldongia;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lblmamaytinh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblngaynhap;
        private System.Windows.Forms.Label lblmahoadonnhap;
        private System.Windows.Forms.TextBox txtNhaCC;
        private System.Windows.Forms.TextBox txtmahoadonnhap;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnImportToExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbbSheet;
        private System.Windows.Forms.Button txtSaveExcelToSql;
    }
}