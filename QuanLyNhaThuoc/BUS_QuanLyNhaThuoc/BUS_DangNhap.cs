using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhaThuoc;
namespace BUS_QuanLyNhaThuoc
{
    public class BUS_DangNhap
    {
        DAL_DangNhap dn = new DAL_DangNhap();
        // Kiểm tra nhân viên
        public Boolean DangNhap(string ma, string mk)
        {
            return dn.DangNhap(ma, mk);
        }
    }
}
