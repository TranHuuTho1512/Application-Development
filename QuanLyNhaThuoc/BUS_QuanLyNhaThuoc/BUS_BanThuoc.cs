using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNhaThuoc;
using DAL_QuanLyNhaThuoc;
namespace BUS_QuanLyNhaThuoc
{
    public class BUS_BanThuoc
    {
        DAL_BanThuoc lhd = new DAL_BanThuoc();
        // Lấy Thông Tin Thuốc
        public List<DTO_BanThuoc> LayThongTinThuoc()
        {
            return lhd.LayThongTinThuoc();
        }
        // Lấy Thông Tin Thuốc Theo Nhóm
        public List<DTO_BanThuoc> LayThongTinThuocTheoNhom(string mant)
        {
            return lhd.LayThongTinThuocTheoNhom(mant);
        }
        // Tìm Kiếm Theo Tên Mã
        public List<DTO_BanThuoc> TimKiemThuocTheoTenMa(string maten, string mant)
        {
            return lhd.TimKiemThuocTheoMaTen(maten, mant);
        }
        //
        public void SuaSoLuongTon(string maLo, int soL)
        {
            lhd.SuaSoLuongTon(maLo, soL);
        }
        // Thêm Hóa Đơn
        public Boolean ThemHoaDon(HoaDon hd)
        {
            return lhd.ThemHoaDon(hd);
        }
        // Thêm chi tiết hóa đơn
        public Boolean ThemCTHoaDon(CT_HoaDon cthd)
        {
            return lhd.ThemCTHoaDon(cthd);
        }
        // Đếm hóa đơn
        public int SoHoaDon()
        {
            return lhd.SoHoaDon();
        }
        // Tìm Kiếm Xuất Xứ
        public List<DTO_BanThuoc> TimKiemTheoXuatXu(string mant, string xx)
        {
            return lhd.TimKiemTheoXuaTXu(mant,xx);
        }
    }
}
