namespace QuanLyNhaThuoc
{
    partial class frmLoThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoThuoc));
            this.dateHSD = new System.Windows.Forms.DateTimePicker();
            this.dateNSX = new System.Windows.Forms.DateTimePicker();
            this.btnSuaLoThuoc = new System.Windows.Forms.Button();
            this.btnThemLoThuoc = new System.Windows.Forms.Button();
            this.txtMoTaThuoc = new System.Windows.Forms.RichTextBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtLieuLuongDung = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtGiaBanLe = new System.Windows.Forms.TextBox();
            this.txtGiaBanChan = new System.Windows.Forms.TextBox();
            this.txtTyLeQuyDoi = new System.Windows.Forms.TextBox();
            this.txtLoThuoc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachLoThuoc = new System.Windows.Forms.DataGridView();
            this.panelTren = new System.Windows.Forms.Panel();
            this.btnQuanLyThuoc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemSLTon = new System.Windows.Forms.Button();
            this.cboDVQD = new System.Windows.Forms.ComboBox();
            this.cboXX = new System.Windows.Forms.ComboBox();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnResetLoThuoc = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoThuoc)).BeginInit();
            this.panelTren.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // dateHSD
            // 
            this.dateHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHSD.Location = new System.Drawing.Point(141, 374);
            this.dateHSD.Name = "dateHSD";
            this.dateHSD.Size = new System.Drawing.Size(251, 26);
            this.dateHSD.TabIndex = 12;
            this.dateHSD.Validating += new System.ComponentModel.CancelEventHandler(this.dateHSD_Validating);
            // 
            // dateNSX
            // 
            this.dateNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNSX.Location = new System.Drawing.Point(141, 344);
            this.dateNSX.Name = "dateNSX";
            this.dateNSX.Size = new System.Drawing.Size(250, 26);
            this.dateNSX.TabIndex = 11;
            this.dateNSX.Validating += new System.ComponentModel.CancelEventHandler(this.dateNSX_Validating);
            // 
            // btnSuaLoThuoc
            // 
            this.btnSuaLoThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaLoThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaLoThuoc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSuaLoThuoc.FlatAppearance.BorderSize = 0;
            this.btnSuaLoThuoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSuaLoThuoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(11)))));
            this.btnSuaLoThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLoThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoThuoc.ForeColor = System.Drawing.Color.White;
            this.btnSuaLoThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaLoThuoc.Location = new System.Drawing.Point(47, 605);
            this.btnSuaLoThuoc.Name = "btnSuaLoThuoc";
            this.btnSuaLoThuoc.Size = new System.Drawing.Size(163, 35);
            this.btnSuaLoThuoc.TabIndex = 17;
            this.btnSuaLoThuoc.Text = "Sửa Lô";
            this.btnSuaLoThuoc.UseVisualStyleBackColor = false;
            this.btnSuaLoThuoc.Click += new System.EventHandler(this.btnSuaLoThuoc_Click);
            this.btnSuaLoThuoc.MouseHover += new System.EventHandler(this.btnSuaLoThuoc_MouseHover);
            // 
            // btnThemLoThuoc
            // 
            this.btnThemLoThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemLoThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemLoThuoc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThemLoThuoc.FlatAppearance.BorderSize = 0;
            this.btnThemLoThuoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThemLoThuoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(11)))));
            this.btnThemLoThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoThuoc.ForeColor = System.Drawing.Color.White;
            this.btnThemLoThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLoThuoc.Location = new System.Drawing.Point(216, 605);
            this.btnThemLoThuoc.Name = "btnThemLoThuoc";
            this.btnThemLoThuoc.Size = new System.Drawing.Size(176, 35);
            this.btnThemLoThuoc.TabIndex = 16;
            this.btnThemLoThuoc.Text = "Thêm Lô";
            this.btnThemLoThuoc.UseVisualStyleBackColor = false;
            this.btnThemLoThuoc.Click += new System.EventHandler(this.btnThemLoThuoc_Click);
            this.btnThemLoThuoc.MouseHover += new System.EventHandler(this.btnThemLoThuoc_MouseHover);
            // 
            // txtMoTaThuoc
            // 
            this.txtMoTaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTaThuoc.Location = new System.Drawing.Point(142, 506);
            this.txtMoTaThuoc.Name = "txtMoTaThuoc";
            this.txtMoTaThuoc.Size = new System.Drawing.Size(250, 95);
            this.txtMoTaThuoc.TabIndex = 15;
            this.txtMoTaThuoc.Text = "";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(142, 474);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.ReadOnly = true;
            this.txtSoLuongTon.Size = new System.Drawing.Size(250, 26);
            this.txtSoLuongTon.TabIndex = 14;
            // 
            // txtLieuLuongDung
            // 
            this.txtLieuLuongDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLieuLuongDung.Location = new System.Drawing.Point(141, 408);
            this.txtLieuLuongDung.Name = "txtLieuLuongDung";
            this.txtLieuLuongDung.Size = new System.Drawing.Size(250, 26);
            this.txtLieuLuongDung.TabIndex = 13;
            // 
            // txtVAT
            // 
            this.txtVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.Location = new System.Drawing.Point(141, 312);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(250, 26);
            this.txtVAT.TabIndex = 10;
            this.txtVAT.Validating += new System.ComponentModel.CancelEventHandler(this.txtVAT_Validating);
            // 
            // txtGiaBanLe
            // 
            this.txtGiaBanLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBanLe.Location = new System.Drawing.Point(141, 280);
            this.txtGiaBanLe.Name = "txtGiaBanLe";
            this.txtGiaBanLe.Size = new System.Drawing.Size(250, 26);
            this.txtGiaBanLe.TabIndex = 9;
            this.txtGiaBanLe.Validating += new System.ComponentModel.CancelEventHandler(this.txtGiaBanLe_Validating);
            // 
            // txtGiaBanChan
            // 
            this.txtGiaBanChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBanChan.Location = new System.Drawing.Point(141, 248);
            this.txtGiaBanChan.Name = "txtGiaBanChan";
            this.txtGiaBanChan.Size = new System.Drawing.Size(250, 26);
            this.txtGiaBanChan.TabIndex = 8;
            this.txtGiaBanChan.Validating += new System.ComponentModel.CancelEventHandler(this.txtGiaBanChan_Validating);
            // 
            // txtTyLeQuyDoi
            // 
            this.txtTyLeQuyDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTyLeQuyDoi.Location = new System.Drawing.Point(141, 216);
            this.txtTyLeQuyDoi.Name = "txtTyLeQuyDoi";
            this.txtTyLeQuyDoi.Size = new System.Drawing.Size(250, 26);
            this.txtTyLeQuyDoi.TabIndex = 7;
            this.txtTyLeQuyDoi.Validating += new System.ComponentModel.CancelEventHandler(this.txtTyLeQuyDoi_Validating);
            // 
            // txtLoThuoc
            // 
            this.txtLoThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoThuoc.Location = new System.Drawing.Point(141, 25);
            this.txtLoThuoc.Name = "txtLoThuoc";
            this.txtLoThuoc.ReadOnly = true;
            this.txtLoThuoc.Size = new System.Drawing.Size(250, 26);
            this.txtLoThuoc.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(11, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Số lượng tồn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(11, 509);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Mô tả";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(11, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "VAT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(10, 411);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Liều lượng dùng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Teal;
            this.label16.Location = new System.Drawing.Point(10, 379);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Hạn sử dụng";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Teal;
            this.label17.Location = new System.Drawing.Point(10, 347);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "Ngày sản xuất";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Teal;
            this.label18.Location = new System.Drawing.Point(10, 283);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 19;
            this.label18.Text = "Giá bán lẻ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(10, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giá bán chẵn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(10, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tỷ lệ quy đổi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(10, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Đơn vị quy đổi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(10, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(11, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Xuất xứ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(10, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Teal;
            this.label19.Location = new System.Drawing.Point(10, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Lô thuốc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachLoThuoc);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 575);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LÔ THUỐC";
            // 
            // dgvDanhSachLoThuoc
            // 
            this.dgvDanhSachLoThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachLoThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLoThuoc.Location = new System.Drawing.Point(0, 22);
            this.dgvDanhSachLoThuoc.Name = "dgvDanhSachLoThuoc";
            this.dgvDanhSachLoThuoc.Size = new System.Drawing.Size(731, 530);
            this.dgvDanhSachLoThuoc.TabIndex = 0;
            this.dgvDanhSachLoThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLoThuoc_CellContentClick);
            // 
            // panelTren
            // 
            this.panelTren.Controls.Add(this.btnQuanLyThuoc);
            this.panelTren.Controls.Add(this.panel2);
            this.panelTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTren.Location = new System.Drawing.Point(0, 0);
            this.panelTren.Name = "panelTren";
            this.panelTren.Size = new System.Drawing.Size(1170, 51);
            this.panelTren.TabIndex = 64;
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
            this.btnQuanLyThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyThuoc.Image")));
            this.btnQuanLyThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThuoc.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLyThuoc.Name = "btnQuanLyThuoc";
            this.btnQuanLyThuoc.Size = new System.Drawing.Size(226, 50);
            this.btnQuanLyThuoc.TabIndex = 23;
            this.btnQuanLyThuoc.Text = "THÔNG TIN LÔ THUỐC";
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
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(12, 86);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(731, 35);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(8, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tìm kiếm thuốc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetLoThuoc);
            this.groupBox1.Controls.Add(this.btnThemSLTon);
            this.groupBox1.Controls.Add(this.cboDVQD);
            this.groupBox1.Controls.Add(this.cboXX);
            this.groupBox1.Controls.Add(this.cboDVT);
            this.groupBox1.Controls.Add(this.txtMaThuoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateHSD);
            this.groupBox1.Controls.Add(this.dateNSX);
            this.groupBox1.Controls.Add(this.btnSuaLoThuoc);
            this.groupBox1.Controls.Add(this.btnThemLoThuoc);
            this.groupBox1.Controls.Add(this.txtMoTaThuoc);
            this.groupBox1.Controls.Add(this.txtSoLuongNhap);
            this.groupBox1.Controls.Add(this.txtSoLuongTon);
            this.groupBox1.Controls.Add(this.txtLieuLuongDung);
            this.groupBox1.Controls.Add(this.txtVAT);
            this.groupBox1.Controls.Add(this.txtGiaBanLe);
            this.groupBox1.Controls.Add(this.txtGiaBanChan);
            this.groupBox1.Controls.Add(this.txtNCC);
            this.groupBox1.Controls.Add(this.txtTyLeQuyDoi);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtLoThuoc);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(755, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 643);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN THUỐC";
            // 
            // btnThemSLTon
            // 
            this.btnThemSLTon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemSLTon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSLTon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThemSLTon.FlatAppearance.BorderSize = 0;
            this.btnThemSLTon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThemSLTon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(11)))));
            this.btnThemSLTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSLTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSLTon.ForeColor = System.Drawing.Color.White;
            this.btnThemSLTon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSLTon.Location = new System.Drawing.Point(303, 442);
            this.btnThemSLTon.Name = "btnThemSLTon";
            this.btnThemSLTon.Size = new System.Drawing.Size(88, 28);
            this.btnThemSLTon.TabIndex = 74;
            this.btnThemSLTon.Text = "Thêm SL";
            this.btnThemSLTon.UseVisualStyleBackColor = false;
            this.btnThemSLTon.Click += new System.EventHandler(this.btnThemSLTon_Click);
            // 
            // cboDVQD
            // 
            this.cboDVQD.FormattingEnabled = true;
            this.cboDVQD.Location = new System.Drawing.Point(141, 183);
            this.cboDVQD.Name = "cboDVQD";
            this.cboDVQD.Size = new System.Drawing.Size(250, 28);
            this.cboDVQD.TabIndex = 73;
            this.cboDVQD.Validating += new System.ComponentModel.CancelEventHandler(this.cboDVQD_Validating);
            // 
            // cboXX
            // 
            this.cboXX.FormattingEnabled = true;
            this.cboXX.Location = new System.Drawing.Point(141, 116);
            this.cboXX.Name = "cboXX";
            this.cboXX.Size = new System.Drawing.Size(250, 28);
            this.cboXX.TabIndex = 73;
            this.cboXX.Validating += new System.ComponentModel.CancelEventHandler(this.cboXX_Validating);
            // 
            // cboDVT
            // 
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.Location = new System.Drawing.Point(141, 149);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(250, 28);
            this.cboDVT.TabIndex = 73;
            this.cboDVT.Validating += new System.ComponentModel.CancelEventHandler(this.cboDVT_Validating);
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuoc.Location = new System.Drawing.Point(141, 55);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(251, 26);
            this.txtMaThuoc.TabIndex = 1;
            this.txtMaThuoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMaThuoc_MouseClick);
            this.txtMaThuoc.TextChanged += new System.EventHandler(this.txtMaThuoc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Mã thuốc";
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongNhap.Location = new System.Drawing.Point(141, 442);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(143, 26);
            this.txtSoLuongNhap.TabIndex = 14;
            this.txtSoLuongNhap.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoLuongNhap_Validating);
            // 
            // txtNCC
            // 
            this.txtNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCC.Location = new System.Drawing.Point(141, 87);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(250, 26);
            this.txtNCC.TabIndex = 4;
            this.txtNCC.TextChanged += new System.EventHandler(this.txtNCC_TextChanged);
            this.txtNCC.Validating += new System.ComponentModel.CancelEventHandler(this.txtNCC_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(10, 445);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Số lượng nhập";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnResetLoThuoc
            // 
            this.btnResetLoThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetLoThuoc.ForeColor = System.Drawing.Color.Transparent;
            this.btnResetLoThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnResetLoThuoc.Image")));
            this.btnResetLoThuoc.Location = new System.Drawing.Point(6, 602);
            this.btnResetLoThuoc.Name = "btnResetLoThuoc";
            this.btnResetLoThuoc.Size = new System.Drawing.Size(35, 35);
            this.btnResetLoThuoc.TabIndex = 65;
            this.btnResetLoThuoc.UseVisualStyleBackColor = true;
            this.btnResetLoThuoc.Click += new System.EventHandler(this.btnResetLoThuoc_Click);
            // 
            // frmLoThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelTren);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLoThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmLoThuoc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLoThuoc_KeyDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoThuoc)).EndInit();
            this.panelTren.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateHSD;
        private System.Windows.Forms.DateTimePicker dateNSX;
        private System.Windows.Forms.Button btnSuaLoThuoc;
        private System.Windows.Forms.Button btnThemLoThuoc;
        private System.Windows.Forms.RichTextBox txtMoTaThuoc;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtLieuLuongDung;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtGiaBanLe;
        private System.Windows.Forms.TextBox txtGiaBanChan;
        private System.Windows.Forms.TextBox txtTyLeQuyDoi;
        private System.Windows.Forms.TextBox txtLoThuoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachLoThuoc;
        private System.Windows.Forms.Panel panelTren;
        private System.Windows.Forms.Button btnQuanLyThuoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.ComboBox cboDVQD;
        private System.Windows.Forms.ComboBox cboXX;
        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Button btnThemSLTon;
        private System.Windows.Forms.Button btnResetLoThuoc;
    }
}