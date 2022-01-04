using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNhaThuoc;
namespace DAL_QuanLyNhaThuoc
{
    public class DAL_HoaDon
    {
        QLQTDataContext db;
        public DAL_HoaDon()
        {
            db = new QLQTDataContext();
        }
        // Lấy Hóa Đơn       
        public List<DTO_HoaDon> LayHetHoaDonT()
        {
            List<DTO_HoaDon> lhd = new List<DTO_HoaDon>();
            var p = (from hd in db.HoaDons
                     join nv in db.NhanViens on hd.maNV equals nv.maNV
                     select new
                     {
                         mahd = hd.maHD,
                         ngaylhd = hd.ngayLapHD,
                         lhd = hd.loaiHD,
                         ghichu = hd.ghiChu,
                         tennv = nv.tenNV,
                         sdtnv = nv.sdtNV,
                         manv = hd.maNV,
                         makh = hd.maKH
                     }).ToList();
            if (p != null)
            {
                foreach (var item in p)
                {
                    DTO_HoaDon hd = new DTO_HoaDon();
                    hd.MaHD = item.mahd;
                    hd.NgayLapHD = Convert.ToDateTime(item.ngaylhd);
                    if (item.lhd == true)
                    {
                        hd.LoaiHD = "Hóa Đơn Kê";
                    }
                    else hd.LoaiHD = "Hóa Đơn Không Kê";
                    hd.GhiChu = item.ghichu;
                    hd.TenNV = item.tennv;
                    hd.SdtNV = item.sdtnv;
                    hd.TenKH = null;
                    hd.SdtKH = null;
                    hd.MaNV = item.manv;
                    if (item.makh != null)
                    {
                        hd.MaKH = item.makh;
                    }
                    else hd.MaKH = "Không Có";
                    lhd.Add(hd);
                }
                return lhd;
            }
            else return null;
        }
        public List<DTO_HoaDon> Lay50HoaDonT()
        {
            List<DTO_HoaDon> lhd = new List<DTO_HoaDon>();
            var p = (from hd in db.HoaDons
                     join nv in db.NhanViens on hd.maNV equals nv.maNV
                     select new
                     {
                         mahd = hd.maHD,
                         ngaylhd = hd.ngayLapHD,
                         lhd = hd.loaiHD,
                         ghichu = hd.ghiChu,
                         tennv = nv.tenNV,
                         sdtnv = nv.sdtNV,
                         manv = hd.maNV,
                         makh = hd.maKH
                     }).ToList();
            if (p != null)
            {
                int a = 0;

                foreach (var item in p)
                {
                    DTO_HoaDon hd = new DTO_HoaDon();
                    hd.MaHD = item.mahd;
                    hd.NgayLapHD = Convert.ToDateTime(item.ngaylhd);
                    if (item.lhd == true)
                    {
                        hd.LoaiHD = "Hóa Đơn Kê";
                    }
                    else hd.LoaiHD = "Hóa Đơn Không Kê";
                    hd.GhiChu = item.ghichu;
                    hd.TenNV = item.tennv;
                    hd.SdtNV = item.sdtnv;
                    hd.TenKH = null;
                    hd.SdtKH = null;
                    hd.MaNV = item.manv;
                    if (item.makh != null)
                    {
                        hd.MaKH = item.makh;
                    }
                    else hd.MaKH = "Không Có";
                    lhd.Add(hd);
                    a++;
                    if (a == 50)
                        return lhd;
                }
                return lhd;
            }
            else return null;
        }
        // Tìm Kiếm Hóa Đơn Theo SDT và maHD
        public List<DTO_HoaDon> TimKiemHoaDonTheoMaVaSDT(string sdtma)
        {
            List<DTO_HoaDon> lhd = new List<DTO_HoaDon>();
            var p = (from hd in db.HoaDons
                     join nv in db.NhanViens on hd.maNV equals nv.maNV
                     join kh in db.KhachHangs on hd.maKH equals kh.maKH
                     where hd.maHD.ToLower().StartsWith(sdtma.Trim().ToLower()) || hd.maHD.Contains(sdtma) || kh.sdtKH.ToLower().StartsWith(sdtma.Trim().ToLower()) || kh.sdtKH.Contains(sdtma) || nv.sdtNV.ToLower().StartsWith(sdtma.Trim().ToLower()) || nv.sdtNV.Contains(sdtma)
                     select new
                     {
                         mahd = hd.maHD,
                         ngaylhd = hd.ngayLapHD,
                         lhd = hd.loaiHD,
                         ghichu = hd.ghiChu,
                         tennv = nv.tenNV,
                         sdtnv = nv.sdtNV,
                         tenkh = kh.tenKH,
                         sdtkh = kh.sdtKH,
                         manv = hd.maNV,
                         makh = hd.maKH
                     }).ToList();
            if (p != null)
            {
                int a = 0;
                foreach (var item in p)
                {
                    DTO_HoaDon hd = new DTO_HoaDon();
                    hd.MaHD = item.mahd;
                    hd.NgayLapHD = Convert.ToDateTime(item.ngaylhd);
                    if (item.lhd == true)
                    {
                        hd.LoaiHD = "Hóa Đơn Kê";
                    }
                    else hd.LoaiHD = "Hóa Đơn Không Kê";
                    hd.GhiChu = item.ghichu;
                    hd.TenNV = item.tennv;
                    hd.SdtNV = item.sdtnv;
                    hd.TenKH = item.tenkh;
                    hd.SdtKH = item.sdtkh;
                    hd.MaNV = item.manv;
                    hd.MaKH = item.makh;
                    lhd.Add(hd);
                    a++;
                    if (a == 50)
                        return lhd;
                }
                return lhd;

            }
            else return null;
        }
        // Lấy thuốc theo mã hóa đơn
        public List<DTO_CTHoaDon> LayThuocTheoMaHD(string mahd)
        {
            List<DTO_CTHoaDon> dscthd = new List<DTO_CTHoaDon>();
            var p = (from hd in db.HoaDons
                     join cthd in db.CT_HoaDons on hd.maHD equals cthd.maHD
                     join t in db.Thuocs on cthd.maThuoc equals t.maThuoc
                     where cthd.maHD == mahd
                     select new
                     {
                         mat = cthd.maThuoc,
                         tent = t.tenThuoc,
                         hcc = t.hoatChatChinh,
                         sl = cthd.soLuong,
                         g = cthd.gia,
                         dvt = cthd.donViTinh,
                         v = cthd.vAT
                     }).ToList();
            if (p != null)
            {
                foreach (var item in p)
                {
                    DTO_CTHoaDon cthd = new DTO_CTHoaDon();
                    cthd.MaThuoc = item.mat;
                    cthd.TenThuoc = item.tent;
                    cthd.HoatChatChinh = item.hcc;
                    cthd.SoLuong = Convert.ToInt32(item.sl);
                    cthd.Gia = Convert.ToDouble(item.g);
                    cthd.DonViTinh = item.dvt;
                    cthd.VAT = Convert.ToDouble(item.v);
                    dscthd.Add(cthd);
                }
                return dscthd;
            }
            else return null;
        }
        public int SoHoaDon()
        {
            var p = db.HoaDons.ToList();

            return p.Count;
        }
    }
}
