namespace QuanLyNhaThuoc
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.panelTren = new System.Windows.Forms.Panel();
            this.btnQuanLyThuoc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblSDTKH = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblTongVat = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachThuoc = new System.Windows.Forms.DataGridView();
            this.btnResetKH = new System.Windows.Forms.Button();
            this.panelTren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTren
            // 
            this.panelTren.Controls.Add(this.btnQuanLyThuoc);
            this.panelTren.Controls.Add(this.panel2);
            this.panelTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTren.Location = new System.Drawing.Point(0, 0);
            this.panelTren.Name = "panelTren";
            this.panelTren.Size = new System.Drawing.Size(1170, 51);
            this.panelTren.TabIndex = 23;
            // 
            // btnQuanLyThuoc
            // 
            this.btnQuanLyThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(191)))));
            this.btnQuanLyThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyThuoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuanLyThuoc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuanLyThuoc.FlatAppearance.BorderSize = 0;
            this.btnQuanLyThuoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnQuanLyThuoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(11)))));
            this.btnQuanLyThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyThuoc.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThuoc.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLyThuoc.Name = "btnQuanLyThuoc";
            this.btnQuanLyThuoc.Size = new System.Drawing.Size(159, 50);
            this.btnQuanLyThuoc.TabIndex = 23;
            this.btnQuanLyThuoc.Text = "HÓA ĐƠN";
            this.btnQuanLyThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyThuoc.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 1);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(12, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tìm kiếm hóa đơn";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(12, 78);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(517, 35);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 119);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.Size = new System.Drawing.Size(558, 586);
            this.dgvHoaDon.TabIndex = 5;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày lập hóa đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(4, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tổng tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(4, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "VAT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(354, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(354, 46);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(225, 180);
            this.txtGhiChu.TabIndex = 13;
            this.txtGhiChu.Text = "";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Black;
            this.lblTongTien.Location = new System.Drawing.Point(181, 177);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTongTien.Size = new System.Drawing.Size(167, 20);
            this.lblTongTien.TabIndex = 9;
            this.lblTongTien.Text = "10.000.000";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhân viên lập HĐ:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Teal;
            this.label18.Location = new System.Drawing.Point(6, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 20);
            this.label18.TabIndex = 4;
            this.label18.Text = "ĐT Khách Hàng:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMaHD.Location = new System.Drawing.Point(181, 28);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMaHD.Size = new System.Drawing.Size(167, 20);
            this.lblMaHD.TabIndex = 1;
            this.lblMaHD.Text = "12547895";
            this.lblMaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSDTKH
            // 
            this.lblSDTKH.BackColor = System.Drawing.Color.Transparent;
            this.lblSDTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDTKH.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSDTKH.Location = new System.Drawing.Point(181, 118);
            this.lblSDTKH.Name = "lblSDTKH";
            this.lblSDTKH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSDTKH.Size = new System.Drawing.Size(167, 20);
            this.lblSDTKH.TabIndex = 5;
            this.lblSDTKH.Text = "038.454.2340";
            this.lblSDTKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenNV
            // 
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTenNV.Location = new System.Drawing.Point(181, 59);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTenNV.Size = new System.Drawing.Size(167, 20);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Lê Văn Tài";
            this.lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongVat
            // 
            this.lblTongVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongVat.ForeColor = System.Drawing.Color.Black;
            this.lblTongVat.Location = new System.Drawing.Point(181, 206);
            this.lblTongVat.Name = "lblTongVat";
            this.lblTongVat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTongVat.Size = new System.Drawing.Size(167, 20);
            this.lblTongVat.TabIndex = 10;
            this.lblTongVat.Text = "10.000.000";
            this.lblTongVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNgayLapHD);
            this.groupBox2.Controls.Add(this.lblTongVat);
            this.groupBox2.Controls.Add(this.lblTenNV);
            this.groupBox2.Controls.Add(this.lblTenKH);
            this.groupBox2.Controls.Add(this.lblSDTKH);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.lblMaHD);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(576, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 242);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn";
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayLapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLapHD.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNgayLapHD.Location = new System.Drawing.Point(181, 147);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNgayLapHD.Size = new System.Drawing.Size(167, 20);
            this.lblNgayLapHD.TabIndex = 6;
            this.lblNgayLapHD.Text = "08/11/2020";
            this.lblNgayLapHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenKH
            // 
            this.lblTenKH.BackColor = System.Drawing.Color.Transparent;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTenKH.Location = new System.Drawing.Point(181, 89);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTenKH.Size = new System.Drawing.Size(167, 20);
            this.lblTenKH.TabIndex = 5;
            this.lblTenKH.Text = "Đình Toàn";
            this.lblTenKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.Teal;
            this.label.Location = new System.Drawing.Point(6, 89);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(132, 20);
            this.label.TabIndex = 4;
            this.label.Text = "Tên Khách Hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachThuoc);
            this.groupBox1.Location = new System.Drawing.Point(576, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 399);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thuốc trong hóa đơn";
            // 
            // dgvDanhSachThuoc
            // 
            this.dgvDanhSachThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachThuoc.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachThuoc.Name = "dgvDanhSachThuoc";
            this.dgvDanhSachThuoc.RowHeadersWidth = 51;
            this.dgvDanhSachThuoc.Size = new System.Drawing.Size(576, 374);
            this.dgvDanhSachThuoc.TabIndex = 0;
            // 
            // btnResetKH
            // 
            this.btnResetKH.BackColor = System.Drawing.Color.Transparent;
            this.btnResetKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetKH.ForeColor = System.Drawing.Color.Transparent;
            this.btnResetKH.Image = ((System.Drawing.Image)(resources.GetObject("btnResetKH.Image")));
            this.btnResetKH.Location = new System.Drawing.Point(535, 78);
            this.btnResetKH.Name = "btnResetKH";
            this.btnResetKH.Size = new System.Drawing.Size(35, 35);
            this.btnResetKH.TabIndex = 26;
            this.btnResetKH.UseVisualStyleBackColor = false;
            this.btnResetKH.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 706);
            this.Controls.Add(this.btnResetKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelTren);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvHoaDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panelTren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTren;
        private System.Windows.Forms.Button btnQuanLyThuoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblSDTKH;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblTongVat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNgayLapHD;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachThuoc;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnResetKH;
    }
}