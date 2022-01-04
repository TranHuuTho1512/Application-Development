using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhaThuoc;
using DTO_QuanLyNhaThuoc;

namespace BUS_QuanLyNhaThuoc
{
    public class BUS_NhomThuoc
    {
        DAL_NhomThuoc lnt = new DAL_NhomThuoc();
        // Lấy Hết Nhóm Thuốc
        public List<DTO_NhomThuoc> LayHetNhomThuoc()
        {
            return lnt.LayHetNhomThuoc();
        }
        // Thêm Nhóm Thuốc
        public Boolean ThemNhomThuoc(DTO_NhomThuoc nt)
        {
            return lnt.ThemNhomThuoc(nt);
        }
        //Sửa nhóm thuốc
        public Boolean SuaNhomThuoc(DTO_NhomThuoc nt)
        {
            return lnt.SuaNhomThuoc(nt);
        }
        public int SoNhomThuoc()
        {
            return lnt.SoNhomThuoc();
        }
    }
}
