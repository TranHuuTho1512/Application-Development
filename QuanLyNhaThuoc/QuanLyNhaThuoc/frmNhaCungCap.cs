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
namespace QuanLyNhaThuoc
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
            btnSuaTT.Enabled = false;
        }
        BUS_NhaCungCap lncc = new BUS_NhaCungCap();

        bool tennhacc = true;
        bool sodienthoai = true;
        bool diachi = true;
        bool email = true;
        private void ForMatNhaCungCap()
        {
            dgvDanhSachNCC.Columns["maNCC"].HeaderText = "Mã Nhà Cung Cấp";
            dgvDanhSachNCC.Columns["maNCC"].Width = 180;
            dgvDanhSachNCC.Columns["tenNCC"].HeaderText = "Tên Nhà Cung Cấp";
            dgvDanhSachNCC.Columns["tenNCC"].Width = 180;
            dgvDanhSachNCC.Columns["diaChi"].HeaderText = "Địa Chỉ";
            dgvDanhSachNCC.Columns["diaChi"].Width = 150;
            dgvDanhSachNCC.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDanhSachNCC.Columns["sdt"].Width = 150;
            dgvDanhSachNCC.Columns["email"].HeaderText = "Email";
            dgvDanhSachNCC.Columns["email"].Width = 170;
            dgvDanhSachNCC.Columns["trangThai"].HeaderText = "Trạng Thái";
            dgvDanhSachNCC.Columns["trangThai"].Width = 180;
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            List<DTO_NhaCungCap> dsncc = lncc.Lay50NhaCungCap();
            dgvDanhSachNCC.DataSource = dsncc;
            ForMatNhaCungCap();
        }
        // Tạo Một Đối Tượng Nhà Cung Cấp
        private DTO_NhaCungCap TaoMotNCC()
        {
            DTO_NhaCungCap ncc = new DTO_NhaCungCap();
            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.Sdt = txtSDT.Text;
            ncc.Email = txtEmail.Text;
            if (radDangCC.Checked == true)
            {
                ncc.TrangThai = "Đang Hoạt Động";
            }
            else ncc.TrangThai = "Ngưng Hoạt Động";
            return ncc;
        }
        // Tạo mã tự động
        private void TaoMaNCCTuDong()
        {
            int value = lncc.SoNCC();

            if (value + 1 < 10)
            {
                txtMaNCC.Text = "NCC00" + (value + 1).ToString();
            }
            else if (value + 1 < 100)
            {
                txtMaNCC.Text = "NCC0" + (value + 1).ToString();
            }
            else if (value + 1 == 100)
            {
                txtMaNCC.Text = "NCC" + (value + 1).ToString();
            }

        }
        // Thêm nhà cung cấp
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            List<DTO_NhaCungCap> dsncc = lncc.Lay50NhaCungCap();
            if (txtTenNCC.Text=="" || txtSDT.Text=="")
            {
                MessageBox.Show("Không được để trống tên nhà cung cấp hoặc số điện thoại","Thông báo");
            }
            else if (tennhacc==false || sodienthoai==false || email==false )
            {
                MessageBox.Show("Định dạng chưa đúng!", "Thông báo");
            }
            else
            {
                bool check = true;
                foreach (var item in dsncc)
                {
                    if (item.Sdt==txtSDT.Text)
                    {
                        MessageBox.Show("Nhà Cung Cấp này đã tồn tại!","Thông Báo");
                        check = false;
                    }
                }
                if (check==true)
                {
                    TaoMaNCCTuDong();
                    if (lncc.ThemNhaCungCap(TaoMotNCC()) == true)
                    {
                        frmNhaCungCap_Load(sender, e);
                        MessageBox.Show("Thêm Nhà Cung Cấp Thành Công", "Thông Báo");
                    }
                    else MessageBox.Show("Thêm Thất Bại", "Thông Báo");
                }
            }
        }
        // Sửa nhà cung cấp
        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            if (lncc.SuaNhaCungCap(TaoMotNCC()) == true)
            {
                frmNhaCungCap_Load(sender, e);
                MessageBox.Show("Sửa Nhà Cung Cấp Thành Công", "Thông Báo");
            }
            else MessageBox.Show("Sửa Thất Bại", "Thông Báo");
        }
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
        // Load Nhà Cung Cấp
        private void assinent_ilde(object sender, EventArgs e)
        {
            this.Invoke(
                new MethodInvoker(() =>
                {
                    dgvDanhSachNCC.DataSource = lncc.TimKiemTheoMaTen(txtTimKiemNCC.Text);
                    if (dgvDanhSachNCC.RowCount != 0)
                    {
                        ForMatNhaCungCap();
                    }
                }
                    ));
        }
        // Tìm Kiếm Theo Mã Tên
        TypeAssistant assistant;
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            int delay = 1000;
            assistant = new TypeAssistant(delay);
            assistant.Idled += assinent_ilde;
            assistant.TextChanged();
        }
        
        private void frmNhaCungCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                btnThemNCC_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                btnSuaTT_Click(sender,e);
            }
        }

        ToolTip tip = new ToolTip();
        private void btnThemNCC_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnThemNCC,"Để thêm nhà cung cấp bấm Crtl+A");
        }

        private void btnSuaTT_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnSuaTT, "Để sửa nhà cung cấp bấm Crtl+R");
        }

        private void dgvDanhSachNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgvDanhSachNCC.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells[0].Value.ToString();
                txtTenNCC.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.ToString() == "Đang Hoạt Động")
                {
                    radDangCC.Checked = true;
                }
                else
                {
                    radNgungCC.Checked = true;
                }
                btnSuaTT.Enabled = true;
                btnThemNCC.Enabled = false;
            }
        }

        private void txtTenNCC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNCC.Text))
            {
                e.Cancel = true;
                txtTenNCC.Focus();
                err.SetError(txtTenNCC, "Không được để trống tên nhà cung cấp!");
                tennhacc = false;
            }
            else if (txtTenNCC.Text.NameCheck() == false)
            {
                e.Cancel = true;
                txtTenNCC.Focus();
                err.SetError(txtTenNCC,"Chữ cái đầu không được là số, là một chuỗi kí tự!");
                tennhacc = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTenNCC, null);
                btnThemNCC.Enabled = true;
                tennhacc = true;
            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                e.Cancel = false;
                err.SetError(txtDiaChi, null);
                diachi = true;
            }
            else if (txtDiaChi.Text.CheckNumber() == true)
            {
                e.Cancel = true;
                txtDiaChi.Focus();
                err.SetError(txtDiaChi, "Địa chỉ phải là một chuỗi!");
                diachi = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtDiaChi, null);
                diachi = true;
            }
        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                e.Cancel = true;
                txtSDT.Focus();
                err.SetError(txtSDT, "Không được để trống số điện thoại!");
                sodienthoai = false;
            }
            else if (txtSDT.Text.PhoneCheck() == false)
            {
                e.Cancel = true;
                txtSDT.Focus();
                err.SetError(txtSDT, "Số điện thoại có 10 chữ số bắt đầu là số 0!");
                sodienthoai = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtSDT, null);
                sodienthoai = true;
                
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = false;
                err.SetError(txtEmail, null);
                email = true;
            }
            else if (txtEmail.Text.EmailCheck() == false)
            {
                e.Cancel = true;
                txtEmail.Focus();
                err.SetError(txtEmail, "Định dạng email không đúng có thể thiếu @!");
                email = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtEmail,null);
                email = true;
            }
        }

        private void btnResetNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap_Load(sender,e);
            txtTimKiemNCC.ResetText();
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtSDT.ResetText();
            btnThemNCC.Enabled = true;
            btnSuaTT.Enabled = false;

        }
    }
}
