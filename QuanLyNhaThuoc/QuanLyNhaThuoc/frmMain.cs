using BUS_QuanLyNhaThuoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    public partial class frmMain : Form
    {
        private Form activeForm;
        BUS_ThongKe ltk = new BUS_ThongKe();

        public frmMain()
        {
            InitializeComponent();
            LoadMenu();
            this.KeyPreview = true;
        }
        public frmMain(string ten, string ma) : this()
        {
            lblTen.Text = ten;
            lblMa.Text = ma;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            btnQLBanThuoc.PerformClick();
            loadDoanhThu();
            if (frmDangNhap.maNhanVien.IndexOf("N")==0)
            {
                btnNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
            }
        }
        /// <summary>
        /// hàm xử lý menu ...
        /// </summary>
        void LoadMenu()
        {
            panelBanThuoc.Visible = false;
            panelQuanLyThuoc.Visible = false;

        }
        /// <summary>
        /// ẩn panel khi bấm qua nút khác
        /// </summary>
        private void HidePanel()
        {
            if (panelBanThuoc.Visible == true)
                panelBanThuoc.Visible = false;
            if (panelQuanLyThuoc.Visible == true)
                panelQuanLyThuoc.Visible = false;

        }
        /// <summary>
        /// Hiện panel khi chọn nút có danh mục con
        /// </summary>
        /// <param name="pnl"></param>
        private void ShowPanel(Panel pnl)
        {
            if (pnl.Visible == false)
            {
                HidePanel();
                pnl.Visible = true;
            }
            else
                pnl.Visible = false;
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
            this.panelDuLieu.Controls.Add(childForm);
            this.panelDuLieu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLBanThuoc_Click(object sender, EventArgs e)
        {
            ShowPanel(panelBanThuoc);
            OpenChildForm(new frmBanThuoc(), sender);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

            OpenChildForm(new frmKhachHang(), sender);
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {

            OpenChildForm(new frmHoaDon(), sender);
        }

        private void btnQuanLyThuoc_Click(object sender, EventArgs e)
        {

            ShowPanel(panelQuanLyThuoc);
            OpenChildForm(new frmQuanLyThuoc(), sender);
        }


        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {

            OpenChildForm(new frmNhaCungCap(), sender);
        }

        public void btnLoThuoc_Click(object sender, EventArgs e)
        {

            OpenChildForm(new frmLoThuoc(), sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

            OpenChildForm(new frmNhanVien(), sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            OpenChildForm(new frmThongKe(), sender);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.T)
            {
                btnDangXuat_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.F1)
            {
                btnNhanVien_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.F2)
            {
                btnKhachHang_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.F3)
            {
                btnNhaCungCap_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.F4)
            {
                btnLoThuoc_Click(sender, e);
            }

            if (e.Control  && e.KeyCode == Keys.F5)
            {
                btnQuanLyThuoc_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.F6)
            {
                btnQLBanThuoc_Click(sender, e);
            }

            if (e.Control  && e.KeyCode == Keys.F7)
            {
                btnHoaDonBan_Click(sender, e);
            }

            if (e.Control  && e.KeyCode == Keys.F8)
            {
                btnThongKe_Click(sender, e);
            }
        }
        ToolTip tip = new ToolTip();
        private void btnQLBanThuoc_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnQLBanThuoc, "Để mở form bán thuốc bấm phím Ctrl+F6");
        }

        private void btnKhachHang_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnKhachHang, "Để mở form khách hàng bấm phím Ctrl+F2");
        }

        private void btnHoaDonBan_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnHoaDonBan, "Để mở form hóa đơn bán bấm phím Ctrl+F7");
        }

        private void btnQuanLyThuoc_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnQuanLyThuoc, "Để mở form quản lý thuốc bấm phím Ctrl+F5");
        }

        private void btnLoThuoc_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnLoThuoc, "Để mở form lô thuốc bấm phím Ctrl+F4");
        }

        private void btnNhaCungCap_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnNhaCungCap, "Để mở form nhà cung cấp bấm phím Ctrl+F3");
        }

        private void btnNhanVien_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnNhanVien, "Để mở form bán thuốc bấm phím Ctrl+F1");
        }

        private void btnThongKe_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(btnThongKe, "Để mở form thống kê bấm phím Ctrl+F8");
        }

        void loadDoanhThu()
        {
            lblDoanhThuNVHomNay.Text = String.Format("{0:##,####,####}", ltk.doanhThuNhanVienTheoNgay(frmDangNhap.maNhanVien, DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString()));
            lblDoanhThuNhanVienThang.Text = String.Format("{0:##,####,####}", ltk.doanhThuTheoNhanVienThang(frmDangNhap.maNhanVien, DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString()));

        }

    }
}
