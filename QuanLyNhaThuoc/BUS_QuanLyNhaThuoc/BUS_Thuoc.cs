using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhaThuoc;
using DTO_QuanLyNhaThuoc;

namespace BUS_QuanLyNhaThuoc
{
    public class BUS_Thuoc
    {
        DAL_Thuoc lt = new DAL_Thuoc();
        // Lấy hết thuốc 2 bảng
        public List<DTO_Thuoc> LayHetThuocT()
        {
            return lt.LayHetThuocT();
        }

        //Lấy thuốc theo mã kết 2 bảng
        public List<DTO_Thuoc> LayThuocTheoMaT(string mant)
        {
            return lt.LayThuocTheoMaT(mant);
        }
        // Tìm kiếm theo mã tên kết 2 bảng
        public List<DTO_Thuoc> TimKiemTheoMaTenT(string maten, string mant)
        {
            return lt.TimKiemTheoMaTenT(maten, mant);
        }
        //Thêm Thuốc
        public Boolean ThemThuoc(DTO_Thuoc t)
        {
            return lt.ThemThuoc(t);
        }
        // Sửa Thuốc
        public Boolean SuaThuoc(DTO_Thuoc t)
        {
            return lt.SuaThuoc(t);
        }
        // Lấy số thuốc
        public int LaySoThuoc()
        {
            return lt.SoThuoc();
        }
    }
}
