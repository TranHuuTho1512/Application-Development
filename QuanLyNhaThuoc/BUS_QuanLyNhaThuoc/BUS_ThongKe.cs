using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhaThuoc;
using DTO_QuanLyNhaThuoc;

namespace BUS_QuanLyNhaThuoc
{
    public class BUS_ThongKe
    {
        DAL_ThongKe tk = new DAL_ThongKe();
        public double doanhThuTheoNgay(string ngay, string thang, string nam)
        {
            return tk.doanhThuTheoNgay(ngay, thang, nam);
        }
        public double doanhThuTheoThang(string thang, string nam)
        {
            return tk.doanhThuTheoThang(thang, nam);
        }
        public double doanhThuTheoNam(string nam)
        {
            return tk.doanhThuTheoNam(nam);
        }
        public int donThuocTheoNgay(string ngay, string thang, string nam)
        {
            return tk.donThuocTheoNgay(ngay, thang, nam);
        }
        public int donThuocTheoThang(string thang, string nam)
        {
            return tk.donThuocTheoThang(thang, nam);
        }
        public int donThuocTheoNam(string nam)
        {
            return tk.donThuocTheoNam(nam);
        }
        public int donThuocNhanVienTheoNgay(string manv, string ngay, string thang, string nam)
        {
            return tk.donThuocNhanVienTheoNgay(manv, ngay, thang, nam);
        }
        public int donThuocNhanVienTheoThang(string manv, string thang, string nam)
        {
            return tk.donThuocNhanVienTheoThang(manv, thang, nam);
        }

        public double doanhThuNhanVienTheoNgay(string maNV, string ngay, string thang, string nam)
        {
            return tk.doanhThuNhanVienTheoNgay(maNV, ngay, thang, nam);
        }
        public double doanhThuTheoNhanVienThang(string maNV, string thang, string nam)
        {
            return tk.doanhThuTheoNhanVienThang(maNV, thang, nam);
        }
        public List<object> thongKeThuocHetHan()
        {
            return tk.thongKeThuocHetHan();
        }
        public List<object> thongKeThuocHetHanTrongSoNgay(int ngay)
        {
            return tk.thongKeThuocHetHanTrongSoNgay(ngay);
        }



    }
}
