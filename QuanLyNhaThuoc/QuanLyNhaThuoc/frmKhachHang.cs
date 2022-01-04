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
    public partial class frmKhachHang : Form
    {
        public delegate void kh(string sdt);
        public event kh khevent;
        public frmKhachHang()
        {
            InitializeComponent();
            this.KeyPreview = true;
            btnSuaKH.Enabled = false;
        }
        BUS_KhachHang lkh = new BUS_KhachHang();
        bool tenkh = true;
        bool diachi = true;
        bool sodt = true;
        bool email = true;
        private void ForMatKhachHang()
        {
            dgvDanhSachKH.Columns["maKH"].HeaderText = "Mã Khách Hàng";
            dgvDanhSachKH.Columns["maKH"].Width = 190;
            dgvDanhSachKH.Columns["tenKH"].HeaderText = "Tên Khách Hàng";
            dgvDanhSachKH.Columns["tenKH"].Width = 180;
            dgvDanhSachKH.Columns["sdtKH"].HeaderText = "Số Điện Thoại";
            dgvDanhSachKH.Columns["sdtKH"].Width = 180;
            dgvDanhSachKH.Columns["diaChi"].HeaderText = "Địa Chỉ";
            dgvDanhSachKH.Columns["diaChi"].Width = 170;
            dgvDanhSachKH.Columns["email"].HeaderText = "Email";
            dgvDanhSachKH.Columns["email"].Width = 200;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            List<DTO_KhachHang> dskh = lkh.Lay50KhachHang();
            dgvDanhSachKH.DataSource = dskh;
            ForMatKhachHang();
        }
        // Tạo Mã thuốc tự Đông
        private void TaoMaThuocTuDong()
        {
            int value = lkh.SoKH();
            if (value + 1 < 10)
            {
                txtMaKH.Text = "KH000000000" + (value + 1).ToString();
            }
            else if (value + 1 < 100)
            {
                txtMaKH.Text = "KH00000000" + (value + 1).ToString();
            }
            else if (value + 1 < 1000)
            {
                txtMaKH.Text = "KH0000000" + (value + 1).ToString();
            }
            else if (value + 1 < 10000)
            {
                txtMaKH.Text = "KH000000" + (value + 1).ToString();
            }
            else if (value + 1 < 100000)
            {
                txtMaKH.Text = "KH00000" + (value + 1).ToString();
            }
            else if (value + 1 < 1000000)
            {
                txtMaKH.Text = "KH0000" + (value + 1).ToString();
            }
            else if (value + 1 < 10000000)
            {
                txtMaKH.Text = "KH000" + (value + 1).ToString();
            }
            else if (value + 1 < 100000000)
            {
                txtMaKH.Text = "KH00" + (value + 1).ToString();
            }
            else if (value + 1 < 1000000000)
            {
                txtMaKH.Text = "KH0" + (value + 1).ToString();
            }
            else if (value + 1 == 1000000000)
            {
                txtMaKH.Text = "KH" + (value + 1).ToString();
            }
        }
        // Tạo Một khách hàng
        private DTO_KhachHang TaoMotKhachHang()
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.SdtKH = txtSDT.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.Email = txtEmail.Text;
            return kh;
        }

        private void dgvKhachHang_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int h = dgvDanhSachKH.CurrentRow.Index;
            txtMaKH.Text = dgvDanhSachKH.Rows[h].Cells[0].Value.ToString();
            txtTenKH.Text = dgvDanhSachKH.Rows[h].Cells[1].Value.ToString();
            txtSDT.Text = dgvDanhSachKH.Rows[h].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvDanhSachKH.Rows[h].Cells[4].Value.ToString();
            txtEmail.Text = dgvDanhSachKH.Rows[h].Cells[3].Value.ToString();
            btnSuaKH.Enabled = true;
            btnLuuKH.Enabled = false;
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            
            if (txtTenKH.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Không để tên khách hàng hoặc số điện thoại trống!", "Thông báo!");
            }
            else if (tenkh == false || diachi == false || sodt == false || email == false)
            {
                MessageBox.Show("Có thể định dạng sai!", "Thông báo");
            }
            else
            {
                if (lkh.SuaKhachHang(TaoMotKhachHang()) == true)
                {
                    frmKhachHang_Load(sender, e);
                    MessageBox.Show("Sửa Khách Hàng Thành Công", "Thông Báo");
                }
                else MessageBox.Show("Sửa Khách Hàng Thất Bại", "Thông Báo");
            }
           
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
        TypeAssistant assistant;
        //Load Khách Hàng
        private void assistant_IdLi(object sender, EventArgs e)
        {
            this.Invoke(
                 new MethodInvoker(() =>
                 {
                     dgvDanhSachKH.DataSource = lkh.TimKiemKhachHangTheoMaTen(txtTimKiemKH.Text);
                     if (dgvDanhSachKH.RowCount != 0)
                     {
                         ForMatKhachHang();
                     }
                 }));
        }
        //sdtKH
        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            List<DTO_KhachHang> dskh = lkh.Lay50KhachHang();
            if (txtTenKH.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Không để tên khách hàng hoặc số điện thoại trống!", "Thông báo!");
            }
            else if (tenkh == false || diachi == false || sodt == false || email == false)
            {
                MessageBox.Show("Có thể định dạng sai!", "Thông báo");
            }
            else
            {
                bool check = true;
                foreach (var item in dskh)
                {
                    if (item.SdtKH== txtSDT.Text)
                    {
                        MessageBox.Show("Khách hàng đã tồn tại!", "Thông báo");
                        check = false;
                    }
                }
                if (check==true)
                {
                    TaoMaThuocTuDong();
                    if (lkh.ThemKhachHang(TaoMotKhachHang()) == true)
                    {
                        frmKhachHang_Load(sender, e);
                        MessageBox.Show("Thêm Khách Hàng Thành Công", "Thông Báo");
                    }
                    else MessageBox.Show("Thêm Thất Bại", "Thông Báo");
                    string sdt = txtSDT.Text;
                    if (khevent != null)
                    {
                        khevent(sdt);
                        this.Hide();
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            int delay = 1000;
            assistant = new TypeAssistant(delay);
            assistant.Idled += assistant_IdLi;
            assistant.TextChanged();
        }
        private void frmKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                btnLuuKH_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                btnSuaKH_Click(sender,e);
            }
        }
        ToolTip tip = new ToolTip();
        private void btnLuuKH_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnLuuKH,"Để thêm khách hàng bấm phím Ctrl+A");
        }

        private void btnSuaKH_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnSuaKH, "Để sửa khách hàng bấm phím Ctrl+R");
        }

        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                e.Cancel = true;
                txtTenKH.Focus();
                err.SetError(txtTenKH,"Không được để trống tên khách hàng!");
                tenkh = false;
            }
            else if (txtTenKH.Text.NameCheck() == false)
            {
                e.Cancel = true;
                txtTenKH.Focus();
                err.SetError(txtTenKH, "Chữ cái đầu không được là số, không chưa kí tự đặt biệt!");
                tenkh = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTenKH, null);
                btnLuuKH.Enabled = true;
                tenkh = true;
            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                e.Cancel = false;
                err.SetError(txtDiaChi,null);
                diachi = true;
            }
            else if (txtDiaChi.Text.CheckNumber()==true)
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
                sodt = false;
            }
            else if (txtSDT.Text.CheckNumber()==false)
            {
                e.Cancel = true;
                txtSDT.Focus();
                err.SetError(txtSDT, "Số điện thoại phải là số!");
                sodt = false;
            }
            else if (txtSDT.Text.PhoneCheck() == false)
            {
                e.Cancel = true;
                txtSDT.Focus();
                err.SetError(txtSDT, "Số điện thoại có 10 chữ số bắt đầu là số 0!");
                sodt = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtSDT, null);
                sodt = true;
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
            else
            if (txtEmail.Text.EmailCheck() == false)
            {
                e.Cancel = true;
                txtEmail.Focus();
                err.SetError(txtEmail, "Định dạng email không đúng có thể thiếu @!");
                email = false;
            }
          
            else
            {
                e.Cancel = false;
                err.SetError(txtEmail, null);
                email = true;
            }
        }

        private void btnResetKH_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
            txtTimKiemKH.ResetText();
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            btnSuaKH.Enabled = false;
            btnLuuKH.Enabled = true;

        }
    }
}
