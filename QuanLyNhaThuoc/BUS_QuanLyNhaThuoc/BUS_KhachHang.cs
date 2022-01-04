using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhaThuoc;
using DTO_QuanLyNhaThuoc;
namespace BUS_QuanLyNhaThuoc
{
   public class BUS_KhachHang
    {
        DAL_KhachHang lkh = new DAL_KhachHang();
        // Lấy Hết Nhân Viên
        public List<DTO_KhachHang> LayHetKhachHang()
        {
            return lkh.LayHetKhachHang();
        }
        public List<DTO_KhachHang> Lay50KhachHang()
        {
            return lkh.Lay50KhachHang();
        }
        // Tìm Kiếm Khách Hàng Theo Mã Và tên

        public List<DTO_KhachHang> TimKiemKhachHangTheoMaTen(string maten)
        {
            return lkh.TimKiemKhachHangTheoMaTen(maten);
        }
        // Thêm khách hàng
        public Boolean ThemKhachHang(DTO_KhachHang kh)
        {
            return lkh.ThemKhachHang(kh);
        }
        //sửa khách hàng
        public Boolean SuaKhachHang(DTO_KhachHang kh)
        {
            return lkh.SuaKhachHang(kh);
        }
        public int SoKH()
        {
            return lkh.SoKH();
        }
    }
}
