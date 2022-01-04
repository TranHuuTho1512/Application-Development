
using System;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNghiLam = new System.Windows.Forms.RadioButton();
            this.radDLV = new System.Windows.Forms.RadioButton();
            this.btnSuaTT = new System.Windows.Forms.Button();
            this.btnLuuNV = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.panelTren = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.radQuanLy = new System.Windows.Forms.RadioButton();
            this.radNhanVien = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.panelTren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.radNghiLam);
            this.groupBox1.Controls.Add(this.radDLV);
            this.groupBox1.Controls.Add(this.btnSuaTT);
            this.groupBox1.Controls.Add(this.btnLuuNV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Location = new System.Drawing.Point(767, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 626);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // radNghiLam
            // 
            this.radNghiLam.AutoSize = true;
            this.radNghiLam.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radNghiLam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radNghiLam.Location = new System.Drawing.Point(190, 494);
            this.radNghiLam.Name = "radNghiLam";
            this.radNghiLam.Size = new System.Drawing.Size(88, 24);
            this.radNghiLam.TabIndex = 7;
            this.radNghiLam.Text = "Nghỉ làm";
            this.radNghiLam.UseVisualStyleBackColor = true;
            // 
            // radDLV
            // 
            this.radDLV.AutoSize = true;
            this.radDLV.Checked = true;
            this.radDLV.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radDLV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radDLV.Location = new System.Drawing.Point(28, 494);
            this.radDLV.Name = "radDLV";
            this.radDLV.Size = new System.Drawing.Size(126, 24);
            this.radDLV.TabIndex = 6;
            this.radDLV.TabStop = true;
            this.radDLV.Text = "Đang làm việc";
            this.radDLV.UseVisualStyleBackColor = true;
            // 
            // btnSuaTT
            // 
            this.btnSuaTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaTT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSuaTT.FlatAppearance.BorderSize = 0;
            this.btnSuaTT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSuaTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(11)))));
            this.btnSuaTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTT.ForeColor = System.Drawing.Color.White;
            this.btnSuaTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTT.Location = new System.Drawing.Point(66, 531);
            this.btnSuaTT.Name = "btnSuaTT";
            this.btnSuaTT.Size = new System.Drawing.Size(149, 35);
            this.btnSuaTT.TabIndex = 9;
            this.btnSuaTT.Text = "Sửa thông tin";
            this.btnSuaTT.UseVisualStyleBackColor = false;
            this.btnSuaTT.Click += new System.EventHandler(this.btnSuaTT_Click);
            this.btnSuaTT.MouseHover += new System.EventHandler(this.btnSuaTT_MouseHover);
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLuuNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuNV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLuuNV.FlatAppearance.BorderSize = 0;
            this.btnLuuNV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLuuNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(11)))));
            this.btnLuuNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNV.ForeColor = System.Drawing.Color.White;
            this.btnLuuNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuNV.Location = new System.Drawing.Point(221, 531);
            this.btnLuuNV.Name = "btnLuuNV";
            this.btnLuuNV.Size = new System.Drawing.Size(153, 35);
            this.btnLuuNV.TabIndex = 8;
            this.btnLuuNV.Text = "Thêm nhân viên";
            this.btnLuuNV.UseVisualStyleBackColor = false;
            this.btnLuuNV.Click += new System.EventHandler(this.btnLuuNV_Click);
            this.btnLuuNV.MouseHover += new System.EventHandler(this.btnLuuNV_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(20, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "CMND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(22, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(22, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(22, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(22, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại";
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(20, 354);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(352, 29);
            this.txtCMND.TabIndex = 4;
            this.txtCMND.Validating += new System.ComponentModel.CancelEventHandler(this.txtCMND_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(22, 297);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 29);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(22, 411);
            this.txtMK.Name = "txtMK";
            this.txtMK.ShortcutsEnabled = false;
            this.txtMK.Size = new System.Drawing.Size(352, 29);
            this.txtMK.TabIndex = 5;
            this.txtMK.Validating += new System.ComponentModel.CancelEventHandler(this.txtMK_Validating);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(22, 172);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(352, 29);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiaChi_Validating);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(22, 231);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(352, 29);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtSDT_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(22, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(22, 113);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(352, 29);
            this.txtTenNV.TabIndex = 0;
            this.txtTenNV.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenNV_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(22, 54);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(352, 29);
            this.txtMaNV.TabIndex = 14;
            // 
            // dgvDanhSachNhanVien
            // 
            this.dgvDanhSachNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(16, 132);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.RowHeadersWidth = 51;
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(737, 567);
            this.dgvDanhSachNhanVien.TabIndex = 5;
            this.dgvDanhSachNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick_1);
            // 
            // panelTren
            // 
            this.panelTren.Controls.Add(this.btnNhanVien);
            this.panelTren.Controls.Add(this.panel2);
            this.panelTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTren.Location = new System.Drawing.Point(0, 0);
            this.panelTren.Name = "panelTren";
            this.panelTren.Size = new System.Drawing.Size(1170, 51);
            this.panelTren.TabIndex = 6;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(191)))));
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(11)))));
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(163, 50);
            this.btnNhanVien.TabIndex = 22;
            this.btnNhanVien.Text = "NHÂN VIÊN";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
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
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNV.Location = new System.Drawing.Point(16, 91);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(737, 35);
            this.txtTimKiemNV.TabIndex = 0;
            this.txtTimKiemNV.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(12, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tìm kiếm nhân viên";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radQuanLy);
            this.panel1.Controls.Add(this.radNhanVien);
            this.panel1.Location = new System.Drawing.Point(22, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 44);
            this.panel1.TabIndex = 15;
            // 
            // radQuanLy
            // 
            this.radQuanLy.AutoSize = true;
            this.radQuanLy.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radQuanLy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radQuanLy.Location = new System.Drawing.Point(168, 8);
            this.radQuanLy.Name = "radQuanLy";
            this.radQuanLy.Size = new System.Drawing.Size(80, 24);
            this.radQuanLy.TabIndex = 9;
            this.radQuanLy.Text = "Quản lý";
            this.radQuanLy.UseVisualStyleBackColor = true;
            // 
            // radNhanVien
            // 
            this.radNhanVien.AutoSize = true;
            this.radNhanVien.Checked = true;
            this.radNhanVien.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radNhanVien.Location = new System.Drawing.Point(6, 8);
            this.radNhanVien.Name = "radNhanVien";
            this.radNhanVien.Size = new System.Drawing.Size(97, 24);
            this.radNhanVien.TabIndex = 8;
            this.radNhanVien.TabStop = true;
            this.radNhanVien.Text = "Nhân viên";
            this.radNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.Transparent;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(24, 531);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(36, 35);
            this.btnReset.TabIndex = 1;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 706);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimKiemNV);
            this.Controls.Add(this.panelTren);
            this.Controls.Add(this.dgvDanhSachNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNhanVien_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.panelTren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panelTren_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSuaTT;
        private System.Windows.Forms.Button btnLuuNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private System.Windows.Forms.Panel panelTren;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radNghiLam;
        private System.Windows.Forms.RadioButton radDLV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCMND;
        private ErrorProvider err;
        private Panel panel1;
        private RadioButton radQuanLy;
        private RadioButton radNhanVien;
        private Button btnReset;
    }
}