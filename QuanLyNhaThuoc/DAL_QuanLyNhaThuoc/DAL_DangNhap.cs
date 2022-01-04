using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNhaThuoc;
namespace DAL_QuanLyNhaThuoc
{
    public class DAL_DangNhap
    {
        DAL_NhanVien dnv = new DAL_NhanVien();
        public Boolean DangNhap(string ma, string mk)
        {
            List<DTO_NhanVien> dsnv = dnv.LayHetNhanVien();
            foreach (var item in dsnv)
            {
                if (item.MaNV == ma && item.MatKhau == mk)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
