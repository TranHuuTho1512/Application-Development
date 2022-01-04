using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLyNhaThuoc;
using BUS_QuanLyNhaThuoc;
using DAL_QuanLyNhaThuoc;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using System.IO;
namespace QuanLyNhaThuoc
{
    public partial class frmBanThuoc : Form
    {
        private Form activeForm;
        public frmBanThuoc()
        {
            InitializeComponent();
            //
            //btnThemKhachHang.Click = btnThemKhachHang_Click;
            //
            DateTime d = DateTime.Now;
            dateNgayBan.Value = d;
            this.KeyPreview = true;
            btnThemVaoHoaDon.Enabled = false;
            btnXoaKhoiHoaDon.Enabled = false;
            btnThanhToan.Enabled = false;
            btnHuyHoaDon.Enabled = false;
            txtTimKiem.Enabled = false;
            TaoMaTuDongHD();


        }
        string manv = frmDangNhap.maNhanVien;
        BUS_BanThuoc lhd = new BUS_BanThuoc();
        TreeNode nGoc;
        BUS_NhomThuoc lnt = new BUS_NhomThuoc();
        BUS_HoaDon lcthd = new BUS_HoaDon();
        BUS_KhachHang lkh = new BUS_KhachHang();
        void TaoTreNode(TreeView tre)
        {
            tre.Nodes.Clear();
            List<DTO_NhomThuoc> dsnt = lnt.LayHetNhomThuoc();
            TreeNode pNode;
            foreach (var item in dsnt)
            {
                pNode = new TreeNode();
                pNode.Text = item.TenNhomThuoc;
                pNode.Tag = item.MaNhomThuoc;
                nGoc.Nodes.Add(pNode);
            }
            tre.Nodes.Add(nGoc);
            tre.ExpandAll();
        }
        private void FormatBanThuoc()
        {
            dgvThuocTimKiem.Columns["maThuoc"].HeaderText = "Mã Thuốc";
            dgvThuocTimKiem.Columns["maThuoc"].Width = 135;
            dgvThuocTimKiem.Columns["tenThuoc"].HeaderText = "Tên Thuốc";
            dgvThuocTimKiem.Columns["tenThuoc"].Width = 135;
            dgvThuocTimKiem.Columns["hoatChatChinh"].HeaderText = "Hoạt Chất Chính";
            dgvThuocTimKiem.Columns["hoatChatChinh"].Width = 160;
            dgvThuocTimKiem.Columns["loaiThuoc"].HeaderText = "Loại Thuốc";
            dgvThuocTimKiem.Columns["loaiThuoc"].Width = 145;
            dgvThuocTimKiem.Columns["maNhomThuoc"].Visible = false;
            dgvThuocTimKiem.Columns["tenNhomThuoc"].HeaderText = "Tên Nhóm Thuốc";
            dgvThuocTimKiem.Columns["tenNhomThuoc"].Width = 160;
            dgvThuocTimKiem.Columns["donViTinh"].HeaderText = "Đơn Vị Tính";
            dgvThuocTimKiem.Columns["donViTinh"].Width = 145;
            dgvThuocTimKiem.Columns["giaBanChan"].HeaderText = "Giá Bán Chẵn";
            dgvThuocTimKiem.Columns["giaBanChan"].Width = 145;
            dgvThuocTimKiem.Columns["donViQuyDoi"].HeaderText = "Đơn Vị Quy Đổi";
            dgvThuocTimKiem.Columns["donViQuyDoi"].Width = 150;
            dgvThuocTimKiem.Columns["giaBanLe"].HeaderText = "Giá Bán Lẻ";
            dgvThuocTimKiem.Columns["giaBanLe"].Width = 140;
            dgvThuocTimKiem.Columns["tyLeQuyDoi"].HeaderText = "Tỷ Lệ Quy Đổi";
            dgvThuocTimKiem.Columns["tyLeQuyDoi"].Width = 160;
            dgvThuocTimKiem.Columns["ngaySanXuat"].HeaderText = "Ngày Sản Xuất";
            dgvThuocTimKiem.Columns["ngaySanXuat"].Width = 150;
            dgvThuocTimKiem.Columns["hanSuDung"].HeaderText = "Hạn Sử Dụng";
            dgvThuocTimKiem.Columns["hanSuDung"].Width = 150;
            dgvThuocTimKiem.Columns["soLuongTon"].HeaderText = "Số Lượng Tồn";
            dgvThuocTimKiem.Columns["soLuongTon"].Width = 145;
            dgvThuocTimKiem.Columns["moTa"].HeaderText = "Mô Tả";
            dgvThuocTimKiem.Columns["moTa"].Width = 180;
            dgvThuocTimKiem.Columns["maLoThuoc"].Visible = false;
            dgvThuocTimKiem.Columns["vAT"].HeaderText = "VAT";
            dgvThuocTimKiem.Columns["vAT"].Width = 110;
            dgvThuocTimKiem.Columns["xuatXu"].HeaderText = "Xuất Xứ";
            dgvThuocTimKiem.Columns["xuatXu"].Width = 140;
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelTimKiemThayDoi.Controls.Add(childForm);
            this.panelTimKiemThayDoi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // tạo mã tự động
        private void TaoMaTuDongHD()
        {

            int value = lhd.SoHoaDon();
            if (value + 1 < 10)
            {
                lblMaHoaDon.Text = "HD000000000" + (value + 1).ToString();
            }
            else if (value + 1 < 100)
            {
                lblMaHoaDon.Text = "HD00000000" + (value + 1).ToString();
            }
            else if (value + 1 < 1000)
            {
                lblMaHoaDon.Text = "HD0000000" + (value + 1).ToString();
            }
            else if (value + 1 < 10000)
            {
                lblMaHoaDon.Text = "HD000000" + (value + 1).ToString();
            }
            else if (value + 1 < 100000)
            {
                lblMaHoaDon.Text = "HD00000" + (value + 1).ToString();
            }
            else if (value + 1 < 1000000)
            {
                lblMaHoaDon.Text = "HD0000" + (value + 1).ToString();
            }
            else if (value + 1 < 10000000)
            {
                lblMaHoaDon.Text = "HD000" + (value + 1).ToString();
            }
            else if (value + 1 < 100000000)
            {
                lblMaHoaDon.Text = "HD00" + (value + 1).ToString();
            }
            else if (value + 1 < 1000000000)
            {
                lblMaHoaDon.Text = "HD0" + (value + 1).ToString();
            }
            else if (value + 1 == 1000000000)
            {
                lblMaHoaDon.Text = "HD" + (value + 1).ToString();
            }
        }
        private void frmBanThuoc_Load(object sender, EventArgs e)
        {
            // autoplete
            txtSoDienThoaiKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSoDienThoaiKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;           
            nGoc = new TreeNode("Tên Nhóm Thuốc");
            TaoTreNode(treNhomThuoc);
        }




        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.khevent += F_khevent;
            f.ShowDialog();
            this.Show();
            
        }

        private void F_khevent(string sdt)
        {
            txtSoDienThoaiKH.Text = sdt.ToString();
        }

        private void treNhomThuoc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtTimKiem.Enabled = true;
            string mant = Convert.ToString(treNhomThuoc.SelectedNode.Tag);
            List<DTO_BanThuoc> dsbttn = lhd.LayThongTinThuocTheoNhom(mant);
            dgvThuocTimKiem.DataSource = dsbttn;
            if (dsbttn!=null)
            {
                FormatBanThuoc();
            }
            else
            {
                MessageBox.Show("Không có thuốc, Cần có thông tin Lô thuốc!","Thông báo");
            }
        }
        // Tìm kiếm thuốc theo mã và tên

        void assistant_Idled11(object sender, EventArgs e)
        {
            this.Invoke(
            new MethodInvoker(() =>
            {
                string mant = "";
                mant = Convert.ToString(treNhomThuoc.SelectedNode.Tag);
                dgvThuocTimKiem.DataSource = lhd.TimKiemThuocTheoTenMa(txtTimKiem.Text, mant);
                if (dgvThuocTimKiem.RowCount != 0)
                {
                    FormatBanThuoc();
                }
            }));
        }
        TypeAssistant assistant;

        // Thay Đổi Theo Thời Gian
        public class TypeAssistant
        {
            public event EventHandler Idled = delegate { };
            public int WaitingMilliSeconds { get; set; }
            System.Threading.Timer waitingTimer;

            public TypeAssistant(int waitingMilliSeconds = 300)
            {
                WaitingMilliSeconds = waitingMilliSeconds;
                waitingTimer = new System.Threading.Timer(p =>
                {
                    Idled(this, EventArgs.Empty);
                });
            }
            public void TextChanged()
            {
                waitingTimer.Change(WaitingMilliSeconds, System.Threading.Timeout.Infinite);
            }
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            int delay = 1000;
            assistant = new TypeAssistant(delay);
            assistant.Idled += assistant_Idled11;
            assistant.TextChanged();
        }

        private void dgvThuocTimKiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TaoMaTuDongHD();
            int h = dgvThuocTimKiem.CurrentRow.Index;
            lblMaThuoc.Text = dgvThuocTimKiem.Rows[h].Cells[0].Value.ToString();
            lblTenThuoc.Text = dgvThuocTimKiem.Rows[h].Cells[1].Value.ToString();
            if (dgvThuocTimKiem.Rows[h].Cells[3].Value.ToString() == "Thuốc Kê Đơn")
            {
                radBanTheoDon.Checked = true;
            }
            else radBanKhongTheoDon.Checked = true;
            lblNgaySanXuat.Text = dgvThuocTimKiem.Rows[h].Cells[11].Value.ToString();
            lblHanSuDung.Text = dgvThuocTimKiem.Rows[h].Cells[12].Value.ToString();
            radDonViBanChan.Text = dgvThuocTimKiem.Rows[h].Cells[6].Value.ToString();
            radDonViBanLe.Text = dgvThuocTimKiem.Rows[h].Cells[8].Value.ToString();
            lblMaLoThuoc.Text = dgvThuocTimKiem.Rows[h].Cells[15].Value.ToString();
            lblVAT.Text = dgvThuocTimKiem.Rows[h].Cells[16].Value.ToString();
            txtMoTaThuoc.Text = dgvThuocTimKiem.Rows[h].Cells[14].Value.ToString();
            radDonViBanChan_CheckedChanged(sender, e);
            radDonViBanLe_CheckedChanged(sender, e);
            btnThemVaoHoaDon.Enabled = true;
        }

        private void radDonViBanChan_CheckedChanged(object sender, EventArgs e)
        {
            int tlqd;
            List<DTO_BanThuoc> dslt = lhd.LayThongTinThuoc();
            foreach (var item in dslt)
            {
                if (item.MaLoThuoc == lblMaLoThuoc.Text)
                {
                    tlqd = item.TyLeQuyDoi;
                    lblSoLuongTon.Text = Convert.ToString(item.SoLuongTon / tlqd);
                    lblGiaThuoc.Text = Convert.ToString(item.GiaBanChan);
                }
            }
        }

        private void radDonViBanLe_CheckedChanged(object sender, EventArgs e)
        {
            List<DTO_BanThuoc> dslt = lhd.LayThongTinThuoc();
            foreach (var item in dslt)
            {
                if (item.MaLoThuoc == lblMaLoThuoc.Text)
                {
                    lblSoLuongTon.Text = Convert.ToString(item.SoLuongTon);
                    lblGiaThuoc.Text = Convert.ToString(item.GiaBanLe);
                }
            }
        }
        // Load Data vào DataGridView
        private void LoadDataVaoGrid()
        {
            // Thêm Cột DataGridView
            dgvThuocTrongHoaDon.ColumnCount = 9;
            dgvThuocTrongHoaDon.Columns[0].Name = "STT";
            dgvThuocTrongHoaDon.Columns[1].Name = "Medicine";
            dgvThuocTrongHoaDon.Columns[1].Width = 130;
            dgvThuocTrongHoaDon.Columns[2].Name = "Unit";
            dgvThuocTrongHoaDon.Columns[2].Width = 130;
            dgvThuocTrongHoaDon.Columns[3].Name = "Number";
            dgvThuocTrongHoaDon.Columns[3].Width = 130;
            dgvThuocTrongHoaDon.Columns[4].Name = "Unit Price";
            dgvThuocTrongHoaDon.Columns[4].Width = 130;
            dgvThuocTrongHoaDon.Columns[5].Name = "Money";
            dgvThuocTrongHoaDon.Columns[5].Width = 140;
            dgvThuocTrongHoaDon.Columns[6].Visible = false;
            dgvThuocTrongHoaDon.Columns[7].Visible = false;
            dgvThuocTrongHoaDon.Columns[8].Visible = false;
            dgvThuocTrongHoaDon.Columns[6].Name = "Batch ID";
            dgvThuocTrongHoaDon.Columns[6].Width = 250;
            dgvThuocTrongHoaDon.Columns[7].Name = "Medicine ID";
            dgvThuocTrongHoaDon.Columns[7].Width = 250;
            dgvThuocTrongHoaDon.Columns[8].Name = "VAT";
            dgvThuocTrongHoaDon.Columns[8].Width = 120;
            // Thêm Thuốc Vào DataGridView
            int h;
            h = dgvThuocTrongHoaDon.RowCount + 1;
            string[] row1;
            if (radDonViBanChan.Checked == true)
            {
                row1 = new string[] { (h).ToString(), lblTenThuoc.Text, radDonViBanChan.Text, nubSoLuongMua.Value.ToString(), lblGiaThuoc.Text, Convert.ToString(Convert.ToInt32(nubSoLuongMua.Value) * Convert.ToDouble(lblGiaThuoc.Text)), lblMaLoThuoc.Text, lblMaThuoc.Text, lblVAT.Text };
                dgvThuocTrongHoaDon.Rows.Add(row1);
                lblTongVAT.Text = Convert.ToString(Convert.ToDouble(lblTongVAT.Text) + (Convert.ToInt32(nubSoLuongMua.Value) * Convert.ToDouble(lblGiaThuoc.Text) * (Convert.ToDouble(lblVAT.Text) / 100)));
                lblTongTienHoaDon.Text = Convert.ToString(Convert.ToDouble(lblTongTienHoaDon.Text) + (Convert.ToInt32(nubSoLuongMua.Value) * Convert.ToDouble(lblGiaThuoc.Text)));
                lblKhachCanTra.Text = Convert.ToString(Convert.ToDouble(lblTongTienHoaDon.Text) + Convert.ToDouble(lblTongVAT.Text));

            }
            else
            {
                row1 = new string[] { (h).ToString(), lblTenThuoc.Text, radDonViBanLe.Text, nubSoLuongMua.Value.ToString(), lblGiaThuoc.Text, Convert.ToString(Convert.ToInt32(nubSoLuongMua.Value) * Convert.ToDouble(lblGiaThuoc.Text)), lblMaLoThuoc.Text, lblMaThuoc.Text, lblVAT.Text };
                dgvThuocTrongHoaDon.Rows.Add(row1);
                lblTongVAT.Text = Convert.ToString(Convert.ToDouble(lblTongVAT.Text) + (Convert.ToInt32(nubSoLuongMua.Value) * Convert.ToDouble(lblGiaThuoc.Text) * (Convert.ToDouble(lblVAT.Text) / 100)));
                lblTongTienHoaDon.Text = Convert.ToString(Convert.ToDouble(lblTongTienHoaDon.Text) + (Convert.ToInt32(nubSoLuongMua.Value) * Convert.ToDouble(lblGiaThuoc.Text)));
                lblKhachCanTra.Text = Convert.ToString(Convert.ToDouble(lblTongTienHoaDon.Text) + Convert.ToDouble(lblTongVAT.Text));
            }
        }

        private void btnThemVaoHoaDon_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(nubSoLuongMua.Value) <=0)
            {
                MessageBox.Show("Số lượng mua phải lớn hơn 0 !","Thông báo");
            }
            else
            {
                btnXoaKhoiHoaDon.Enabled = true;
                btnThanhToan.Enabled = true;
                btnHuyHoaDon.Enabled = true;
                List<DTO_BanThuoc> dslt = lhd.LayThongTinThuoc();
                int sodu;
                int tlqd;
                if (radDonViBanLe.Checked == true)
                {
                    foreach (var item in dslt)
                    {
                        if (item.MaLoThuoc == lblMaLoThuoc.Text)
                        {
                            int soL = item.SoLuongTon - Convert.ToInt32(nubSoLuongMua.Value);
                            if (item.SoLuongTon >= Convert.ToInt32(nubSoLuongMua.Value) && item.SoLuongTon > 0)
                            {
                                lhd.SuaSoLuongTon(lblMaLoThuoc.Text, soL);
                                lblSoLuongTon.Text = soL.ToString();
                                LoadDataVaoGrid();
                                assistant_Idled11(sender, e);
                            }
                            else MessageBox.Show("Số Lượng Lẻ Không Đủ Hoặc Đã Hết", "Thông Báo");
                        }
                    }
                }
                else
                {
                    foreach (var item in dslt)
                    {
                        if (item.MaLoThuoc == lblMaLoThuoc.Text)
                        {
                            tlqd = item.TyLeQuyDoi;
                            sodu = item.SoLuongTon % tlqd;
                            int soL = ((item.SoLuongTon / tlqd) - Convert.ToInt32(nubSoLuongMua.Value)) * tlqd + sodu;
                            if ((item.SoLuongTon / tlqd) >= Convert.ToInt32(nubSoLuongMua.Value) && (item.SoLuongTon / tlqd) > 0)
                            {
                                lhd.SuaSoLuongTon(lblMaLoThuoc.Text, soL);
                                lblSoLuongTon.Text = Convert.ToString((item.SoLuongTon / tlqd) - Convert.ToInt32(nubSoLuongMua.Value));
                                LoadDataVaoGrid();
                                assistant_Idled11(sender, e);
                            }
                            else MessageBox.Show("Số Lượng Chẵn Không Đủ Hoặc Đã Hết", "Thông Báo");
                        }
                    }

                }
            }
        }

        private void btnXoaKhoiHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvThuocTrongHoaDon.RowCount ==0)
            {
                MessageBox.Show("Không có thuốc để xóa đâu!","Thông báo");
            }
            else
            {
                // Lấy Chỉ Số Hàng          
                int h = dgvThuocTrongHoaDon.CurrentRow.Index;
                if (dgvThuocTrongHoaDon.Rows.Count > 0)
                {
                    int soL;
                    // Lấy Số Lượng               
                    int so = Convert.ToInt32(dgvThuocTrongHoaDon.Rows[h].Cells[3].Value.ToString());
                    double donGia = Convert.ToDouble(dgvThuocTrongHoaDon.Rows[h].Cells[4].Value.ToString());
                    double vat = Convert.ToDouble(dgvThuocTrongHoaDon.Rows[h].Cells[8].Value.ToString());
                    lblTongVAT.Text = Convert.ToString(Convert.ToDouble(lblTongVAT.Text) - (so * donGia * (vat / 100)));
                    lblTongTienHoaDon.Text = Convert.ToString(Convert.ToDouble(lblTongTienHoaDon.Text) - (so * donGia));
                    lblKhachCanTra.Text = Convert.ToString(Convert.ToDouble(lblTongTienHoaDon.Text) + Convert.ToDouble(lblTongVAT.Text));
                    // Lấy Mã Lô thuốc
                    string maLo = dgvThuocTrongHoaDon.Rows[h].Cells[6].Value.ToString();
                    string dvt = dgvThuocTrongHoaDon.Rows[h].Cells[2].Value.ToString();
                    // Lấy Danh Sách Lô Thuốc
                    List<DTO_BanThuoc> dslt = lhd.LayThongTinThuoc();
                    // chỉ số 
                    //int du;
                    //int a = dgvThuocTimKiem.CurrentRow.Index;
                    int tlqd;
                    foreach (var item in dslt)
                    {
                        if (item.MaLoThuoc.Equals(maLo))
                        {

                            if (item.DonViQuyDoi == dvt)
                            {
                                soL = item.SoLuongTon + so;
                                lhd.SuaSoLuongTon(maLo, soL);

                            }
                            else
                            if (item.DonViQuyDoi != dvt)
                            {
                                tlqd = item.TyLeQuyDoi;
                                soL = item.SoLuongTon + (so * tlqd);
                                lhd.SuaSoLuongTon(maLo, soL);
                            }
                        }
                    }
                    // Load lại số lượng tồn
                    List<DTO_BanThuoc> dsbt = lhd.LayThongTinThuoc();
                    if (radDonViBanLe.Checked == true)
                    {
                        foreach (var item in dsbt)
                        {
                            if (item.MaLoThuoc == lblMaLoThuoc.Text)
                            {
                                lblSoLuongTon.Text = item.SoLuongTon.ToString();
                            }
                        }
                    }
                    else
                    {
                        int qd;
                        foreach (var item in dsbt)
                        {
                            if (item.MaLoThuoc == lblMaLoThuoc.Text)
                            {
                                qd = item.TyLeQuyDoi;
                                lblSoLuongTon.Text = Convert.ToString(item.SoLuongTon / qd);
                            }
                        }
                    }
                    // Xóa Hàng
                    dgvThuocTrongHoaDon.Rows.RemoveAt(h);
                    // update lại datagridview
                    int count = dgvThuocTrongHoaDon.RowCount;
                    // MessageBox.Show(count.ToString());
                    if (count > 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            dgvThuocTrongHoaDon.Rows[i].Cells["STT"].Value = (i + 1).ToString();
                        }
                    }

                    assistant_Idled11(sender, e);
                }
                else MessageBox.Show("Chưa Có Thuốc Trong Hóa Đơn", "Thông Báo");
                // tắt button
                if (dgvThuocTrongHoaDon.RowCount <= 0)
                {
                    btnXoaKhoiHoaDon.Enabled = false;
                    btnThanhToan.Enabled = false;
                    btnHuyHoaDon.Enabled = false;
                }
            }
        }
        BUS_KhachHang bkh = new BUS_KhachHang();
        // Tạo một hóa đơn
        private HoaDon TaoMotHoaDon()
        {
            List<DTO_KhachHang> dskh = bkh.LayHetKhachHang();
            HoaDon hd = new HoaDon();
            hd.maHD = lblMaHoaDon.Text;
            hd.ngayLapHD = dateNgayBan.Value;
            if (radBanTheoDon.Checked == true)
            {
                hd.loaiHD = true;
            }
            else hd.loaiHD = false;
            hd.ghiChu = txtGhiChuHoaDon.Text;
            hd.maNV = manv;
            foreach (var item in dskh)
            {
                if (item.SdtKH == txtSoDienThoaiKH.Text)
                {
                    hd.maKH = item.MaKH;
                }
            }
            return hd;
        }
        // export
        private void export(DataGridView dgw, string filename)
        {
            /*BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                pdftable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString()));
                }
            }
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
            */

        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if (dgvThuocTrongHoaDon.Rows.Count >0)
            {
                if (sodt == false || tt == false)
                {
                    MessageBox.Show("Sai định dạng ở số điện thoại khách hàng hoặc khách hàng thanh toán!");
                }
                else
                {
                    if (Convert.ToDouble(lblTienThuaTraKhach.Text) < 0)
                    {
                        MessageBox.Show("Tiền thừa phải lớn hơn không!", "Thông báo");
                    }
                    else
                    {
                        if (txtSoDienThoaiKH.Text == "")
                        {
                           // string tienkt = lblTienThuaTraKhach.Text;
                            DialogResult result = MessageBox.Show("Khách hàng không có, bạn muốn lập hóa đơn", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                            if (result == DialogResult.Yes)
                            {
                                TaoMaTuDongHD();
                                lhd.ThemHoaDon(TaoMotHoaDon());
                                //thêm chi tiết
                                for (int i = 0; i < dgvThuocTrongHoaDon.RowCount; i++)
                                {
                                    CT_HoaDon cthd = new CT_HoaDon();
                                    cthd.maHD = lblMaHoaDon.Text;
                                    cthd.maThuoc = dgvThuocTrongHoaDon.Rows[i].Cells[7].Value.ToString();
                                    cthd.soLuong = Convert.ToInt32(dgvThuocTrongHoaDon.Rows[i].Cells[3].Value);
                                    cthd.gia = Convert.ToDouble(dgvThuocTrongHoaDon.Rows[i].Cells[4].Value);
                                    cthd.donViTinh = dgvThuocTrongHoaDon.Rows[i].Cells[2].Value.ToString();
                                    cthd.vAT = Convert.ToDouble(dgvThuocTrongHoaDon.Rows[i].Cells[8].Value);
                                    lhd.ThemCTHoaDon(cthd);

                                }

                               
                                PrintHoaDon();
                                // xóa tất cả
                                dgvThuocTrongHoaDon.Rows.Clear();
                                lblTongTienHoaDon.Text = "0";
                                lblTongVAT.Text = "0";
                                lblKhachCanTra.Text = "0";
                                txtKhachThanhToan.Text = 0.ToString();
                                lblVAT.Text = "0";
                                lblSoLuongTon.Text = "0";
                                lblGiaThuoc.Text = "0";
                                txtMoTaThuoc.Text = "";
                                txtGhiChuHoaDon.Text = "";
                                txtSoDienThoaiKH.Focus();
                                // xóa hàng
                                dgvThuocTimKiem.Columns.Clear();
                                btnBan123456.Enabled = false;
                                btnThemVaoHoaDon.Enabled = false;
                                btnHuyHoaDon.Enabled = false;
                                btnXoaKhoiHoaDon.Enabled = false;
                                txtTimKiem.Enabled = false;                               
                                txtSoDienThoaiKH.Text = "";
                                lblTienThuaTraKhach.Text = "0";
                                lblNgaySanXuat.ResetText();
                                lblHanSuDung.ResetText();
                                lblMaHoaDon.ResetText();
                                lblMaThuoc.ResetText();
                            }
                        }
                        else
                        {
                            //string tienkt = lblTienThuaTraKhach.Text;
                            DialogResult result = MessageBox.Show("Bạn muốn lập hóa đơn", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                            if (result == DialogResult.Yes)
                            {
                                TaoMaTuDongHD();
                                lhd.ThemHoaDon(TaoMotHoaDon());
                                //thêm chi tiết
                                for (int i = 0; i < dgvThuocTrongHoaDon.RowCount; i++)
                                {
                                    CT_HoaDon cthd = new CT_HoaDon();
                                    cthd.maHD = lblMaHoaDon.Text;
                                    cthd.maThuoc = dgvThuocTrongHoaDon.Rows[i].Cells[7].Value.ToString();
                                    cthd.soLuong = Convert.ToInt32(dgvThuocTrongHoaDon.Rows[i].Cells[3].Value);
                                    cthd.gia = Convert.ToDouble(dgvThuocTrongHoaDon.Rows[i].Cells[4].Value);
                                    cthd.donViTinh = dgvThuocTrongHoaDon.Rows[i].Cells[2].Value.ToString();
                                    cthd.vAT = Convert.ToDouble(dgvThuocTrongHoaDon.Rows[i].Cells[8].Value);
                                    lhd.ThemCTHoaDon(cthd);

                                }

                                PrintHoaDon();
                                // xóa tất cả
                                dgvThuocTrongHoaDon.Rows.Clear();
                                lblTongTienHoaDon.Text = "0";
                                lblTongVAT.Text = "0";
                                lblKhachCanTra.Text = "0";
                                txtKhachThanhToan.Text = 0.ToString();
                                lblVAT.Text = "0";
                                lblSoLuongTon.Text = "0";
                                lblGiaThuoc.Text = "0";
                                txtMoTaThuoc.Text = "";
                                txtGhiChuHoaDon.Text = "";
                                txtSoDienThoaiKH.Focus();
                                // xóa hàng
                                dgvThuocTimKiem.Columns.Clear();
                                btnBan123456.Enabled = false;
                                btnThemVaoHoaDon.Enabled = false;
                                btnHuyHoaDon.Enabled = false;
                                btnXoaKhoiHoaDon.Enabled = false;
                                txtTimKiem.Enabled = false;
                                txtSoDienThoaiKH.Text = "";
                                lblTienThuaTraKhach.Text = "0";
                                lblNgaySanXuat.ResetText();
                                lblHanSuDung.ResetText();
                                lblMaHoaDon.ResetText();
                                lblMaThuoc.ResetText();
                            }
                        }
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Chưa có thuốc để bán!","Thông Báo");
            }
        }
       
        // kiểm tra sdt và tiền khách trả
        bool tt = true;
        bool sodt = true;
        private void txtKhachThanhToan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKhachThanhToan.Text))
            {
                e.Cancel = true;
                txtKhachThanhToan.Focus();
                err.SetError(txtKhachThanhToan, "Không được để trống!");
                tt = false;
            }
            else if (txtKhachThanhToan.Text.CheckNumber() == false)
            {
                e.Cancel = true;
                txtKhachThanhToan.Focus();
                err.SetError(txtKhachThanhToan, "Nó phải là số, không là chữ!");
                tt = false;
            }
            else if (Convert.ToDouble(txtKhachThanhToan.Text) <0)
            {
                e.Cancel = true;
                txtKhachThanhToan.Focus();
                err.SetError(txtKhachThanhToan, "Nó phải là số không âm !");
                tt = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtKhachThanhToan, null);
                tt = true;
            }
        }

        private void txtSoDienThoaiKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoDienThoaiKH.Text))
            {
                e.Cancel = false;
                err.SetError(txtSoDienThoaiKH, null);
                sodt = true;
            }
            else if (txtSoDienThoaiKH.Text.CheckNumber() == false)
            {
                e.Cancel = true;
                txtSoDienThoaiKH.Focus();
                err.SetError(txtSoDienThoaiKH, "Số điện thoại phải là số!");
                sodt = false;
            }
            else if (txtSoDienThoaiKH.Text.PhoneCheck() == false)
            {
                e.Cancel = true;
                txtSoDienThoaiKH.Focus();
                err.SetError(txtSoDienThoaiKH, "Số điện thoại có 10 chữ số bắt đầu là số 0!");
                sodt = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtSoDienThoaiKH, null);
                sodt = true;
            }
        }
        private void txtKhachThanhToan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKhachThanhToan.Text))
            {
                txtKhachThanhToan.Focus();
                err.SetError(txtKhachThanhToan, "Không được để trống!");
                tt = false;
            }
            else if (txtKhachThanhToan.Text.CheckNumber() == false)
            {
                txtKhachThanhToan.Focus();
                err.SetError(txtKhachThanhToan, "Nó phải là số, không là chữ!");
                tt = false;
            }
            else if (Convert.ToDouble(txtKhachThanhToan.Text) < 0)
            {
                txtKhachThanhToan.Focus();
                err.SetError(txtKhachThanhToan, "Nó phải là số không âm !");
                tt = false;
            }
            else
            {
                err.SetError(txtKhachThanhToan, null);
                tt = true;
            }

            if (tt == true)
            {
                lblTienThuaTraKhach.Text = Convert.ToString(Convert.ToDouble(txtKhachThanhToan.Text) - Convert.ToDouble(lblKhachCanTra.Text));
            }
            else lblTienThuaTraKhach.Text = "0";
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvThuocTrongHoaDon.RowCount ==0)
            {
                MessageBox.Show("Không có thuốc để xóa!","Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn hủy hóa đơn", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    int soL;
                    for (int i = 0; i < dgvThuocTrongHoaDon.RowCount; i++)
                    {

                        int so = Convert.ToInt32(dgvThuocTrongHoaDon.Rows[i].Cells[3].Value.ToString());
                        // lấy đơn vị tính
                        string dvt = dgvThuocTrongHoaDon.Rows[i].Cells[2].Value.ToString();
                        // Lấy Mã Lô thuốc
                        string maLo = dgvThuocTrongHoaDon.Rows[i].Cells[6].Value.ToString();
                        // Lấy Danh Sách Lô Thuốc
                        List<DTO_BanThuoc> dslt = lhd.LayThongTinThuoc();
                        foreach (var item in dslt)
                        {
                            if (item.MaLoThuoc.Equals(maLo))
                            {
                                if (item.DonViQuyDoi == dvt)
                                {
                                    soL = item.SoLuongTon + so;
                                    lhd.SuaSoLuongTon(maLo, soL);
                                    //assistant_Idled11(sender, e);
                                }
                                else
                                {
                                    soL = item.SoLuongTon + (so * item.TyLeQuyDoi);
                                    lhd.SuaSoLuongTon(maLo, soL);
                                    //assistant_Idled11(sender, e);
                                }
                            }
                        }
                    }
                    // xóa tất cả
                    dgvThuocTrongHoaDon.Rows.Clear();
                    lblTongTienHoaDon.Text = "0";
                    lblTongVAT.Text = "0";
                    lblKhachCanTra.Text = "0";
                    txtKhachThanhToan.Text = "";
                    lblTienThuaTraKhach.Text = "0";
                }
                // tắt tất cả
                if (dgvThuocTrongHoaDon.RowCount <= 0)
                {
                    btnXoaKhoiHoaDon.Enabled = false;
                    btnThanhToan.Enabled = false;
                    btnHuyHoaDon.Enabled = false;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmBanThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                btnThemVaoHoaDon_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                btnXoaKhoiHoaDon_Click(sender, e);
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.P)
            {
                btnThanhToan_Click(sender, e);
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.C)
            {
                btnHuyHoaDon_Click(sender, e);
            }
        }

        private void dgvThuocTrongHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ToolTip tip = new ToolTip();
        private void btnThemVaoHoaDon_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnThemVaoHoaDon, "Để thêm thuốc vào hóa đơn bấm phím Ctrl+A");
        }

        private void btnXoaKhoiHoaDon_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnXoaKhoiHoaDon, "Để xóa thuốc khỏi hóa đơn bấm phím Ctrl+D");
        }

        private void btnThanhToan_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnThanhToan, "Để in hóa đơn bấm phím Ctrl+Shift+P");
        }

        private void btnHuyHoaDon_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnHuyHoaDon, "Để hủy hóa đơn bấm phím Ctrl+Shift+C");
        }

        private void txtSoDienThoaiKH_Click(object sender, EventArgs e)
        {
            txtSoDienThoaiKH.AutoCompleteCustomSource.Clear();
            List<DTO_KhachHang> dskh = bkh.LayHetKhachHang();
            foreach (var item in dskh)
            {
                txtSoDienThoaiKH.AutoCompleteCustomSource.Add(item.SdtKH);
            }
        }

        private void txtSoDienThoaiKH_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoDienThoaiKH.Text))
            {
                err.SetError(txtSoDienThoaiKH, null);
                sodt = true;
            }
            else if (txtSoDienThoaiKH.Text.CheckNumber() == false)
            {
                txtSoDienThoaiKH.Focus();
                err.SetError(txtSoDienThoaiKH, "Số điện thoại phải là số!");
                sodt = false;
            }
            else if (txtSoDienThoaiKH.Text.PhoneCheck() == false)
            {
                txtSoDienThoaiKH.Focus();
                err.SetError(txtSoDienThoaiKH, "Số điện thoại có 10 chữ số bắt đầu là số 0!");
                sodt = false;
            }
            else
            {
                err.SetError(txtSoDienThoaiKH, null);
                sodt = true;
            }
        }
        // print hoá đơn
        private void PrintHoaDon()
        {
            pddHD.Document = pdHD;
            pddHD.ShowDialog();
        }
        private void pdHD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            var idHD = lblMaHoaDon.Text;
            var w = pdHD.DefaultPageSettings.PaperSize.Width;
            e.Graphics.DrawString(
                    "NHÀ THUỐC HẢI NAM",
                    new Font("Courier New",13,FontStyle.Bold),
                    Brushes.Black, new Point(100,20)
                );
            e.Graphics.DrawString(
                    string.Format("HD: {0}",idHD),
                    new Font("Courier New", 11, FontStyle.Bold),
                    Brushes.Black, new Point(w/2+200, 20)
                );
            e.Graphics.DrawString(
                    string.Format("{0} - {1}","127 Trần Bá Giao-P5-Gò Vấp","0868321749"),
                    new Font("Courier New",10, FontStyle.Bold),
                    Brushes.Black, new Point(100,45)
                );
            e.Graphics.DrawString(
                    string.Format("Ngày:{0}",DateTime.Now.ToString("dd/MM/yyyy HH:mm")),
                    new Font("Courier New", 12, FontStyle.Bold),
                    Brushes.Black, new Point(w / 2 + 200, 45)
                );

            Pen p = new Pen(Color.Black, 1);
            var y = 100;
            Point p1 = new Point(10,y);
            Point p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(p, p1, p2);

            e.Graphics.DrawString(
                    "HÓA ĐƠN BÁN LẺ",
                    new Font("Courier New",20, FontStyle.Bold),
                    Brushes.Black, new Point(w/2-105, 120)
                );
            // ten khach hang
            string tenkh = "Không có";
            List<DTO_KhachHang> dskh = lkh.LayHetKhachHang();
            foreach (var item in dskh)
            {
                if (item.SdtKH==txtSoDienThoaiKH.Text)
                {
                    tenkh = item.TenKH;
                }
            }
            e.Graphics.DrawString(
                   string.Format("Tên Khách Hàng: {0}",tenkh),
                   new Font("Courier New", 9, FontStyle.Bold),
                   Brushes.Black, new Point(10, 160)
               );
            e.Graphics.DrawString(
                    string.Format("Số điện thoại: {0}",txtSoDienThoaiKH.Text),
                    new Font("Courier New", 9, FontStyle.Bold),
                    Brushes.Black, new Point(10, 185)
                );

            y=235;
            e.Graphics.DrawString("STT", new Font("Courier New",10, FontStyle.Bold), Brushes.Black, new Point(10,y));
            e.Graphics.DrawString("Tên Thuốc", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(90, y));
            e.Graphics.DrawString("Đơn Vị Tính", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(230, y));
            e.Graphics.DrawString("Số Lượng", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(380, y));
            e.Graphics.DrawString("Đơn Giá", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(505, y));  
            e.Graphics.DrawString("Vat", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(620, y));
            e.Graphics.DrawString("Thành Tiền", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(700, y));


            //
            List<DTO_CTHoaDon> dscthd = lcthd.LayThuocTheoMaHD(lblMaHoaDon.Text);
            int i = 1;
            double sum = 0;
            double s = 0;
            y += 20;
            foreach (var item in dscthd)
            {
                s = (item.SoLuong * item.Gia) + (item.SoLuong * item.Gia * (item.VAT/100));
                sum = sum + s;
                e.Graphics.DrawString(string.Format("{0}",i++), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(20, y));
                e.Graphics.DrawString(string.Format("{0}",item.TenThuoc), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(90, y));
                e.Graphics.DrawString(string.Format("{0}", item.DonViTinh), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(255, y));
                e.Graphics.DrawString(string.Format("{0}",item.SoLuong), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(405, y));
                e.Graphics.DrawString(string.Format("{0}",item.Gia), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(505, y));              
                e.Graphics.DrawString(string.Format("{0}", item.VAT), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(620, y));
                e.Graphics.DrawString(string.Format("{0}", s), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(700, y));
                y += 20;
            }

            y += 30;
             p1= new Point(10, y+20);
             p2 = new Point(w - 10,y+20);
            e.Graphics.DrawLine(p, p1, p2);
            y += 40;
            e.Graphics.DrawString(string.Format("-Tổng tiền khách thanh toán: {0}", sum), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w/2+70, y));
            e.Graphics.DrawString(string.Format("-Tổng tiền thừa phải trả: {0}", Convert.ToDouble(lblTienThuaTraKhach.Text)), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 70, y+20));
            y += 70;
            e.Graphics.DrawString(string.Format("Lưu ý: -{0}", "Kiểm tra kỹ đơn thuốc trước khi ra khỏi quầy."), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString(string.Format("-{0}", "Liên hệ với chúng tôi khi cần."), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(69, y+20));
            e.Graphics.DrawString("Nhân viên bán", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 140, y));
            e.Graphics.DrawString(frmDangNhap.tenNhanVien, new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 148, y+20));
            y += 90;
            e.Graphics.DrawString("Xin trân thành cảm ơn quý khách hàng đã lựa chọn chúng tôi!", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 4-30, y));
        }
     
    }
}
