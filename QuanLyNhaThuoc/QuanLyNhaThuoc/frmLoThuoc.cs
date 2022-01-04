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
namespace QuanLyNhaThuoc
{
    public partial class frmLoThuoc : Form
    {
        BUS_Thuoc lt = new BUS_Thuoc();
        BUS_NhaCungCap ncc = new BUS_NhaCungCap();
        BUS_LoThuoc llt = new BUS_LoThuoc();
        bool tenthuoc = true;
        bool nhacc = true;
        bool xx = true;
        bool dvt = true;
        bool dvqd = true;
        bool tlqd = true;
        bool gbc = true;
        bool gbl = true;
        bool vat = true;
        bool nxs = true;
        bool hsd = true;
        bool slNhap = true;
        bool soluongton = true;

        private void LoadXuatXu()
        {
            List<DTO_LoThuoc> dslt = llt.LayHetLoThuoc();
            // Tìm Kiếm Theo Xuất Xứ
            foreach (var item in dslt)
            {
                if (!cboXX.Items.Contains(item.XuatXu))
                {
                    cboXX.Items.Add(item.XuatXu);
                }
            }
        }
        private void LoadDVT()
        {
            List<DTO_LoThuoc> dslt = llt.LayHetLoThuoc();
            // Tìm Kiếm Theo Xuất Xứ
            foreach (var item in dslt)
            {
                if (!cboDVT.Items.Contains(item.DonViTinh))
                {
                    cboDVT.Items.Add(item.DonViTinh);
                }
            }
        }
        private void LoadDVQD()
        {
            List<DTO_LoThuoc> dslt = llt.LayHetLoThuoc();
            // Tìm Kiếm Theo Xuất Xứ
            foreach (var item in dslt)
            {
                if (!cboDVQD.Items.Contains(item.DonViQuyDoi))
                {
                    cboDVQD.Items.Add(item.DonViQuyDoi);
                }
            }
        }
        public frmLoThuoc()
        {
            InitializeComponent();
            LoadXuatXu();
            LoadDVT();
            LoadDVQD();
            txtMaThuoc.Text = frmQuanLyThuoc.maT;
            txtTimKiem.Text = frmQuanLyThuoc.maT;
            //txtMaThuoc.Text = frmQuanLyThuoc.tenT;
            this.KeyPreview = true;
            btnSuaLoThuoc.Enabled = false;
           // btnThemLoThuoc.Enabled = false;
                       
        }
        // Định dạng cột
        private void ForMatLoThuoc()
        {
            dgvDanhSachLoThuoc.Columns["maLoThuoc"].HeaderText = "Mã Lô Thuốc";
            dgvDanhSachLoThuoc.Columns["maLoThuoc"].Width = 180;
            dgvDanhSachLoThuoc.Columns["maThuoc"].HeaderText = "Mã Thuốc";
            dgvDanhSachLoThuoc.Columns["maThuoc"].Width = 180;
            dgvDanhSachLoThuoc.Columns["tenThuoc"].HeaderText = "Tên Thuốc";
            dgvDanhSachLoThuoc.Columns["tenThuoc"].Width = 180;
            dgvDanhSachLoThuoc.Columns["maNCC"].Visible = false;
            dgvDanhSachLoThuoc.Columns["tenNCC"].HeaderText = "Nhà Cung Cấp";
            dgvDanhSachLoThuoc.Columns["tenNCC"].Width = 180;
            dgvDanhSachLoThuoc.Columns["xuatXu"].HeaderText = "Xuất Xứ";
            dgvDanhSachLoThuoc.Columns["xuatXu"].Width = 150;
            dgvDanhSachLoThuoc.Columns["ngaySanXuat"].HeaderText = "Ngày Sản Xuất";
            dgvDanhSachLoThuoc.Columns["ngaySanXuat"].Width = 180;
            dgvDanhSachLoThuoc.Columns["hanSuDung"].HeaderText = "Hạn Sử Dụng";
            dgvDanhSachLoThuoc.Columns["hanSuDung"].Width = 180;
            dgvDanhSachLoThuoc.Columns["donViTinh"].HeaderText = "Đơn Vị Tính";
            dgvDanhSachLoThuoc.Columns["donViTinh"].Width = 180;
            dgvDanhSachLoThuoc.Columns["donViQuyDoi"].HeaderText = "Đơn Vị Quy Đổi";
            dgvDanhSachLoThuoc.Columns["donViQuyDoi"].Width = 200;
            dgvDanhSachLoThuoc.Columns["tyLeQuyDoi"].HeaderText = "Tỷ Lệ Quy Đổi";
            dgvDanhSachLoThuoc.Columns["tyLeQuyDoi"].Width = 200;
            dgvDanhSachLoThuoc.Columns["giaBanChan"].HeaderText = "Giá Bán Chẵn";
            dgvDanhSachLoThuoc.Columns["giaBanChan"].Width = 180;
            dgvDanhSachLoThuoc.Columns["giaBanLe"].HeaderText = "Giá Bán Lẻ";
            dgvDanhSachLoThuoc.Columns["giaBanLe"].Width = 180;
            dgvDanhSachLoThuoc.Columns["lieuLuongDung"].HeaderText = "Liều Lượng Dùng";
            dgvDanhSachLoThuoc.Columns["lieuLuongDung"].Width = 180;
            dgvDanhSachLoThuoc.Columns["moTa"].HeaderText = "Mô Tả";
            dgvDanhSachLoThuoc.Columns["moTa"].Width = 180;
            dgvDanhSachLoThuoc.Columns["vAT"].HeaderText = "VAT";
            dgvDanhSachLoThuoc.Columns["vAT"].Width = 180;
            dgvDanhSachLoThuoc.Columns["soLuongTon"].HeaderText = "Số Lượng Tồn";
            dgvDanhSachLoThuoc.Columns["soLuongTon"].Width = 180;
        }
        private void dgvDanhSachLoThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int h = dgvDanhSachLoThuoc.CurrentRow.Index;
            txtLoThuoc.Text = dgvDanhSachLoThuoc.Rows[h].Cells[0].Value.ToString();
            txtMaThuoc.Text = dgvDanhSachLoThuoc.Rows[h].Cells[1].Value.ToString();
            txtNCC.Text = dgvDanhSachLoThuoc.Rows[h].Cells[4].Value.ToString();
            cboXX.Text = dgvDanhSachLoThuoc.Rows[h].Cells[5].Value.ToString();
            dateNSX.Value = Convert.ToDateTime(dgvDanhSachLoThuoc.Rows[h].Cells[6].Value.ToString());
            dateHSD.Value = Convert.ToDateTime(dgvDanhSachLoThuoc.Rows[h].Cells[7].Value.ToString());
            cboDVT.Text = dgvDanhSachLoThuoc.Rows[h].Cells[8].Value.ToString();
            cboDVQD.Text = dgvDanhSachLoThuoc.Rows[h].Cells[9].Value.ToString();
            txtTyLeQuyDoi.Text = dgvDanhSachLoThuoc.Rows[h].Cells[10].Value.ToString();
            txtGiaBanChan.Text = dgvDanhSachLoThuoc.Rows[h].Cells[11].Value.ToString();
            txtGiaBanLe.Text = dgvDanhSachLoThuoc.Rows[h].Cells[12].Value.ToString();
            txtLieuLuongDung.Text = dgvDanhSachLoThuoc.Rows[h].Cells[13].Value.ToString();
            txtMoTaThuoc.Text = dgvDanhSachLoThuoc.Rows[h].Cells[14].Value.ToString();
            txtVAT.Text = dgvDanhSachLoThuoc.Rows[h].Cells[15].Value.ToString();
            txtSoLuongTon.Text = dgvDanhSachLoThuoc.Rows[h].Cells[16].Value.ToString();
            btnSuaLoThuoc.Enabled = true;
            btnThemLoThuoc.Enabled = false;
        }
        //
        private void frmLoThuoc_Load(object sender, EventArgs e)
        {            
            //Lấy Hết Thuốc
            List<DTO_LoThuoc> dslt = llt.Lay30LoThuoc();
            dgvDanhSachLoThuoc.DataSource = dslt;
            ForMatLoThuoc();

            // autocomplete
            List<DTO_LoThuoc> ds = llt.LayHetLoThuoc();
            // auto ncc
            txtNCC.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNCC.AutoCompleteCustomSource.Clear();
            AutoCompleteStringCollection collect1 = new AutoCompleteStringCollection();
            foreach (var item in ds)
            {
                collect1.Add(item.TenNCC);
                txtNCC.AutoCompleteCustomSource = collect1;
            }

            //auto XX
            cboXX.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboXX.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboXX.AutoCompleteCustomSource.Clear();
            AutoCompleteStringCollection collect2 = new AutoCompleteStringCollection();
            foreach (var item in ds)
            {
                collect2.Add(item.XuatXu);
                cboXX.AutoCompleteCustomSource = collect2;
            }

            // auto dvt
            cboDVT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboDVT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDVT.AutoCompleteCustomSource.Clear();
            AutoCompleteStringCollection collect3 = new AutoCompleteStringCollection();
           foreach (var item in ds)
           {
                collect3.Add(item.DonViTinh);
                cboDVT.AutoCompleteCustomSource = collect3;
           }

            //auto dvqd
            cboDVQD.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboDVQD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDVQD.AutoCompleteCustomSource.Clear();
            AutoCompleteStringCollection collect4 = new AutoCompleteStringCollection();
            foreach (var item in ds)
            {
                collect4.Add(item.DonViQuyDoi);
                cboDVQD.AutoCompleteCustomSource = collect4;
            }

            //auto tt
            txtMaThuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtMaThuoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMaThuoc.AutoCompleteCustomSource.Clear();
            AutoCompleteStringCollection collect5 = new AutoCompleteStringCollection();
            foreach (var item in ds)
            {
                collect5.Add(item.TenThuoc);
                txtMaThuoc.AutoCompleteCustomSource = collect5;
            }
        }
        // Tạo Mã thuốc tự Đông
        private void TaoMaThuocTuDong()
        {
            int value = llt.SoLoThuoc();
            if (value + 1 < 10)
            {
                txtLoThuoc.Text = "LT000000000" + (value + 1).ToString();
            }
            else if (value + 1 < 100)
            {
                txtLoThuoc.Text = "LT00000000" + (value + 1).ToString();
            }
            else if (value + 1 < 1000)
            {
                txtLoThuoc.Text = "LT0000000" + (value + 1).ToString();
            }
            else if (value + 1 < 10000)
            {
                txtLoThuoc.Text = "LT000000" + (value + 1).ToString();
            }
            else if (value + 1 < 100000)
            {
                txtLoThuoc.Text = "LT00000" + (value + 1).ToString();
            }
            else if (value + 1 < 1000000)
            {
                txtLoThuoc.Text = "LT0000" + (value + 1).ToString();
            }
            else if (value + 1 < 10000000)
            {
                txtLoThuoc.Text = "LT000" + (value + 1).ToString();
            }
            else if (value + 1 < 100000000)
            {
                txtLoThuoc.Text = "LT00" + (value + 1).ToString();
            }
            else if (value + 1 < 1000000000)
            {
                txtLoThuoc.Text = "LT0" + (value + 1).ToString();
            }
            else if (value + 1 == 1000000000)
            {
                txtLoThuoc.Text = "LT" + (value + 1).ToString();
            }
        }
        //Tạo một lô thuốc
        private DTO_LoThuoc TaoLoThuoc()
        {

            DTO_LoThuoc lt = new DTO_LoThuoc();
            lt.MaLoThuoc = txtLoThuoc.Text;
            lt.MaThuoc = txtMaThuoc.Text;
            lt.MaNCC = txtNCC.Text;            
            lt.XuatXu = cboXX.Text;
            lt.NgaySanXuat = dateNSX.Value;
            lt.HanSuDung = dateHSD.Value;
            lt.DonViTinh = cboDVT.Text;
            lt.DonViQuyDoi = cboDVQD.Text;
            lt.TyLeQuyDoi = Convert.ToInt32(txtTyLeQuyDoi.Text);
            lt.GiaBanChan = Convert.ToDouble(txtGiaBanChan.Text);
            lt.GiaBanLe = Convert.ToDouble(txtGiaBanLe.Text);
            lt.LieuLuongDung = txtLieuLuongDung.Text;
            lt.MoTa = txtMoTaThuoc.Text;
            lt.VAT = Convert.ToDouble(txtVAT.Text);
            lt.SoLuongTon = Convert.ToInt32(txtSoLuongTon.Text);
            return lt;
        }

        private void btnThemLoThuoc_Click(object sender, EventArgs e)
        {
       
            if (txtMaThuoc.Text == "" || txtNCC.Text == "" || cboXX.Text == "" || cboDVQD.Text == "" || cboDVT.Text == "" || txtTyLeQuyDoi.Text == "" || dateHSD.Value == null || dateNSX.Text == null || txtGiaBanChan.Text == "" || txtGiaBanLe.Text == "" || txtVAT.Text == "" || txtSoLuongNhap.Text=="")
            {
                MessageBox.Show("Chỉ có Mô tả, tên thuốc và liều lượng dùng là được rỗng, số lượng tồn mặc định là số, còn lại phải khác rỗng !", "Thông báo");
            }
            else if (tenthuoc == false || nhacc == false || xx == false || dvt==false || dvqd==false || gbc==false || gbl==false || tlqd==false || vat==false || hsd==false || nxs==false || soluongton==false || slNhap==false)
            {
                MessageBox.Show("Có thể định dạng nào đó bị sai!");
            }
            else
            {               
                List<DTO_LoThuoc> lt = llt.Lay30LoThuoc();
                int test1 = 1;
                if (lt != null)
                {
                    
                    foreach (var item in lt)
                    {
                        if (item.MaThuoc==txtMaThuoc.Text)
                        {
                            if (item.MaNCC == txtNCC.Text && item.XuatXu == cboXX.Text && (dateNSX.Value.Year<item.NgaySanXuat.Year || (dateNSX.Value.Year==item.NgaySanXuat.Year && dateNSX.Value.Month < item.NgaySanXuat.Month) || (dateNSX.Value.Year == item.NgaySanXuat.Year && dateNSX.Value.Month == item.NgaySanXuat.Month && dateNSX.Value.Day <= item.NgaySanXuat.Day)) )
                            {
                                test1 = 0;
                            }
                            else
                            {
                                test1 = 1;

                            }
                        }                    
                    }
                    if (test1 == 1)
                    {
                        TaoMaThuocTuDong();
                        txtSoLuongTon.Text = "";
                        txtSoLuongTon.Text = (Convert.ToInt32(txtTyLeQuyDoi.Text) * Convert.ToInt32(txtSoLuongNhap.Text)).ToString();
                        if (llt.ThemLoThuoc(TaoLoThuoc()) == true)
                        {
                            frmLoThuoc_Load(sender, e);
                            MessageBox.Show("Thêm lô thuốc thành công!", "Thông Báo");
                            btnSuaLoThuoc.Enabled = true;
                        }
                        else MessageBox.Show("Thêm lô thuốc thất bại!", "Thông Báo");
                    }
                    else
                    {
                        MessageBox.Show("Thuốc này đã tồn tại", "Thông báo!");
                    }
                }
                else
                {
                    TaoMaThuocTuDong();
                    txtSoLuongTon.Text = "";
                    txtSoLuongTon.Text = (Convert.ToInt32(txtTyLeQuyDoi.Text) * Convert.ToInt32(txtSoLuongNhap.Text)).ToString();
                    // thêm
                    if (llt.ThemLoThuoc(TaoLoThuoc()) == true)
                    {
                        frmLoThuoc_Load(sender, e);
                        MessageBox.Show("Thêm lô thuốc thành công!", "Thông Báo");
                        btnSuaLoThuoc.Enabled = true;
                    }
                    else MessageBox.Show("Thêm lô thuốc thất bại!", "Thông Báo");
                }
               
            }
           
        }

        private void btnSuaLoThuoc_Click(object sender, EventArgs e)
        {
           
            if (txtMaThuoc.Text == "" || txtNCC.Text == "" || cboXX.Text == "" || cboDVQD.Text == "" || cboDVT.Text == "" || txtTyLeQuyDoi.Text == "" || dateHSD.Value == null || dateNSX.Text == null || txtSoLuongTon.Text == "" || txtGiaBanChan.Text == "" || txtGiaBanLe.Text == "" || txtVAT.Text == "")
            {
                MessageBox.Show("Chỉ có Mô tả, số lượng nhập, tên thuốc và liều lượng dùng là được rỗng, còn lại phải khác rỗng!", "Thông báo");
            }
            else if (tenthuoc == false || nhacc == false || xx == false || dvt == false || dvqd == false || gbc == false || gbl == false || tlqd == false || vat == false || hsd == false || nxs == false || soluongton == false || slNhap==false)
            {
                MessageBox.Show("Có thể định dạng nào đó bị sai!");
            }
            else
            {
                if (txtSoLuongNhap.Text=="")
                {
                    txtSoLuongTon.Text = txtSoLuongTon.Text;
                }
                else if (Convert.ToInt32(txtSoLuongNhap.Text) > 0)
                {
                    txtSoLuongTon.Text = (Convert.ToInt32(txtTyLeQuyDoi.Text) * Convert.ToInt32(txtSoLuongNhap.Text)).ToString();
                }
                //sua
               if (llt.SuaLoThuoc(TaoLoThuoc()) == true)
                {
                    frmLoThuoc_Load(sender, e);
                    MessageBox.Show("Sửa lô thuốc thành công!", "Thông Báo");
                }

                else MessageBox.Show("Sửa lô thuốc thất bại!", "Thông Báo");
            }
        }
        // Tìm kiếm nhân viên theo mã và tên

        void assistant_Idled11(object sender, EventArgs e)
        {
            this.Invoke(
            new MethodInvoker(() =>
            {
                dgvDanhSachLoThuoc.DataSource = llt.TimKiemTheoMaTen(txtTimKiem.Text);
                if (dgvDanhSachLoThuoc.RowCount != 0)
                {
                    ForMatLoThuoc();
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
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            int delay = 1000;
            assistant = new TypeAssistant(delay);
            assistant.Idled += assistant_Idled11;
            assistant.TextChanged();
        }


       

        private void frmLoThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                btnThemLoThuoc_Click(sender,e);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                btnSuaLoThuoc_Click(sender, e);
            }
        }
        DateTime d = DateTime.Now;
        BUS_Thuoc dst = new BUS_Thuoc();

      
        ToolTip tip = new ToolTip();
        private void btnThemLoThuoc_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnThemLoThuoc,"Để thêm lô thuốc bấm phím Ctrl+A");
        }

        private void btnSuaLoThuoc_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnSuaLoThuoc, "Để sửa lô thuốc bấm phím Ctrl+R");
        }



        private void txtTyLeQuyDoi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTyLeQuyDoi.Text))
            {
                e.Cancel = true;
                txtTyLeQuyDoi.Focus();
                err.SetError(txtTyLeQuyDoi, "Không được để trống tỷ lệ quy đổi !");
                tlqd = false;
            }
            else if (txtTyLeQuyDoi.Text.CheckNumber()==false)
            {
                e.Cancel = true;
                txtTyLeQuyDoi.Focus();
                err.SetError(txtTyLeQuyDoi, "Tỷ lệ quy đổi phải là số!");
                tlqd = false;
            }
            else if (Convert.ToDouble(txtTyLeQuyDoi.Text) <=0)
            {
                e.Cancel = true;
                txtTyLeQuyDoi.Focus();
                err.SetError(txtTyLeQuyDoi,"Tỷ lệ quy đổi phải là số lớn hơn 0");
                tlqd = false;
            }
            else if (txtTyLeQuyDoi.Text.CheckNguyen()==false)
            {
                e.Cancel = true;
                txtTyLeQuyDoi.Focus();
                err.SetError(txtTyLeQuyDoi,"Tỷ lệ quy đổi phải là số nguyên dương!");
                tlqd = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTyLeQuyDoi,null);
                tlqd = true;
            }
        }

        private void dateNSX_Validating(object sender, CancelEventArgs e)
        {

            if (dateNSX.Value.Year > d.Year || (dateNSX.Value.Month > d.Month && dateNSX.Value.Year == d.Year) || (dateNSX.Value.Month == d.Month && dateNSX.Value.Year == d.Year && dateNSX.Value.Day > d.Day))
            {
                e.Cancel = true;
                dateNSX.Focus();
                err.SetError(dateNSX, "Ngày sản xuất phải nhỏ hơn hoặc bằng ngày hiện tại");
                nxs = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(dateNSX,null);
                nxs = true;
            }
        }

        private void dateHSD_Validating(object sender, CancelEventArgs e)
        {
            if (dateHSD.Value.Year < d.Year || (dateHSD.Value.Month < d.Month && dateHSD.Value.Year == d.Year) || (dateHSD.Value.Month == d.Month && dateHSD.Value.Year >= d.Year && dateHSD.Value.Day < d.Day))
            {
                e.Cancel = true;
                dateHSD.Focus();
                err.SetError(dateHSD, "Hạn sử dụng phải lớn hơn ngày sản xuất và ngày hiện tại ");
                hsd = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(dateHSD,null);
                hsd = true;
            }
        }
        private void txtSoLuongNhap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuongNhap.Text))
            {
                e.Cancel = false;
                err.SetError(txtSoLuongNhap,null);
                slNhap = true;
               
            }
            else if (txtSoLuongNhap.Text.CheckNumber() == false)
            {
                e.Cancel = true;
                txtSoLuongNhap.Focus();
                err.SetError(txtSoLuongNhap, "Số lượng nhập phải là số!");
                slNhap = false;
            }
            else if (txtSoLuongNhap.Text.CheckNguyen() == false)
            {
                e.Cancel = true;
                txtSoLuongNhap.Focus();
                err.SetError(txtSoLuongNhap, "Số lượng nhập phải là số nguyên dương!");
                slNhap = false;
            }
            else if (Convert.ToInt32(txtSoLuongNhap.Text) <= 0)
            {
                e.Cancel = true;
                txtSoLuongNhap.Focus();
                err.SetError(txtSoLuongNhap, "Số lượng nhập phải là số lớn hơn 0");
                slNhap = false;
            }       
            else
            {
                e.Cancel = false;
                err.SetError(txtSoLuongNhap, null);
                slNhap = true;
            }
        }

        private void txtVAT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVAT.Text))
            {
                e.Cancel = true;
                txtVAT.Focus();
                err.SetError(txtVAT,"VAT không được để trống!");
                vat = false;
            }
            else if (txtVAT.Text.CheckNumber()==false)
            {
                e.Cancel = true;
                txtVAT.Focus();
                err.SetError(txtVAT,"VAT phải là số!");
                vat = false;
            }
            else if (Convert.ToDouble(txtVAT.Text) < 0)
            {
                e.Cancel = true;
                txtVAT.Focus();
                err.SetError(txtVAT, "Số VAT phải là số lớn hơn hoặc bằng 0");
                vat = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtVAT, null);
                vat = true;
            }
        }

        private void txtGiaBanChan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiaBanChan.Text))
            {
                e.Cancel = true;
                txtGiaBanChan.Focus();
                err.SetError(txtGiaBanChan, "Giá bán chẵn không được để trống!");
                gbc = false;
            }
            else if (txtGiaBanChan.Text.CheckNumber() == false)
            {
                e.Cancel = true;
                txtGiaBanChan.Focus();
                err.SetError(txtGiaBanChan, "Giá bán chẵn phải là số!");
                gbc = false;
            }
            else if (Convert.ToDouble(txtGiaBanChan.Text) <= 0)
            {
                e.Cancel = true;
                txtGiaBanChan.Focus();
                err.SetError(txtGiaBanChan, "Giá bán chẵn phải là số lớn hơn 0");
                gbc = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtGiaBanChan, null);
                gbc = true;
            }
        }

        private void txtGiaBanLe_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiaBanLe.Text))
            {
                e.Cancel = true;
                txtGiaBanLe.Focus();
                err.SetError(txtGiaBanLe, "Giá bán lẻ không được để trống!");
                gbl = false;
            }
            else if (txtGiaBanLe.Text.CheckNumber() == false)
            {
                e.Cancel = true;
                txtGiaBanLe.Focus();
                err.SetError(txtGiaBanLe, "Giá bán lẻ phải là số!");
                gbl = false;
            }
            else if (Convert.ToDouble(txtGiaBanLe.Text) <= 0)
            {
                e.Cancel = true;
                txtGiaBanLe.Focus();
                err.SetError(txtGiaBanLe, "Giá bán lẻ phải là số lớn hơn 0");
                gbl = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtGiaBanLe, null);
                gbl = true;
            }
        }

        private void txtNCC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNCC.Text))
            {
                e.Cancel = true;
                txtNCC.Focus();
                err.SetError(txtNCC,"Không để trống nhà cung cấp!");
                nhacc = false;
            }
            else if (txtNCC.Text.NameCheck() == false)
            {
                e.Cancel = true;
                txtNCC.Focus();
                err.SetError(txtNCC, "Không chứa chữ cái đặt biệt, chữ cái đầu không là số hoặc định dạng không đúng!");
                nhacc = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtNCC,null);
                nhacc = true;
            }
        }
        private void txtNCC_TextChanged(object sender, EventArgs e)
        {
            List<DTO_LoThuoc> dslt = llt.LayHetLoThuoc();
            foreach (var item in dslt)
            {
                if (txtNCC.Text==item.TenNCC)
                {
                    txtNCC.Text =item.MaNCC;
                }
            }
        }

        private void txtTenThuocTrongLo_Validating(object sender, CancelEventArgs e)
        {
            /*if (string.IsNullOrEmpty(txtTenThuocTrongLo.Text))
            {
                e.Cancel = true;
                txtTenThuocTrongLo.Focus();
                err.SetError(txtNCC, "Không để trống tên thuốc!");
                tenthuoc = false;
            }
            else if (txtTenThuocTrongLo.Text.NameCheck() == false)
            {
                e.Cancel = true;
                txtTenThuocTrongLo.Focus();
                err.SetError(txtTenThuocTrongLo, "Không chứa chữ cái đặt biệt, chữ cái đầu không là số hoặc định dạng không đúng!");
                tenthuoc = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTenThuocTrongLo, null);
                tenthuoc = true;
            }*/
        }

        private void cboXX_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cboXX.Text))
            {
                e.Cancel = true;
                cboXX.Focus();
                err.SetError(cboXX, "Không được để trống tên !");
                xx = false;
            }
            else if (cboXX.Text.NameCheck() == false)
            {
                e.Cancel = true;
                cboXX.Focus();
                err.SetError(cboXX, "Chữ cái đầu không được là số, không chứa kí tự đặt biệt hoặc định dạng không đúng!");
                xx = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(cboXX, null);
                xx = true;
            }
        }

        private void cboDVT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cboDVT.Text))
            {
                e.Cancel = true;
                cboDVT.Focus();
                err.SetError(cboDVT, "Đơn vị tính không được để trống!");
                dvt = false;
            }
            else if (cboDVT.Text.NameCheck() == false)
            {
                e.Cancel = true;
                cboDVT.Focus();
                err.SetError(cboDVT, "Không chứa chữ cái đặt biệt, chữ cái đầu không là số hoặc định dạng không đúng!");
                dvt = false;
            }

            else
            {
                e.Cancel = false;
                err.SetError(cboDVT, null);
                dvt = true;
            }
        }

        private void cboDVQD_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cboDVQD.Text))
            {
                e.Cancel = true;
                cboDVQD.Focus();
                err.SetError(cboDVQD, "Đơn vị quy đổi không được để trống!");
                dvqd = false;
            }

            else if (cboDVQD.Text.NameCheck() == false)
            {
                e.Cancel = true;
                cboDVQD.Focus();
                err.SetError(cboDVQD, "Không chứa chữ cái đặt biệt, chữ đầu không là số hoặc định dạng không đúng!");
                dvqd = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(cboDVQD, null);
                dvqd = true;
            }
        }

        private void txtMaThuoc_TextChanged(object sender, EventArgs e)
        {
           /* List<DTO_LoThuoc> dslt = llt.LayHetLoThuoc();
            foreach (var item in dslt)
            {
                if (txtMaThuoc.Text == item.TenThuoc)
                {
                    txtMaThuoc.Text = item.MaThuoc;
                }
            }*/
        }

        private void txtMaThuoc_MouseClick(object sender, MouseEventArgs e)
        {
            List<DTO_LoThuoc> dslt = llt.LayHetLoThuoc();
            foreach (var item in dslt)
            {
                if (txtMaThuoc.Text == item.TenThuoc)
                {
                    txtMaThuoc.Text = item.MaThuoc;
                }
            }
        }

        private void btnThemSLTon_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text == "" || txtNCC.Text == "" || cboXX.Text == "" || cboDVQD.Text == "" || cboDVT.Text == "" || txtTyLeQuyDoi.Text == "" || dateHSD.Value == null || dateNSX.Text == null || txtSoLuongTon.Text == "" || txtGiaBanChan.Text == "" || txtGiaBanLe.Text == "" || txtVAT.Text == "")
            {
                MessageBox.Show("Chỉ có Mô tả, số lượng nhập, tên thuốc và liều lượng dùng là được rỗng, còn lại phải khác rỗng!", "Thông báo");
            }
            else if (tenthuoc == false || nhacc == false || xx == false || dvt == false || dvqd == false || gbc == false || gbl == false || tlqd == false || vat == false || hsd == false || nxs == false || soluongton == false || slNhap == false)
            {
                MessageBox.Show("Có thể định dạng nào đó bị sai!");
            }
            else
            {
                if (txtSoLuongNhap.Text == "")
                {
                    txtSoLuongTon.Text = txtSoLuongTon.Text;
                }
                else if (Convert.ToInt32(txtSoLuongNhap.Text) > 0)
                {
                    txtSoLuongTon.Text = (Convert.ToInt32(txtSoLuongTon.Text) + (Convert.ToInt32(txtTyLeQuyDoi.Text) * Convert.ToInt32(txtSoLuongNhap.Text))).ToString();
                }
                //sua
                if (llt.SuaLoThuoc(TaoLoThuoc()) == true)
                {
                    frmLoThuoc_Load(sender, e);
                    MessageBox.Show("Sửa lô thuốc thành công!", "Thông Báo");
                }

                else MessageBox.Show("Sửa lô thuốc thất bại!", "Thông Báo");
            }
        }

        private void btnResetLoThuoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            txtLoThuoc.ResetText();
            txtNCC.ResetText();
            cboXX.ResetText();
            cboDVT.ResetText();
            cboDVQD.ResetText();
            txtTyLeQuyDoi.ResetText();
            txtGiaBanChan.ResetText();
            txtGiaBanLe.ResetText();
            txtVAT.ResetText();
            txtLieuLuongDung.ResetText();
            txtSoLuongNhap.ResetText();
            txtMoTaThuoc.ResetText();
            txtSoLuongTon.ResetText();
            btnThemLoThuoc.Enabled = true;
            btnSuaLoThuoc.Enabled = false;

        }
    }
}
