namespace QuanLyNhaThuoc
{
    partial class frmKhachHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiemKH = new System.Windows.Forms.TextBox();
            this.btnQuanLyThuoc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSachKH = new System.Windows.Forms.DataGridView();
            this.panelTren = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnResetKH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKH)).BeginInit();
            this.panelTren.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(756, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tìm khách hàng";
            // 
            // txtTimKiemKH
            // 
            this.txtTimKiemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemKH.Location = new System.Drawing.Point(760, 83);
            this.txtTimKiemKH.Name = "txtTimKiemKH";
            this.txtTimKiemKH.Size = new System.Drawing.Size(351, 35);
            this.txtTimKiemKH.TabIndex = 18;
            this.txtTimKiemKH.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
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
            this.btnQuanLyThuoc.Text = "KHÁCH HÀNG";
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
            this.panel2.TabIndex = 21;
            // 
            // dgvDanhSachKH
            // 
            this.dgvDanhSachKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKH.Location = new System.Drawing.Point(12, 60);
            this.dgvDanhSachKH.Name = "dgvDanhSachKH";
            this.dgvDanhSachKH.RowHeadersWidth = 51;
            this.dgvDanhSachKH.Size = new System.Drawing.Size(738, 639);
            this.dgvDanhSachKH.TabIndex = 17;
            this.dgvDanhSachKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick_1);
            // 
            // panelTren
            // 
            this.panelTren.Controls.Add(this.btnQuanLyThuoc);
            this.panelTren.Controls.Add(this.panel2);
            this.panelTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTren.Location = new System.Drawing.Point(0, 0);
            this.panelTren.Name = "panelTren";
            this.panelTren.Size = new System.Drawing.Size(1170, 51);
            this.panelTren.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuaKH);
            this.groupBox1.Controls.Add(this.btnLuuKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Location = new System.Drawing.Point(761, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 575);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaKH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSuaKH.FlatAppearance.BorderSize = 0;
            this.btnSuaKH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSuaKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(11)))));
            this.btnSuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKH.ForeColor = System.Drawing.Color.White;
            this.btnSuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaKH.Location = new System.Drawing.Point(10, 328);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(191, 35);
            this.btnSuaKH.TabIndex = 7;
            this.btnSuaKH.Text = "Cập nhật thông tin";
            this.btnSuaKH.UseVisualStyleBackColor = false;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            this.btnSuaKH.MouseHover += new System.EventHandler(this.btnSuaKH_MouseHover);
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLuuKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuKH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLuuKH.FlatAppearance.BorderSize = 0;
            this.btnLuuKH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLuuKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(11)))));
            this.btnLuuKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuKH.ForeColor = System.Drawing.Color.White;
            this.btnLuuKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuKH.Location = new System.Drawing.Point(207, 328);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(184, 35);
            this.btnLuuKH.TabIndex = 6;
            this.btnLuuKH.Text = "Thêm khách hàng";
            this.btnLuuKH.UseVisualStyleBackColor = false;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuuKH_Click);
            this.btnLuuKH.MouseHover += new System.EventHandler(this.btnLuuKH_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(9, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(6, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(9, 277);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(385, 29);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(6, 216);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(385, 29);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiaChi_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(6, 43);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(385, 29);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(6, 104);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(385, 29);
            this.txtTenKH.TabIndex = 2;
            this.txtTenKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenKH_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(6, 161);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(385, 29);
            this.txtSDT.TabIndex = 3;
            this.txtSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtSDT_Validating);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnResetKH
            // 
            this.btnResetKH.BackColor = System.Drawing.Color.Transparent;
            this.btnResetKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetKH.ForeColor = System.Drawing.Color.Transparent;
            this.btnResetKH.Image = ((System.Drawing.Image)(resources.GetObject("btnResetKH.Image")));
            this.btnResetKH.Location = new System.Drawing.Point(1117, 83);
            this.btnResetKH.Name = "btnResetKH";
            this.btnResetKH.Size = new System.Drawing.Size(35, 35);
            this.btnResetKH.TabIndex = 25;
            this.btnResetKH.UseVisualStyleBackColor = false;
            this.btnResetKH.Click += new System.EventHandler(this.btnResetKH_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 706);
            this.Controls.Add(this.btnResetKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimKiemKH);
            this.Controls.Add(this.dgvDanhSachKH);
            this.Controls.Add(this.panelTren);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKhachHang_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKH)).EndInit();
            this.panelTren.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiemKH;
        private System.Windows.Forms.Button btnQuanLyThuoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhSachKH;
        private System.Windows.Forms.Panel panelTren;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnResetKH;
    }
}