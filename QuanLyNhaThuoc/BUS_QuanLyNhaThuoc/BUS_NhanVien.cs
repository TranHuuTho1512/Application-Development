using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhaThuoc;
using DTO_QuanLyNhaThuoc;
namespace BUS_QuanLyNhaThuoc
{
    public class BUS_NhanVien
    {
        DAL_NhanVien lnv = new DAL_NhanVien();
        // Lấy danh sách nhân viên
        public List<DTO_NhanVien> LayHetNhanVien()
        {
            return lnv.LayHetNhanVien();
        }
        public List<DTO_NhanVien> Lay50NhanVien()
        {
            return lnv.Lay50NhanVien();
        }

        // Lấy nhân viên theo mã và tên
        public List<DTO_NhanVien> TimKiemTheoTen(string maten)
        {
            return lnv.TimKiemTheoMaTen(maten);
        }
        // Thêm nhân viên
        public Boolean ThemNhanVien(DTO_NhanVien nv)
        {
            return lnv.ThemNhanVien(nv);
        }
        // Sửa nhân viên
        public Boolean SuaNhanVien(DTO_NhanVien nv)
        {
            return lnv.SuaNhanVien(nv);
        }
        public int SoNhanVien()
        {
            return lnv.SoNhanVien();
        }
    }
}
