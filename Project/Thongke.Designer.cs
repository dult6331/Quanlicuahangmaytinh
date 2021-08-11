
namespace Project
{
    partial class Thongke
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
            this.dgvTimkiem = new System.Windows.Forms.DataGridView();
            this.grpthongke = new System.Windows.Forms.GroupBox();
            this.lblthangnam = new System.Windows.Forms.Label();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.rdbHDB = new System.Windows.Forms.RadioButton();
            this.rdbHDN = new System.Windows.Forms.RadioButton();
            this.cboThangNam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiem)).BeginInit();
            this.grpthongke.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTimkiem
            // 
            this.dgvTimkiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimkiem.Location = new System.Drawing.Point(12, 219);
            this.dgvTimkiem.Name = "dgvTimkiem";
            this.dgvTimkiem.RowHeadersWidth = 51;
            this.dgvTimkiem.Size = new System.Drawing.Size(1006, 290);
            this.dgvTimkiem.TabIndex = 47;
            // 
            // grpthongke
            // 
            this.grpthongke.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpthongke.Controls.Add(this.cboThangNam);
            this.grpthongke.Controls.Add(this.lblthangnam);
            this.grpthongke.Controls.Add(this.btnquaylai);
            this.grpthongke.Controls.Add(this.rdbHDB);
            this.grpthongke.Controls.Add(this.rdbHDN);
            this.grpthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpthongke.Location = new System.Drawing.Point(12, 12);
            this.grpthongke.Name = "grpthongke";
            this.grpthongke.Size = new System.Drawing.Size(1006, 222);
            this.grpthongke.TabIndex = 46;
            this.grpthongke.TabStop = false;
            this.grpthongke.Text = "Thống kê";
            // 
            // lblthangnam
            // 
            this.lblthangnam.AutoSize = true;
            this.lblthangnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthangnam.ForeColor = System.Drawing.Color.Black;
            this.lblthangnam.Location = new System.Drawing.Point(309, 51);
            this.lblthangnam.Name = "lblthangnam";
            this.lblthangnam.Size = new System.Drawing.Size(82, 18);
            this.lblthangnam.TabIndex = 25;
            this.lblthangnam.Text = "Tháng năm";
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquaylai.Location = new System.Drawing.Point(452, 150);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(89, 34);
            this.btnquaylai.TabIndex = 23;
            this.btnquaylai.Text = "Ẩn";
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // rdbHDB
            // 
            this.rdbHDB.AutoSize = true;
            this.rdbHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHDB.ForeColor = System.Drawing.Color.Black;
            this.rdbHDB.Location = new System.Drawing.Point(576, 82);
            this.rdbHDB.Name = "rdbHDB";
            this.rdbHDB.Size = new System.Drawing.Size(111, 22);
            this.rdbHDB.TabIndex = 28;
            this.rdbHDB.Text = "Hóa đơn bán";
            this.rdbHDB.UseVisualStyleBackColor = true;
            this.rdbHDB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbHDB_MouseClick);
            // 
            // rdbHDN
            // 
            this.rdbHDN.AutoSize = true;
            this.rdbHDN.Checked = true;
            this.rdbHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHDN.ForeColor = System.Drawing.Color.Black;
            this.rdbHDN.Location = new System.Drawing.Point(576, 47);
            this.rdbHDN.Name = "rdbHDN";
            this.rdbHDN.Size = new System.Drawing.Size(119, 22);
            this.rdbHDN.TabIndex = 28;
            this.rdbHDN.TabStop = true;
            this.rdbHDN.Text = "Hóa đơn nhập";
            this.rdbHDN.UseVisualStyleBackColor = true;
            this.rdbHDN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbHDN_MouseClick);
            // 
            // cboThangNam
            // 
            this.cboThangNam.BackColor = System.Drawing.Color.White;
            this.cboThangNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThangNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThangNam.FormattingEnabled = true;
            this.cboThangNam.Location = new System.Drawing.Point(397, 48);
            this.cboThangNam.Name = "cboThangNam";
            this.cboThangNam.Size = new System.Drawing.Size(123, 24);
            this.cboThangNam.TabIndex = 50;
            this.cboThangNam.SelectedIndexChanged += new System.EventHandler(this.cboThangNam_SelectedIndexChanged);
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 521);
            this.Controls.Add(this.dgvTimkiem);
            this.Controls.Add(this.grpthongke);
            this.Name = "Thongke";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiem)).EndInit();
            this.grpthongke.ResumeLayout(false);
            this.grpthongke.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimkiem;
        private System.Windows.Forms.GroupBox grpthongke;
        private System.Windows.Forms.Label lblthangnam;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.RadioButton rdbHDB;
        private System.Windows.Forms.RadioButton rdbHDN;
        private System.Windows.Forms.ComboBox cboThangNam;
    }
}