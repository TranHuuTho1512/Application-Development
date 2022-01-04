using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyNhaThuoc;
using DTO_QuanLyNhaThuoc;
namespace QuanLyNhaThuoc
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            this.KeyPreview = true;
            btnSuaTT.Enabled = false;
        }
        BUS_NhanVien lnv = new BUS_NhanVien();
        bool tenNV = true;
        bool sdT = true;
        bool cmnd = true;
        bool matK = true;
        bool diaC = true;
        bool eMail = true;
        // Format nhân viên
        private void ForMatNhanVien()
        {
            dgvDanhSachNhanVien.Columns["maNV"].HeaderText = "Mã Nhân Viên";
            dgvDanhSachNhanVien.Columns["maNV"].Width = 170;
            dgvDanhSachNhanVien.Columns["tenNV"].HeaderText = "Tên Nhân Viên";
            dgvDanhSachNhanVien.Columns["tenNV"].Width = 160;
            dgvDanhSachNhanVien.Columns["sdtNV"].HeaderText = "Số Điện Thoại";
            dgvDanhSachNhanVien.Columns["sdtNV"].Width = 150;
            dgvDanhSachNhanVien.Columns["email"].HeaderText = "Email";
            dgvDanhSachNhanVien.Columns["email"].Width = 210;
            dgvDanhSachNhanVien.Columns["diaChi"].HeaderText = "Địa Chỉ";
            dgvDanhSachNhanVien.Columns["diaChi"].Width = 170;
            dgvDanhSachNhanVien.Columns["cMND"].HeaderText = "CMND";
            dgvDanhSachNhanVien.Columns["cMND"].Width = 130;
            dgvDanhSachNhanVien.Columns["matKhau"].Visible = false;
            dgvDanhSachNhanVien.Columns["trangThai"].HeaderText = "Trạng Thái";
            dgvDanhSachNhanVien.Columns["trangThai"].Width = 160;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            List<DTO_NhanVien> dsnv = lnv.Lay50NhanVien();
            dgvDanhSachNhanVien.DataSource = dsnv;
            ForMatNhanVien();
        }

        // Tạo mã tự động
        private void TaoMaTuDong()
        {
            int value = lnv.SoNhanVien();
            if (radQuanLy.Checked)
            {
                if (value + 1 < 10)
                {
                    txtMaNV.Text = "QL000" + (value + 1).ToString();
                }
                else if (value + 1 < 100)
                {
                    txtMaNV.Text = "QL00" + (value + 1).ToString();
                }
                else if (value + 1 < 1000)
                {
                    txtMaNV.Text = "QL0" + (value + 1).ToString();
                }
                else if (value + 1 == 1000)
                {
                    txtMaNV.Text = "QL" + (value + 1).ToString();
                }
            }
            else
            {
                if (value + 1 < 10)
                {
                    txtMaNV.Text = "NV000" + (value + 1).ToString();
                }
                else if (value + 1 < 100)
                {
                    txtMaNV.Text = "NV00" + (value + 1).ToString();
                }
                else if (value + 1 < 1000)
                {
                    txtMaNV.Text = "NV0" + (value + 1).ToString();
                }
                else if (value + 1 == 1000)
                {
                    txtMaNV.Text = "NV" + (value + 1).ToString();
                }
            }
        }

        // Tạo Một Nhân Viên
        private DTO_NhanVien TaoMotNhanVien()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.SdtNV = txtSDT.Text;
            nv.Email = txtEmail.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.CMND = txtCMND.Text;
            nv.MatKhau = txtMK.Text;
            if (radDLV.Checked == true)
            {
                nv.TrangThai = "Đang Hoạt Động";
            }
            else nv.TrangThai = "Ngưng Hoạt Động";
            return nv;
        }
        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txtTenNV.Text == "" || txtSDT.Text == "" || txtCMND.Text == "" || txtMK.Text == "")
            {
                MessageBox.Show("Không để trống tên nhân viên, số điện thoại, cmnd hoặc mật khẩu");
            }
            else if (tenNV == false || sdT == false || cmnd == false || matK == false || diaC == false || eMail == false)
            {
                MessageBox.Show("Định dạng chưa đúng!", "Thống báo");
            }
            else
            {

                List<DTO_NhanVien> dsnv = lnv.Lay50NhanVien();
                foreach (var item in dsnv)
                {
                    if (item.SdtNV == txtSDT.Text)
                    {
                        MessageBox.Show("Nhân viên này đã tồn tại!", "Thông Báo");
                        check = false;
                    }
                }
                if (check == true)
                {
                    TaoMaTuDong();
                    if (lnv.ThemNhanVien(TaoMotNhanVien()) == true)
                    {
                        NhanVien_Load(sender, e);
                        MessageBox.Show("Thêm Nhân Viên Thành Công", "Thông Báo");
                    }
                    else MessageBox.Show("Thêm Thất Bại", "Thông Báo");
                }
            }
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            if (lnv.SuaNhanVien(TaoMotNhanVien()) == true)
            {
                NhanVien_Load(sender, e);
                MessageBox.Show("Sửa Nhân Viên Thành Công", "Thông Báo");
            }
            else
                MessageBox.Show("Sửa Thất Bại", "Thông Báo");
        }

        private void dgvNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int h = dgvDanhSachNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvDanhSachNhanVien.Rows[h].Cells[0].Value.ToString();
            txtTenNV.Text = dgvDanhSachNhanVien.Rows[h].Cells[1].Value.ToString();
            txtSDT.Text = dgvDanhSachNhanVien.Rows[h].Cells[2].Value.ToString();
            txtEmail.Text = dgvDanhSachNhanVien.Rows[h].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvDanhSachNhanVien.Rows[h].Cells[4].Value.ToString();
            txtCMND.Text = dgvDanhSachNhanVien.Rows[h].Cells[5].Value.ToString();
            txtMK.Text = dgvDanhSachNhanVien.Rows[h].Cells[6].Value.ToString();
            if (txtMaNV.Text.Remove(2) == "QL")
            {
                radQuanLy.Checked = true;
            }
            else
            {
                radNhanVien.Checked = true;
            }
            if (dgvDanhSachNhanVien.Rows[h].Cells[7].Value.ToString() == "Đang Hoạt Động")
            {
                radDLV.Checked = true;
            }
            else
            {
                radNghiLam.Checked = true;
            }
            btnSuaTT.Enabled = true;
            btnLuuNV.Enabled = false;
            radNhanVien.Enabled = false;
            radQuanLy.Enabled = false;
        }
        // Tìm kiếm nhân viên theo mã và tên

        void assistant_Idled11(object sender, EventArgs e)
        {
            this.Invoke(
            new MethodInvoker(() =>
            {
                dgvDanhSachNhanVien.DataSource = lnv.TimKiemTheoTen(txtTimKiemNV.Text);
                if (dgvDanhSachNhanVien.RowCount != 0)
                {
                    ForMatNhanVien();
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

        private void frmNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                btnLuuNV_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                btnSuaTT_Click(sender, e);
            }

        }

        ToolTip tip = new ToolTip();
        private void btnLuuNV_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnLuuNV, "Để thêm nhân viên bấm phím Ctrl+A");
        }

        private void btnSuaTT_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnSuaTT, "Để sửa nhân viên bấm phím Ctrl+R");
        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                e.Cancel = true;
                txtSDT.Focus();
                err.SetError(txtSDT, "Không được để trống số điện thoại!");
                sdT = false;
            }
            else if (txtSDT.Text.PhoneCheck() == false)
            {
                e.Cancel = true;
                txtSDT.Focus();
                err.SetError(txtSDT, "Số điện thoại có 10 chữ số bắt đầu là số 0!");
                sdT = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtSDT, null);
                sdT = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                err.SetError(txtEmail, null);
                eMail = false;
            }
            else if (txtEmail.Text.EmailCheck() == false)
            {
                e.Cancel = true;
                txtEmail.Focus();
                err.SetError(txtEmail, "Định dạng email không đúng có thể thiếu @!");
                eMail = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtEmail, null);
                eMail = true;
            }
        }

        private void txtCMND_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCMND.Text))
            {
                e.Cancel = true;
                txtCMND.Focus();
                err.SetError(txtCMND, "Không được để trống chứng minh thư!");
                cmnd = false;
            }
            else if (txtCMND.Text.CheckCMND() == false)
            {
                e.Cancel = true;
                txtCMND.Focus();
                err.SetError(txtCMND, "Chứng minh thư phải có 9 số hoặc 12 số!");
                cmnd = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtCMND, null);
                cmnd = true;
            }
        }

        private void txtMK_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMK.Text))
            {
                e.Cancel = false;
                err.SetError(txtMK, null);
                matK = true;
            }
            else if (txtMK.Text.CheckMK() == false)
            {
                e.Cancel = true;
                txtMK.Focus();
                err.SetError(txtMK, "Mật khẩu tối thiểu 6 và tối đa 23 kí tự, chứa kí tự chữ hoặc số hoặc cả 2!");
                matK = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtMK, null);
                matK = true;
            }
        }

        private void txtTenNV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                e.Cancel = true;
                txtTenNV.Focus();
                err.SetError(txtTenNV, "Không được để trống tên!");
                tenNV = false;
            }
            else if (txtTenNV.Text.NameCheck() == false)
            {
                e.Cancel = true;
                txtTenNV.Focus();
                err.SetError(txtTenNV, "Chữ cái đầu không được là số!");
                tenNV = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTenNV, null);
                btnLuuNV.Enabled = true;
                tenNV = true;
            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                e.Cancel = false;
                err.SetError(txtDiaChi, null);
                diaC = true;
            }
            else if (txtDiaChi.Text.CheckNumber() == true)
            {
                e.Cancel = true;
                txtDiaChi.Focus();
                err.SetError(txtDiaChi, "Địa chỉ phải là một chuỗi!");
                diaC = false;

            }
            else
            {
                e.Cancel = false;
                err.SetError(txtDiaChi, null);
                diaC = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtCMND.Clear();
            txtDiaChi.Clear();
            txtMK.Clear();
            radNhanVien.Enabled = true;
            radQuanLy.Enabled = true;
            btnSuaTT.Enabled = false;
            btnLuuNV.Enabled = true;

        }
    }
}
