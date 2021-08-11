
namespace Project
{
    partial class Nhacungcap
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
            this.dgvncc = new System.Windows.Forms.DataGridView();
            this.clmcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpthongtinnhacungcap = new System.Windows.Forms.GroupBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.lblsdt = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.lbltenncc = new System.Windows.Forms.Label();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.lblncc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvncc)).BeginInit();
            this.grpthongtinnhacungcap.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvncc
            // 
            this.dgvncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcc,
            this.cltenncc,
            this.cldiachi,
            this.clsdt});
            this.dgvncc.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvncc.Location = new System.Drawing.Point(12, 240);
            this.dgvncc.Name = "dgvncc";
            this.dgvncc.RowHeadersWidth = 51;
            this.dgvncc.Size = new System.Drawing.Size(724, 167);
            this.dgvncc.TabIndex = 6;
            this.dgvncc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvncc_CellContentClick);
            // 
            // clmcc
            // 
            this.clmcc.DataPropertyName = "MaNCC";
            this.clmcc.HeaderText = "Mã NCC";
            this.clmcc.MinimumWidth = 6;
            this.clmcc.Name = "clmcc";
            // 
            // cltenncc
            // 
            this.cltenncc.DataPropertyName = "TenNCC";
            this.cltenncc.HeaderText = "Tên NCC";
            this.cltenncc.MinimumWidth = 6;
            this.cltenncc.Name = "cltenncc";
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
            this.clsdt.HeaderText = "SĐT";
            this.clsdt.MinimumWidth = 6;
            this.clsdt.Name = "clsdt";
            // 
            // grpthongtinnhacungcap
            // 
            this.grpthongtinnhacungcap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpthongtinnhacungcap.Controls.Add(this.btnlammoi);
            this.grpthongtinnhacungcap.Controls.Add(this.btnquaylai);
            this.grpthongtinnhacungcap.Controls.Add(this.txtsdt);
            this.grpthongtinnhacungcap.Controls.Add(this.lblsdt);
            this.grpthongtinnhacungcap.Controls.Add(this.txtdiachi);
            this.grpthongtinnhacungcap.Controls.Add(this.lbldiachi);
            this.grpthongtinnhacungcap.Controls.Add(this.btnsua);
            this.grpthongtinnhacungcap.Controls.Add(this.btnthem);
            this.grpthongtinnhacungcap.Controls.Add(this.txttenncc);
            this.grpthongtinnhacungcap.Controls.Add(this.lbltenncc);
            this.grpthongtinnhacungcap.Controls.Add(this.txtmancc);
            this.grpthongtinnhacungcap.Controls.Add(this.lblncc);
            this.grpthongtinnhacungcap.Controls.Add(this.label2);
            this.grpthongtinnhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpthongtinnhacungcap.ForeColor = System.Drawing.Color.Black;
            this.grpthongtinnhacungcap.Location = new System.Drawing.Point(12, 12);
            this.grpthongtinnhacungcap.Name = "grpthongtinnhacungcap";
            this.grpthongtinnhacungcap.Size = new System.Drawing.Size(724, 222);
            this.grpthongtinnhacungcap.TabIndex = 5;
            this.grpthongtinnhacungcap.TabStop = false;
            this.grpthongtinnhacungcap.Text = "Thông tin nhà cung cấp";
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlammoi.Location = new System.Drawing.Point(24, 162);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(85, 29);
            this.btnlammoi.TabIndex = 16;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquaylai.Location = new System.Drawing.Point(556, 162);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(98, 29);
            this.btnquaylai.TabIndex = 36;
            this.btnquaylai.Text = "Ẩn";
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.Color.White;
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(389, 101);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(137, 24);
            this.txtsdt.TabIndex = 12;
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsdt.ForeColor = System.Drawing.Color.Black;
            this.lblsdt.Location = new System.Drawing.Point(315, 105);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(38, 18);
            this.lblsdt.TabIndex = 11;
            this.lblsdt.Text = "SĐT";
            // 
            // txtdiachi
            // 
            this.txtdiachi.BackColor = System.Drawing.Color.White;
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(389, 43);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(137, 24);
            this.txtdiachi.TabIndex = 10;
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.ForeColor = System.Drawing.Color.Black;
            this.lbldiachi.Location = new System.Drawing.Point(315, 46);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(53, 18);
            this.lbldiachi.TabIndex = 9;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsua.Location = new System.Drawing.Point(358, 162);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(85, 29);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthem.Location = new System.Drawing.Point(188, 162);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 29);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttenncc
            // 
            this.txttenncc.BackColor = System.Drawing.Color.White;
            this.txttenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenncc.Location = new System.Drawing.Point(99, 101);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(137, 24);
            this.txttenncc.TabIndex = 4;
            // 
            // lbltenncc
            // 
            this.lbltenncc.AutoSize = true;
            this.lbltenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenncc.ForeColor = System.Drawing.Color.Black;
            this.lbltenncc.Location = new System.Drawing.Point(25, 104);
            this.lbltenncc.Name = "lbltenncc";
            this.lbltenncc.Size = new System.Drawing.Size(70, 18);
            this.lbltenncc.TabIndex = 3;
            this.lbltenncc.Text = "Tên NCC";
            // 
            // txtmancc
            // 
            this.txtmancc.BackColor = System.Drawing.Color.White;
            this.txtmancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmancc.Location = new System.Drawing.Point(99, 45);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(137, 24);
            this.txtmancc.TabIndex = 2;
            // 
            // lblncc
            // 
            this.lblncc.AutoSize = true;
            this.lblncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblncc.ForeColor = System.Drawing.Color.Black;
            this.lblncc.Location = new System.Drawing.Point(25, 48);
            this.lblncc.Name = "lblncc";
            this.lblncc.Size = new System.Drawing.Size(66, 18);
            this.lblncc.TabIndex = 0;
            this.lblncc.Text = "Mã NCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // Nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 419);
            this.Controls.Add(this.dgvncc);
            this.Controls.Add(this.grpthongtinnhacungcap);
            this.Name = "Nhacungcap";
            this.Text = "Nhacungcap";
            ((System.ComponentModel.ISupportInitialize)(this.dgvncc)).EndInit();
            this.grpthongtinnhacungcap.ResumeLayout(false);
            this.grpthongtinnhacungcap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsdt;
        private System.Windows.Forms.GroupBox grpthongtinnhacungcap;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.Label lbltenncc;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.Label lblncc;
        private System.Windows.Forms.Label label2;
    }
}