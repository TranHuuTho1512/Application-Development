using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNhaThuoc;
using DAL_QuanLyNhaThuoc;
namespace BUS_QuanLyNhaThuoc
{
    public class BUS_HoaDon
    {
        DAL_HoaDon lhd = new DAL_HoaDon();
        //Lấy Hết Hóa Đơn
        public List<DTO_HoaDon> LayHetHoaDonT()
        {
            return lhd.LayHetHoaDonT();
        }
        public List<DTO_HoaDon> Lay50HoaDonT()
        {
            return lhd.Lay50HoaDonT();
        }

        // Tìm Kiếm Hóa Đơn
        public List<DTO_HoaDon> TimKiemHoaDonTheoMaVaSDT(string sdtma)
        {
            return lhd.TimKiemHoaDonTheoMaVaSDT(sdtma);
        }
        // Lấy thuốc theo mã hóa đơn
        public List<DTO_CTHoaDon> LayThuocTheoMaHD(string mahd)
        {
            return lhd.LayThuocTheoMaHD(mahd);
        }
        public int SoHoaDon()
        {
            return lhd.SoHoaDon();
        }
    }
}
