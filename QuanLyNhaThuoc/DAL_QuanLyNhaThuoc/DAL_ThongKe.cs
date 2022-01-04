using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNhaThuoc;

namespace DAL_QuanLyNhaThuoc
{
    public class DAL_ThongKe
    {
        QLQTDataContext db;
        public DAL_ThongKe()
        {
            db = new QLQTDataContext();
        }

        // Tổng doanh thu theo ngày
        public double doanhThuTheoNgay(string ngay, string thang, string nam)
        {
            var p = (from hd in db.HoaDons
                     join cthd in db.CT_HoaDons on hd.maHD equals cthd.maHD
                     join t in db.Thuocs on cthd.maThuoc equals t.maThuoc
                     where (hd.ngayLapHD.Value.Day.ToString() == ngay && hd.ngayLapHD.Value.Month.ToString() == thang && hd.ngayLapHD.Value.Year.ToString() == nam)
                     select new
                     {
                         thanhTien = cthd.gia * cthd.soLuong * (1 + (cthd.vAT / 100))
                     }).ToList();
            double tongTien = 0;
            if (p != null)
            {
                foreach (var item in p)
                {
                    tongTien += Convert.ToDouble(item.thanhTien);
                }
                return tongTien;
            }
            else return 0;

        }

        //Tổng doanh thu theo tháng
        public double doanhThuTheoThang(string thang, string nam)
        {
            var p = (from hd in db.HoaDons
                     join cthd in db.CT_HoaDons on hd.maHD equals cthd.maHD
                     join t in db.Thuocs on cthd.maThuoc equals t.maThuoc
                     where (hd.ngayLapHD.Value.Month.ToString() == thang && hd.ngayLapHD.Value.Year.ToString() == nam)
                     select new
                     {
                         thanhTien = cthd.gia * cthd.soLuong * (1 + (cthd.vAT / 100))
                     }).ToList();
            double tongTien = 0;
            if (p != null)
            {
                foreach (var item in p)
                {
                    tongTien += Convert.ToDouble(item.thanhTien);
                }
                return tongTien;
            }
            else return 0;

        }

        //Tổng doanh thu theo năm
        public double doanhThuTheoNam(string nam)
        {
            var p = (from hd in db.HoaDons
                     join cthd in db.CT_HoaDons on hd.maHD equals cthd.maHD
                     join t in db.Thuocs on cthd.maThuoc equals t.maThuoc
                     where (hd.ngayLapHD.Value.Year.ToString() == nam)
                     select new
                     {
                         thanhTien = cthd.gia * cthd.soLuong * (1 + (cthd.vAT / 100))
                     }).ToList();
            double tongTien = 0;
            if (p != null)
            {
                foreach (var item in p)
                {
                    tongTien += Convert.ToDouble(item.thanhTien);
                }
                return tongTien;
            }
            else return 0;

        }

        // Đơn thuốc theo ngày
        public int donThuocTheoNgay(string ngay, string thang, string nam)
        {
            var p = (from hd in db.HoaDons
                     where (hd.ngayLapHD.Value.Day.ToString() == ngay && hd.ngayLapHD.Value.Month.ToString() == thang && hd.ngayLapHD.Value.Year.ToString() == nam)
                     select new
                     {
                         maHD = hd.maHD
                     }).ToList();
            if (p != null)
            {
                return p.Count;
            }
            else return 0;

        }
        // Đơn thuốc theo tháng
        public int donThuocTheoThang(string thang, string nam)
        {
            var p = (from hd in db.HoaDons
                     where (hd.ngayLapHD.Value.Month.ToString() == thang && hd.ngayLapHD.Value.Year.ToString() == nam)
                     select new
                     {
                         maHD = hd.maHD
                     }).ToList();
            if (p != null)
            {
                return p.Count;
            }
            else return 0;

        }
        // Đơn thuốc theo năm
        public int donThuocTheoNam(string nam)
        {
            var p = (from hd in db.HoaDons
                     where (hd.ngayLapHD.Value.Year.ToString() == nam)
                     select new
                     {
                         maHD = hd.maHD
                     }).ToList();
            if (p != null)
            {
                return p.Count;
            }
            else return 0;

        }

        //Doanh thu nhân viên theo tháng
        public double doanhThuTheoNhanVienThang(string maNV, string thang, string nam)
        {
            var p = (from hd in db.HoaDons
                     join cthd in db.CT_HoaDons on hd.maHD equals cthd.maHD
                     where (hd.maNV == maNV && hd.ngayLapHD.Value.Month.ToString() == thang && hd.ngayLapHD.Value.Year.ToString() == nam)
                     select new
                     {
                         thanhTien = cthd.gia * cthd.soLuong * (1 + (cthd.vAT / 100))
                     }).ToList();
            double tongTien = 0;
            if (p != null)
            {
                foreach (var item in p)
                {
                    tongTien += Convert.ToDouble(item.thanhTien);
                }
                return tongTien;
            }
            else return 0;

        }
        //Doanh thu nhân viên theo ngày
        public double doanhThuNhanVienTheoNgay(string maNV, string ngay, string thang, string nam)
        {
            var p = (from hd in db.HoaDons
                     join cthd in db.CT_HoaDons on hd.maHD equals cthd.maHD
                     join t in db.Thuocs on cthd.maThuoc equals t.maThuoc
                     where (hd.maNV == maNV && hd.ngayLapHD.Value.Day.ToString() == ngay && hd.ngayLapHD.Value.Month.ToString() == thang && hd.ngayLapHD.Value.Year.ToString() == nam)
                     select new
                     {
                         thanhTien = cthd.gia * cthd.soLuong * (1 + (cthd.vAT / 100))
                     }).ToList();
            double tongTien = 0;
            if (p != null)
            {
                foreach (var item in p)
                {
                    tongTien += Convert.ToDouble(item.thanhTien);
                }
                return tongTien;
            }
            else return 0;
        }


        // Đơn thuốc nhân viên theo ngày
        public int donThuocNhanVienTheoNgay(string manv, string ngay, string thang, string nam)
        {
            var p = (from hd in db.HoaDons
                     where (hd.ngayLapHD.Value.Day.ToString() == ngay && hd.ngayLapHD.Value.Month.ToString() == thang && hd.ngayLapHD.Value.Year.ToString() == nam && hd.maNV == manv)
                     select new
                     {
                         maHD = hd.maHD
                     }).ToList();
            if (p != null)
            {
                return p.Count;
            }
            else return 0;

        }
        // Đơn thuốc nhân viên theo tháng
        public int donThuocNhanVienTheoThang(string manv, string thang, string nam)
        {
            var p = (from hd in db.HoaDons
                     where (hd.ngayLapHD.Value.Month.ToString() == thang && hd.ngayLapHD.Value.Year.ToString() == nam && hd.maNV == manv)
                     select new
                     {
                         maHD = hd.maHD
                     }).ToList();
            if (p != null)
            {
                return p.Count;
            }
            else return 0;

        }





        // Thống kê thuốc hết hạn
        public List<object> thongKeThuocHetHan()
        {
            List<object> dslt = new List<object>();
            DateTime hienTai = DateTime.Now;
            var p = (from n in db.LoThuocs
                     join t in db.Thuocs on n.maThuoc equals t.maThuoc
                     join ncc in db.NhaCungCaps on n.maNCC equals ncc.maNCC
                     where (n.hanSuDung.Value.Year < hienTai.Year || (n.hanSuDung.Value.Year == hienTai.Year && n.hanSuDung.Value.Month < hienTai.Month) || (n.hanSuDung.Value.Year == hienTai.Year && n.hanSuDung.Value.Month == hienTai.Month && n.hanSuDung.Value.Day <= hienTai.Day))
                     select new
                     {
                         maLoThuoc = n.maLoThuoc,
                         maThuoc = n.maThuoc,
                         tenThuoc = t.tenThuoc,
                         maNCC = n.maNCC,
                         tenNCC = ncc.tenNCC,
                         xuatXu = n.xuatXu,
                         ngaySanXuat = n.ngaySanXuat,
                         hanSuDung = n.hanSuDung,
                         donViTinh = n.donViTinh,
                         donViQuyDoi = n.donViQuyDoi,
                         tyLeQuyDoi = n.tyLeQuyDoi,
                         giaBanChan = n.giaBanChan,
                         giaBanLe = n.giaBanLe,
                         lieuLuongDung = n.lieuLuongDung,
                         moTa = n.moTa,
                         VAT = n.VAT,
                         soLuongTon = n.soLuongTon
                     }).OrderBy(x => x.hanSuDung).ToList();
            if (p != null)
            {
                foreach (var item in p)
                {
                    if (Convert.ToInt32(item.soLuongTon.ToString()) > 0)
                    {

                        dslt.Add(item);
                    }
                }
                return dslt;
            }
            return null;
        }

        // Thống kê thuốc hết hạn trong số ngày tới < 60 ngày
        public List<object> thongKeThuocHetHanTrongSoNgay(int ngay)
        {
            int ngayTL = DateTime.Now.Day;
            int thangTL = DateTime.Now.Month;
            int namTL = DateTime.Now.Year;
            DateTime NTNTL = DateTime.Now;
            ngayTL += ngay;
            if ((thangTL == 1 || thangTL == 3 || thangTL == 5 || thangTL == 7 || thangTL == 8 || thangTL == 10) && ngayTL > 31)
            {
                ngayTL -= 31;
                thangTL += 1;
            }
            else if ((thangTL == 4 || thangTL == 6 || thangTL == 9 || thangTL == 11) && ngayTL > 30)
            {
                ngayTL -= 30;
                thangTL += 1;
            }
            else if (thangTL == 2 && ngayTL > 28)
            {
                ngayTL -= 28;
                thangTL += 1;
            }
            else if (thangTL == 12 && ngayTL > 31)
            {
                ngayTL -= 31;
                thangTL = 1;
                namTL += 1;
            }
            DateTime a = new DateTime(namTL, thangTL, ngayTL);
            List<object> dslt = new List<object>();
            var p = (from n in db.LoThuocs
                     join t in db.Thuocs on n.maThuoc equals t.maThuoc
                     join ncc in db.NhaCungCaps on n.maNCC equals ncc.maNCC
                     where (n.hanSuDung > DateTime.Now && n.hanSuDung <= a)
                     select new
                     {
                         maLoThuoc = n.maLoThuoc,
                         maThuoc = n.maThuoc,
                         tenThuoc = t.tenThuoc,
                         maNCC = n.maNCC,
                         tenNCC = ncc.tenNCC,
                         xuatXu = n.xuatXu,
                         ngaySanXuat = n.ngaySanXuat,
                         hanSuDung = n.hanSuDung,
                         donViTinh = n.donViTinh,
                         donViQuyDoi = n.donViQuyDoi,
                         tyLeQuyDoi = n.tyLeQuyDoi,
                         giaBanChan = n.giaBanChan,
                         giaBanLe = n.giaBanLe,
                         lieuLuongDung = n.lieuLuongDung,
                         moTa = n.moTa,
                         VAT = n.VAT,
                         soLuongTon = n.soLuongTon
                     }).OrderBy(x => x.hanSuDung).ToList();
            if (p != null)
            {
                foreach (var item in p)
                {
                    if (item.soLuongTon > 0)
                        dslt.Add(item);
                }
                return dslt;
            }
            return null;
        }



    }
}