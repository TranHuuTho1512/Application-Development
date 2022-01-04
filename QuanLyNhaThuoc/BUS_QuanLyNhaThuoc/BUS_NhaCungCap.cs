using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhaThuoc;
using DTO_QuanLyNhaThuoc;
namespace BUS_QuanLyNhaThuoc
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap lncc = new DAL_NhaCungCap();
        // Lấy Hết Nhà Cung Cấp
        public List<DTO_NhaCungCap> LayHetNhaCungCap()
        {
            return lncc.LayHetNhaCungCap();
        }
        public List<DTO_NhaCungCap> Lay50NhaCungCap()
        {
            return lncc.Lay50NhaCungCap();
        }

        // Tìm Kiếm Theo Mã Tên
        public List<DTO_NhaCungCap> TimKiemTheoMaTen(string maten)
        {
            return lncc.TimKiemTheoMaTen(maten);
        }
        // Thêm Nhà Cung Cấp
        public Boolean ThemNhaCungCap(DTO_NhaCungCap ncc)
        {
            return lncc.ThemNhaCungCap(ncc);
        }
        // Sửa Nhà CUng Cấp
        public Boolean SuaNhaCungCap(DTO_NhaCungCap ncc)
        {
            return lncc.SuaNhaCungCap(ncc);
        }
        public int SoNCC()
        {
            return lncc.SoNCC();
        }
    }
}
