
namespace Project
{
    partial class Nhanvien
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
            this.grpthongtinnv = new System.Windows.Forms.GroupBox();
            this.cblamviec = new System.Windows.Forms.CheckBox();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.clmanhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lamviec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.lblsdt = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lbltennv = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.grpthongtinnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // grpthongtinnv
            // 
            this.grpthongtinnv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpthongtinnv.Controls.Add(this.cblamviec);
            this.grpthongtinnv.Controls.Add(this.dgvnhanvien);
            this.grpthongtinnv.Controls.Add(this.txtsdt);
            this.grpthongtinnv.Controls.Add(this.txtdiachi);
            this.grpthongtinnv.Controls.Add(this.txtgioitinh);
            this.grpthongtinnv.Controls.Add(this.txttennv);
            this.grpthongtinnv.Controls.Add(this.txtmanv);
            this.grpthongtinnv.Controls.Add(this.btnthoat);
            this.grpthongtinnv.Controls.Add(this.btnsua);
            this.grpthongtinnv.Controls.Add(this.btnthem);
            this.grpthongtinnv.Controls.Add(this.btnlammoi);
            this.grpthongtinnv.Controls.Add(this.lblsdt);
            this.grpthongtinnv.Controls.Add(this.lbldiachi);
            this.grpthongtinnv.Controls.Add(this.lblgioitinh);
            this.grpthongtinnv.Controls.Add(this.lbltennv);
            this.grpthongtinnv.Controls.Add(this.lblmanv);
            this.grpthongtinnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpthongtinnv.Location = new System.Drawing.Point(16, 15);
            this.grpthongtinnv.Margin = new System.Windows.Forms.Padding(4);
            this.grpthongtinnv.Name = "grpthongtinnv";
            this.grpthongtinnv.Padding = new System.Windows.Forms.Padding(4);
            this.grpthongtinnv.Size = new System.Drawing.Size(1000, 471);
            this.grpthongtinnv.TabIndex = 3;
            this.grpthongtinnv.TabStop = false;
            this.grpthongtinnv.Text = "Thông tin nhân viên";
            // 
            // cblamviec
            // 
            this.cblamviec.AutoSize = true;
            this.cblamviec.Location = new System.Drawing.Point(645, 149);
            this.cblamviec.Name = "cblamviec";
            this.cblamviec.Size = new System.Drawing.Size(134, 33);
            this.cblamviec.TabIndex = 16;
            this.cblamviec.Text = "Làm Việc";
            this.cblamviec.UseVisualStyleBackColor = true;
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmanhanvien,
            this.cltennhanvien,
            this.clgioitinh,
            this.cldiachi,
            this.clsdt,
            this.Lamviec});
            this.dgvnhanvien.Location = new System.Drawing.Point(8, 258);
            this.dgvnhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.RowHeadersWidth = 51;
            this.dgvnhanvien.Size = new System.Drawing.Size(979, 199);
            this.dgvnhanvien.TabIndex = 14;
            this.dgvnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellContentClick);
            // 
            // clmanhanvien
            // 
            this.clmanhanvien.DataPropertyName = "MaNV";
            this.clmanhanvien.HeaderText = "Mã nhân viên";
            this.clmanhanvien.MinimumWidth = 6;
            this.clmanhanvien.Name = "clmanhanvien";
            // 
            // cltennhanvien
            // 
            this.cltennhanvien.DataPropertyName = "TenNV";
            this.cltennhanvien.HeaderText = "Tên nhân viên";
            this.cltennhanvien.MinimumWidth = 6;
            this.cltennhanvien.Name = "cltennhanvien";
            // 
            // clgioitinh
            // 
            this.clgioitinh.DataPropertyName = "Gioitinh";
            this.clgioitinh.HeaderText = "Giới tính";
            this.clgioitinh.MinimumWidth = 6;
            this.clgioitinh.Name = "clgioitinh";
            // 
            // cldiachi
            // 
            this.cldiachi.DataPropertyName = "Diachi";
            this.cldiachi.HeaderText = "Địa chỉ";
            this.cldiachi.MinimumWidth = 6;
            this.cldiachi.Name = "cldiachi";
            // 
            // clsdt
            // 
            this.clsdt.DataPropertyName = "sdt";
            this.clsdt.HeaderText = "Số điện thoại";
            this.clsdt.MinimumWidth = 6;
            this.clsdt.Name = "clsdt";
            // 
            // Lamviec
            // 
            this.Lamviec.DataPropertyName = "Lamviec";
            this.Lamviec.HeaderText = "Làm Việc";
            this.Lamviec.MinimumWidth = 6;
            this.Lamviec.Name = "Lamviec";
            this.Lamviec.ReadOnly = true;
            this.Lamviec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Lamviec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.Color.White;
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(645, 102);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(179, 29);
            this.txtsdt.TabIndex = 13;
            // 
            // txtdiachi
            // 
            this.txtdiachi.BackColor = System.Drawing.Color.White;
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(645, 49);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(179, 29);
            this.txtdiachi.TabIndex = 12;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.BackColor = System.Drawing.Color.White;
            this.txtgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgioitinh.Location = new System.Drawing.Point(232, 140);
            this.txtgioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(179, 29);
            this.txtgioitinh.TabIndex = 11;
            // 
            // txttennv
            // 
            this.txttennv.BackColor = System.Drawing.Color.White;
            this.txttennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennv.Location = new System.Drawing.Point(232, 95);
            this.txttennv.Margin = new System.Windows.Forms.Padding(4);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(179, 29);
            this.txttennv.TabIndex = 11;
            // 
            // txtmanv
            // 
            this.txtmanv.BackColor = System.Drawing.Color.White;
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(232, 49);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(179, 29);
            this.txtmanv.TabIndex = 10;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Location = new System.Drawing.Point(662, 203);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(117, 34);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Ẩn";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsua.Location = new System.Drawing.Point(489, 203);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(117, 34);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthem.Location = new System.Drawing.Point(320, 203);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(117, 34);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlammoi.Location = new System.Drawing.Point(141, 203);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(117, 34);
            this.btnlammoi.TabIndex = 2;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsdt.ForeColor = System.Drawing.Color.Black;
            this.lblsdt.Location = new System.Drawing.Point(512, 102);
            this.lblsdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(121, 24);
            this.lblsdt.TabIndex = 4;
            this.lblsdt.Text = "Số điện thoại";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.ForeColor = System.Drawing.Color.Black;
            this.lbldiachi.Location = new System.Drawing.Point(512, 53);
            this.lbldiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(67, 24);
            this.lbldiachi.TabIndex = 3;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgioitinh.ForeColor = System.Drawing.Color.Black;
            this.lblgioitinh.Location = new System.Drawing.Point(88, 140);
            this.lblgioitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(78, 24);
            this.lblgioitinh.TabIndex = 2;
            this.lblgioitinh.Text = "Giới tính";
            // 
            // lbltennv
            // 
            this.lbltennv.AutoSize = true;
            this.lbltennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltennv.ForeColor = System.Drawing.Color.Black;
            this.lbltennv.Location = new System.Drawing.Point(88, 98);
            this.lbltennv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltennv.Name = "lbltennv";
            this.lbltennv.Size = new System.Drawing.Size(132, 24);
            this.lbltennv.TabIndex = 1;
            this.lbltennv.Text = "Tên nhân viên";
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanv.ForeColor = System.Drawing.Color.Black;
            this.lblmanv.Location = new System.Drawing.Point(88, 53);
            this.lblmanv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(124, 24);
            this.lblmanv.TabIndex = 0;
            this.lblmanv.Text = "Mã nhân viên";
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 487);
            this.Controls.Add(this.grpthongtinnv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.grpthongtinnv.ResumeLayout(false);
            this.grpthongtinnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpthongtinnv;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lbltennv;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmanhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsdt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Lamviec;
        private System.Windows.Forms.CheckBox cblamviec;
    }
}