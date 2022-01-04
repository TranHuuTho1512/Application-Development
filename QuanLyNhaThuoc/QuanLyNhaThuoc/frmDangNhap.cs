using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyNhaThuoc;
using DTO_QuanLyNhaThuoc;

namespace QuanLyNhaThuoc
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }


        public static string maNhanVien = "";
        public static string tenNhanVien = "";
        BUS_DangNhap bdn = new BUS_DangNhap();
        BUS_NhanVien bnv = new BUS_NhanVien();
        bool dKThucHienUser= true;
        bool dKThucHienPass = true;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Kiểm tra giá trị
        private void txtTaiKhoan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                e.Cancel = true;
                txtTaiKhoan.Focus();
                err.SetError(txtTaiKhoan, "Vui lòng không để trống tên đăng nhập!");
                dKThucHienUser = false;
            }
            else if (txtTaiKhoan.Text.CheckUserName() == false)
            {
                e.Cancel = true;
                txtTaiKhoan.Focus();
                err.SetError(txtTaiKhoan, "Tên đăng nhập phải bắt đầu là NV hoặc QL và có 6 kí tự");
                dKThucHienUser = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTaiKhoan, null);
                dKThucHienUser = true;
            }
        }
        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                e.Cancel = true;
                txtMatKhau.Focus();
                err.SetError(txtMatKhau, "Vui lòng không để trống tên đăng nhập!");
                dKThucHienPass = false;
            }
            else if (txtMatKhau.Text.CheckMK() == false)
            {
                e.Cancel = true;
                txtMatKhau.Focus();
                err.SetError(txtMatKhau, "Tên đăng nhập không có kí tự đặt biệt có 6 tới 23 kí tự!");
                dKThucHienPass = false;
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtMatKhau, null);
                dKThucHienPass = true;
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            List<DTO_NhanVien> dsnv = bnv.LayHetNhanVien();
            if (txtTaiKhoan.Text=="" || txtMatKhau.Text=="")
            {
                MessageBox.Show("Mật khẩu hoặc tài khoản bị trống hoặc cả hai!");
            }
            else if (dKThucHienUser==true && dKThucHienPass==true)
            {

                if (bdn.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == true)
                {
                    foreach (var item in dsnv)
                    {
                        if (item.MatKhau == txtMatKhau.Text && item.MaNV == txtTaiKhoan.Text && item.TrangThai == "Đang Hoạt Động")
                        {
                            
                            maNhanVien = txtTaiKhoan.Text;
                            tenNhanVien = item.TenNV;
                            frmMain f = new frmMain(item.TenNV, item.MaNV);
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }                       
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc Mật khẩu không tồn tại!", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng định dạng hoặc thiếu kí tự hoặc thừa kí tự!","Thông Báo");
            }
        }

        // Phím Tắt
        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnThoat_Click(sender, e);
            }

        }
        // Hiển thị phím tắt
        ToolTip tip = new ToolTip();
        private void btnDangNhap_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnDangNhap, "Đăng nhập bấm phím Enter");
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnThoat, "Thoát bấm phím ESC");
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                txtMatKhau.Focus();
                err.SetError(txtMatKhau, "Vui lòng không để trống tên đăng nhập!");
                dKThucHienPass = false;
            }
            else if (txtMatKhau.Text.CheckMK() == false)
            {
                txtMatKhau.Focus();
                err.SetError(txtMatKhau, "Tên đăng nhập không có kí tự đặt biệt có 6 tới 23 kí tự!");
                dKThucHienPass = false;
            }
            else
            {
                err.SetError(txtMatKhau, null);
                dKThucHienPass = true;
            }
        }
    }
}
