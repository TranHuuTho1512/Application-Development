using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhaThuoc;
using DTO_QuanLyNhaThuoc;
namespace BUS_QuanLyNhaThuoc
{
    public class BUS_LoThuoc
    {
        DAL_LoThuoc llt = new DAL_LoThuoc();
        // Lấy Hết Lô Thuốc
        public List<DTO_LoThuoc> LayHetLoThuoc()
        {
            return llt.LayHetLoThuoc();
        }
        public List<DTO_LoThuoc> Lay30LoThuoc()
        {
            return llt.Lay30LoThuoc();
        }

        // Thêm Lô thuốc
        public Boolean ThemLoThuoc(DTO_LoThuoc lt)
        {
            return llt.ThemLoThuoc(lt);
        }
        //Sửa Lô Thuốc
        public Boolean SuaLoThuoc(DTO_LoThuoc lt)
        {
            return llt.SuaLoThuoc(lt);
        }
        //Tìm Kiếm Theo Mã Tên
        public List<DTO_LoThuoc> TimKiemTheoMaTen(string maten)
        {
            return llt.TimKiemTheoMaTen(maten);
        }
        // Tìm Kiếm Theo Xuất Xứ
        public List<DTO_LoThuoc> TimKiemTheoXuatXu(string xx)
        {
            return llt.TimKiemTheoXuatXu(xx);
        }
        // Số lô Thuốc
        public int SoLoThuoc()
        {
            return llt.SoLoThuoc();
        }
        // lấy lô theo mã thuốc
        public List<DTO_LoThuoc> LayLoTheoMaThuoc(string mat)
        {
            return llt.LayLoThuocTheoMaThuoc(mat);
        }


    }
}
