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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        BUS_HoaDon lhd = new BUS_HoaDon();
        BUS_KhachHang lkh = new BUS_KhachHang();
        void ForMatHoaDon()
        {
            dgvHoaDon.Columns["maHD"].HeaderText = "Mã Hóa Đơn";
            dgvHoaDon.Columns["maHD"].Width = 160;
            dgvHoaDon.Columns["ngayLapHD"].HeaderText = "Ngày Lập Hóa Đơn";
            dgvHoaDon.Columns["ngayLapHD"].Width = 190;
            dgvHoaDon.Columns["loaiHD"].HeaderText = "Loại Hóa Đơn";
            dgvHoaDon.Columns["loaiHD"].Width = 190;
            dgvHoaDon.Columns["ghiChu"].Visible = false;
            dgvHoaDon.Columns["tenNV"].HeaderText = "Tên Nhân Viên";
            dgvHoaDon.Columns["tenNV"].Width = 160;
            dgvHoaDon.Columns["sdtNV"].HeaderText = "Điện Thoại Nhân Viên";
            dgvHoaDon.Columns["sdtNV"].Width = 200;
            dgvHoaDon.Columns["sdtKH"].Visible = false;
            dgvHoaDon.Columns["tenKH"].Visible = false;
            dgvHoaDon.Columns["maNV"].Visible = false;
            dgvHoaDon.Columns["maKH"].HeaderText = "Mã Khách Hàng";
            dgvHoaDon.Columns["maKH"].Width = 190;
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            List<DTO_HoaDon> dshd = lhd.Lay50HoaDonT();
            dgvHoaDon.DataSource = dshd;
            ForMatHoaDon();
        }
        // Tìm kiếm nhân viên theo mã và tên

        void assistant_Idled11(object sender, EventArgs e)
        {
            this.Invoke(
            new MethodInvoker(() =>
            {
                dgvHoaDon.DataSource = lhd.TimKiemHoaDonTheoMaVaSDT(txtTimKiem.Text);
                if (dgvHoaDon.RowCount != 0)
                {
                    ForMatHoaDon();
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
        // Format Chi Tiết Hóa Đơn
        private void ForMatCTHoaDon()
        {
            dgvDanhSachThuoc.Columns["maThuoc"].HeaderText = "Mã Thuốc";
            dgvDanhSachThuoc.Columns["maThuoc"].Width = 160;
            dgvDanhSachThuoc.Columns["tenThuoc"].HeaderText = "Tên Thuốc";
            dgvDanhSachThuoc.Columns["tenThuoc"].Width = 160;
            dgvDanhSachThuoc.Columns["hoatChatChinh"].HeaderText = "Hoạt Chất Chính";
            dgvDanhSachThuoc.Columns["hoatChatChinh"].Width = 180;
            dgvDanhSachThuoc.Columns["soLuong"].HeaderText = "Số Lượng";
            dgvDanhSachThuoc.Columns["soLuong"].Width = 140;
            dgvDanhSachThuoc.Columns["gia"].HeaderText = "Đơn Giá";
            dgvDanhSachThuoc.Columns["gia"].Width = 150;
            dgvDanhSachThuoc.Columns["donViTinh"].HeaderText = "Đơn Vị Tính";
            dgvDanhSachThuoc.Columns["donViTinh"].Width = 160;
            dgvDanhSachThuoc.Columns["vAT"].HeaderText = "VAT";
            dgvDanhSachThuoc.Columns["vAT"].Width = 100;
        }
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int h = dgvHoaDon.CurrentRow.Index;
            string mahd = dgvHoaDon.Rows[h].Cells[0].Value.ToString();            
            // Lấy Thông Tin Hóa Đơn
            lblMaHD.Text = mahd;
            lblTenNV.Text = dgvHoaDon.Rows[h].Cells[4].Value.ToString();            
            lblNgayLapHD.Text = dgvHoaDon.Rows[h].Cells[1].Value.ToString();
            txtGhiChu.Text = dgvHoaDon.Rows[h].Cells[3].Value.ToString();
            string makh = dgvHoaDon.Rows[h].Cells[9].Value.ToString();
            List<DTO_KhachHang> dskh = lkh.LayHetKhachHang();
            foreach (var item in dskh)
            {
                if (item.MaKH==makh)
                {
                    lblSDTKH.Text = item.SdtKH;
                    lblTenKH.Text = item.TenKH;
                }
                else if(makh=="Không Có")
                {
                    lblSDTKH.Text = "Không Có";
                    lblTenKH.Text = "Không Có";
                }
            }           
            // Lấy Thuốc
            List<DTO_CTHoaDon> dscthd = lhd.LayThuocTheoMaHD(mahd);
            dgvDanhSachThuoc.DataSource = dscthd;
            if (dscthd!=null)
            {
                ForMatCTHoaDon();
            }

            // Lấy Tổng Tiền Và Tổng Vat
            double tongTien = 0;
            double tongVat = 0;
            foreach (var item in dscthd)
            {
                tongTien = tongTien + (item.SoLuong * item.Gia);
                tongVat = tongVat + (item.SoLuong * item.Gia)*(item.VAT/100);
            }
            lblTongTien.Text = tongTien.ToString();
            lblTongVat.Text = tongVat.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
            txtTimKiem.ResetText();
        }
    }
}
