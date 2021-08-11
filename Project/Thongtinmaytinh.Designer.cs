
namespace Project
{
    partial class Thongtinmaytinh
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
            this.dgvmaytinh = new System.Windows.Forms.DataGridView();
            this.clmamaytinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltenmaytinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmacc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpthongtinmaytinh = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.cbomancc = new System.Windows.Forms.ComboBox();
            this.txtmamaytinh = new System.Windows.Forms.TextBox();
            this.lblmancc = new System.Windows.Forms.Label();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenmaytinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmaytinh)).BeginInit();
            this.grpthongtinmaytinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvmaytinh
            // 
            this.dgvmaytinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmaytinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmaytinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmamaytinh,
            this.cltenmaytinh,
            this.clmacc,
            this.clsoluong,
            this.cldongia});
            this.dgvmaytinh.Location = new System.Drawing.Point(-4, 252);
            this.dgvmaytinh.Name = "dgvmaytinh";
            this.dgvmaytinh.RowHeadersWidth = 51;
            this.dgvmaytinh.Size = new System.Drawing.Size(809, 184);
            this.dgvmaytinh.TabIndex = 21;
            this.dgvmaytinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmaytinh_CellContentClick);
            // 
            // clmamaytinh
            // 
            this.clmamaytinh.DataPropertyName = "MaMT";
            this.clmamaytinh.HeaderText = "Mã máy tính";
            this.clmamaytinh.MinimumWidth = 6;
            this.clmamaytinh.Name = "clmamaytinh";
            // 
            // cltenmaytinh
            // 
            this.cltenmaytinh.DataPropertyName = "tenmt";
            this.cltenmaytinh.HeaderText = "Tên máy tính";
            this.cltenmaytinh.MinimumWidth = 6;
            this.cltenmaytinh.Name = "cltenmaytinh";
            // 
            // clmacc
            // 
            this.clmacc.DataPropertyName = "MaNCC";
            this.clmacc.HeaderText = "Mã NCC";
            this.clmacc.MinimumWidth = 6;
            this.clmacc.Name = "clmacc";
            // 
            // clsoluong
            // 
            this.clsoluong.DataPropertyName = "soluong";
            this.clsoluong.HeaderText = "Số lượng";
            this.clsoluong.MinimumWidth = 6;
            this.clsoluong.Name = "clsoluong";
            // 
            // cldongia
            // 
            this.cldongia.DataPropertyName = "giaban";
            this.cldongia.HeaderText = "Giá bán";
            this.cldongia.MinimumWidth = 6;
            this.cldongia.Name = "cldongia";
            // 
            // grpthongtinmaytinh
            // 
            this.grpthongtinmaytinh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpthongtinmaytinh.Controls.Add(this.btnthoat);
            this.grpthongtinmaytinh.Controls.Add(this.cbomancc);
            this.grpthongtinmaytinh.Controls.Add(this.txtmamaytinh);
            this.grpthongtinmaytinh.Controls.Add(this.lblmancc);
            this.grpthongtinmaytinh.Controls.Add(this.btnlammoi);
            this.grpthongtinmaytinh.Controls.Add(this.label1);
            this.grpthongtinmaytinh.Controls.Add(this.btnxoa);
            this.grpthongtinmaytinh.Controls.Add(this.btnsua);
            this.grpthongtinmaytinh.Controls.Add(this.btnthem);
            this.grpthongtinmaytinh.Controls.Add(this.label3);
            this.grpthongtinmaytinh.Controls.Add(this.txttenmaytinh);
            this.grpthongtinmaytinh.Controls.Add(this.label2);
            this.grpthongtinmaytinh.Controls.Add(this.txtsoluong);
            this.grpthongtinmaytinh.Controls.Add(this.txtgiaban);
            this.grpthongtinmaytinh.Controls.Add(this.label4);
            this.grpthongtinmaytinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpthongtinmaytinh.Location = new System.Drawing.Point(-4, 14);
            this.grpthongtinmaytinh.Name = "grpthongtinmaytinh";
            this.grpthongtinmaytinh.Size = new System.Drawing.Size(809, 232);
            this.grpthongtinmaytinh.TabIndex = 20;
            this.grpthongtinmaytinh.TabStop = false;
            this.grpthongtinmaytinh.Text = "Thông tin máy tính";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Location = new System.Drawing.Point(653, 176);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(95, 28);
            this.btnthoat.TabIndex = 45;
            this.btnthoat.Text = "Ẩn";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // cbomancc
            // 
            this.cbomancc.BackColor = System.Drawing.Color.White;
            this.cbomancc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomancc.FormattingEnabled = true;
            this.cbomancc.Location = new System.Drawing.Point(160, 124);
            this.cbomancc.Name = "cbomancc";
            this.cbomancc.Size = new System.Drawing.Size(121, 26);
            this.cbomancc.TabIndex = 34;
            // 
            // txtmamaytinh
            // 
            this.txtmamaytinh.BackColor = System.Drawing.Color.White;
            this.txtmamaytinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmamaytinh.Location = new System.Drawing.Point(160, 36);
            this.txtmamaytinh.Name = "txtmamaytinh";
            this.txtmamaytinh.Size = new System.Drawing.Size(121, 24);
            this.txtmamaytinh.TabIndex = 22;
            // 
            // lblmancc
            // 
            this.lblmancc.AutoSize = true;
            this.lblmancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmancc.ForeColor = System.Drawing.Color.Black;
            this.lblmancc.Location = new System.Drawing.Point(66, 127);
            this.lblmancc.Name = "lblmancc";
            this.lblmancc.Size = new System.Drawing.Size(70, 18);
            this.lblmancc.TabIndex = 19;
            this.lblmancc.Text = "Tên NCC";
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlammoi.Location = new System.Drawing.Point(60, 176);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(87, 28);
            this.btnlammoi.TabIndex = 15;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã máy tính";
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnxoa.Location = new System.Drawing.Point(513, 176);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 28);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsua.Location = new System.Drawing.Point(367, 176);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(87, 28);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthem.Location = new System.Drawing.Point(221, 176);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 28);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(66, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên máy tính";
            // 
            // txttenmaytinh
            // 
            this.txttenmaytinh.BackColor = System.Drawing.Color.White;
            this.txttenmaytinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenmaytinh.Location = new System.Drawing.Point(160, 79);
            this.txttenmaytinh.Name = "txttenmaytinh";
            this.txttenmaytinh.Size = new System.Drawing.Size(121, 24);
            this.txttenmaytinh.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(387, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // txtsoluong
            // 
            this.txtsoluong.BackColor = System.Drawing.Color.White;
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(467, 36);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(115, 24);
            this.txtsoluong.TabIndex = 6;
            // 
            // txtgiaban
            // 
            this.txtgiaban.BackColor = System.Drawing.Color.White;
            this.txtgiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiaban.Location = new System.Drawing.Point(467, 79);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(115, 24);
            this.txtgiaban.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(387, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá Bán";
            // 
            // Thongtinmaytinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvmaytinh);
            this.Controls.Add(this.grpthongtinmaytinh);
            this.Name = "Thongtinmaytinh";
            this.Text = "Thongtinmaytinh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvmaytinh)).EndInit();
            this.grpthongtinmaytinh.ResumeLayout(false);
            this.grpthongtinmaytinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmaytinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmamaytinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenmaytinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmacc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldongia;
        private System.Windows.Forms.GroupBox grpthongtinmaytinh;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtmamaytinh;
        private System.Windows.Forms.Label lblmancc;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenmaytinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbomancc;
    }
}