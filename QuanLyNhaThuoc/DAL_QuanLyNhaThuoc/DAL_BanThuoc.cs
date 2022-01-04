using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNhaThuoc;
namespace DAL_QuanLyNhaThuoc
{
    public class DAL_BanThuoc
    {
        QLQTDataContext db;
        public DAL_BanThuoc()
        {
            db = new QLQTDataContext();
        }
        // Lấy Thông tin thuốc      
        public List<DTO_BanThuoc> LayThongTinThuoc()
        {
            List<DTO_BanThuoc> dsbt = new List<DTO_BanThuoc>();
            var p = (from t in db.Thuocs
                     join lt in db.LoThuocs on t.maThuoc equals lt.maThuoc
                     join nt in db.NhomThuocs on t.maNhomThuoc equals nt.maNhomThuoc
                     select new
                     {
                         maTh = t.maThuoc,
                         tenTh = t.tenThuoc,
                         hCC = t.hoatChatChinh,
                         lT = t.loaiThuoc,
                         maNT = nt.maNhomThuoc,
                         tenNT = nt.tenNhomThuoc,
                         dVT = lt.donViTinh,
                         gBC = lt.giaBanChan,
                         dVQD = lt.donViQuyDoi,
                         gBL = lt.giaBanLe,
                         tlqd = lt.tyLeQuyDoi,
                         nSX = lt.ngaySanXuat,
                         hSD = lt.hanSuDung,                     
                         soLT = lt.soLuongTon,
                         moT = lt.moTa,
                         maLo = lt.maLoThuoc,
                         vat = lt.VAT,
                         xx = lt.xuatXu
                     }).ToList();
            if (p != null)
            {
                foreach (var item in p)
                {
                    DTO_BanThuoc bt = new DTO_BanThuoc();
                    bt.MaThuoc = item.maTh;
                    bt.TenThuoc = item.tenTh;
                    bt.HoatChatChinh = item.hCC;
                    if (item.lT == true)
                    {
                        bt.LoaiThuoc = "Thuốc Kê Đơn";
                    }
                    else bt.LoaiThuoc = "Thuốc Không Kê Đơn";
                    bt.MaNhomThuoc = item.maNT;
                    bt.TenNhomThuoc = item.tenNT;
                    bt.DonViTinh = item.dVT;
                    bt.GiaBanChan = Convert.ToDouble(item.gBC);
                    bt.DonViQuyDoi = item.dVQD;
                    bt.GiaBanLe = Convert.ToDouble(item.gBL);
                    bt.TyLeQuyDoi = Convert.ToInt32(item.tlqd);
                    bt.NgaySanXuat = Convert.ToDateTime(item.nSX);
                    bt.HanSuDung = Convert.ToDateTime(item.hSD);
                    bt.SoLuongTon = Convert.ToInt32(item.soLT);
                    bt.MoTa = item.moT;
                    bt.MaLoThuoc = item.maLo;
                    bt.VAT = Convert.ToDouble(item.vat);
                    bt.XuatXu = item.xx;
                    dsbt.Add(bt);
                }
                return dsbt;
            }
            else return null;
        }
        // lấy Thông Tin Theo Nhóm
        public List<DTO_BanThuoc> LayThongTinThuocTheoNhom(string mant)
        {
            List<DTO_BanThuoc> dsbt = new List<DTO_BanThuoc>();
            var p = (from t in db.Thuocs
                     join lt in db.LoThuocs on t.maThuoc equals lt.maThuoc
                     join nt in db.NhomThuocs on t.maNhomThuoc equals nt.maNhomThuoc
                     where t.maNhomThuoc == mant && lt.hanSuDung.Value > DateTime.Now
                     select new
                     {
                         maTh = t.maThuoc,
                         tenTh = t.tenThuoc,
                         hCC = t.hoatChatChinh,
                         lT = t.loaiThuoc,
                         maNT = nt.maNhomThuoc,
                         tenNT = nt.tenNhomThuoc,
                         dVT = lt.donViTinh,
                         gBC = lt.giaBanChan,
                         dVQD = lt.donViQuyDoi,
                         gBL = lt.giaBanLe,
                         tlqd = lt.tyLeQuyDoi,
                         nSX = lt.ngaySanXuat,
                         hSD = lt.hanSuDung,
                         soLT = lt.soLuongTon,
                         moT = lt.moTa,
                         maLo = lt.maLoThuoc,
                         vat = lt.VAT,
                         xx = lt.xuatXu
                     }).ToList();
            if (p != null)
            {
                foreach (var item in p)
                {
                    DTO_BanThuoc bt = new DTO_BanThuoc();
                    bt.MaThuoc = item.maTh;
                    bt.TenThuoc = item.tenTh;
                    bt.HoatChatChinh = item.hCC;
                    if (item.lT == true)
                    {
                        bt.LoaiThuoc = "Thuốc Kê Đơn";
                    }
                    else bt.LoaiThuoc = "Thuốc Không Kê Đơn";
                    bt.MaNhomThuoc = item.maNT;
                    bt.TenNhomThuoc = item.tenNT;
                    bt.DonViTinh = item.dVT;
                    bt.GiaBanChan = Convert.ToDouble(item.gBC);
                    bt.DonViQuyDoi = item.dVQD;
                    bt.GiaBanLe = Convert.ToDouble(item.gBL);
                    bt.TyLeQuyDoi = Convert.ToInt32(item.tlqd);
                    bt.NgaySanXuat = Convert.ToDateTime(item.nSX);
                    bt.HanSuDung = Convert.ToDateTime(item.hSD);
                    bt.SoLuongTon = Convert.ToInt32(item.soLT);
                    bt.MoTa = item.moT;
                    bt.MaLoThuoc = item.maLo;
                    bt.VAT = Convert.ToDouble(item.vat);
                    bt.XuatXu = item.xx;
                    dsbt.Add(bt);
                }
                return dsbt;
            }
            else return null;
        }
        // Tìm Kiếm Theo Xuất Xứ
        public List<DTO_BanThuoc> TimKiemTheoXuaTXu(string mant, string xx)
        {
            List<DTO_BanThuoc> dsbt = new List<DTO_BanThuoc>();
            var p = (from t in db.Thuocs
                     join lt in db.LoThuocs on t.maThuoc equals lt.maThuoc
                     join nt in db.NhomThuocs on t.maNhomThuoc equals nt.maNhomThuoc
                     where nt.maNhomThuoc == mant && lt.xuatXu == xx
                     select new
                     {
                         maTh = t.maThuoc,
                         tenTh = t.tenThuoc,
                         hCC = t.hoatChatChinh,
                         lT = t.loaiThuoc,
                         maNT = nt.maNhomThuoc,
                         tenNT = nt.tenNhomThuoc,
                         dVT = lt.donViTinh,
                         gBC = lt.giaBanChan,
                         dVQD = lt.donViQuyDoi,
                         gBL = lt.giaBanLe,
                         tlqd = lt.tyLeQuyDoi,
                         nSX = lt.ngaySanXuat,
                         hSD = lt.hanSuDung,
                         soLT = lt.soLuongTon,
                         moT = lt.moTa,
                         maLo = lt.maLoThuoc,
                         vat = lt.VAT,
                         xx = lt.xuatXu
                     }).ToList();
            if (p != null)
            {
                foreach (var item in p)
                {
                    DTO_BanThuoc bt = new DTO_BanThuoc();
                    bt.MaThuoc = item.maTh;
                    bt.TenThuoc = item.tenTh;
                    bt.HoatChatChinh = item.hCC;
                    if (item.lT == true)
                    {
                        bt.LoaiThuoc = "Thuốc Kê Đơn";
                    }
                    else bt.LoaiThuoc = "Thuốc Không Kê Đơn";
                    bt.MaNhomThuoc = item.maNT;
                    bt.TenNhomThuoc = item.tenNT;
                    bt.DonViTinh = item.dVT;
                    bt.GiaBanChan = Convert.ToDouble(item.gBC);
                    bt.DonViQuyDoi = item.dVQD;
                    bt.GiaBanLe = Convert.ToDouble(item.gBL);
                    bt.TyLeQuyDoi = Convert.ToInt32(item.tlqd);
                    bt.NgaySanXuat = Convert.ToDateTime(item.nSX);
                    bt.HanSuDung = Convert.ToDateTime(item.hSD);
                    bt.SoLuongTon = Convert.ToInt32(item.soLT);
                    bt.MoTa = item.moT;
                    bt.MaLoThuoc = item.maLo;
                    bt.VAT = Convert.ToDouble(item.vat);
                    bt.XuatXu = item.xx;
                    dsbt.Add(bt);
                }
                return dsbt;
            }
            else return null;
        }
        // Tìm Kiếm Theo Mã Tên
        public List<DTO_BanThuoc> TimKiemThuocTheoMaTen(string maten, string mant)
        {
            List<DTO_BanThuoc> dsbt = new List<DTO_BanThuoc>();
            var p = (from t in db.Thuocs
                     join lt in db.LoThuocs on t.maThuoc equals lt.maThuoc
                     join nt in db.NhomThuocs on t.maNhomThuoc equals nt.maNhomThuoc
                     where (t.maThuoc.ToLower().StartsWith(maten.Trim().ToLower()) || t.maThuoc.Contains(maten) || t.tenThuoc.ToLower().StartsWith(maten.Trim().ToLower()) || t.tenThuoc.Contains(maten)) && t.maNhomThuoc == mant
                     select new
                     {
                         maTh = t.maThuoc,
                         tenTh = t.tenThuoc,
                         hCC = t.hoatChatChinh,
                         lT = t.loaiThuoc,
                         maNT = nt.maNhomThuoc,
                         tenNT = nt.tenNhomThuoc,
                         dVT = lt.donViTinh,
                         gBC = lt.giaBanChan,
                         dVQD = lt.donViQuyDoi,
                         gBL = lt.giaBanLe,
                         tlqd = lt.tyLeQuyDoi,
                         nSX = lt.ngaySanXuat,
                         hSD = lt.hanSuDung,
                         soLT = lt.soLuongTon,
                         moT = lt.moTa,
                         maLo = lt.maLoThuoc,
                         vat = lt.VAT,
                         xx = lt.xuatXu
                     }).ToList();
            if (p != null)
            {
                foreach (var item in p)
                {
                    DTO_BanThuoc bt = new DTO_BanThuoc();
                    bt.MaThuoc = item.maTh;
                    bt.TenThuoc = item.tenTh;
                    bt.HoatChatChinh = item.hCC;
                    if (item.lT == true)
                    {
                        bt.LoaiThuoc = "Thuốc Kê Đơn";
                    }
                    else bt.LoaiThuoc = "Thuốc Không Kê Đơn";
                    bt.MaNhomThuoc = item.maNT;
                    bt.TenNhomThuoc = item.tenNT;
                    bt.DonViTinh = item.dVT;
                    bt.GiaBanChan = Convert.ToDouble(item.gBC);
                    bt.DonViQuyDoi = item.dVQD;
                    bt.GiaBanLe = Convert.ToDouble(item.gBL);
                    bt.TyLeQuyDoi = Convert.ToInt32(item.tlqd);
                    bt.NgaySanXuat = Convert.ToDateTime(item.nSX);
                    bt.HanSuDung = Convert.ToDateTime(item.hSD);
                    bt.SoLuongTon = Convert.ToInt32(item.soLT);
                    bt.MoTa = item.moT;
                    bt.MaLoThuoc = item.maLo;
                    bt.VAT = Convert.ToDouble(item.vat);
                    bt.XuatXu = item.xx;
                    dsbt.Add(bt);
                }
                return dsbt;
            }
            else return null;
        }
        // Sửa Số Lượng Tồn
        public void SuaSoLuongTon(string maLo, int soL)
        {
            var p = db.LoThuocs.Where(x => x.maLoThuoc == maLo).FirstOrDefault();
            if (p != null)
            {
                p.soLuongTon = soL;
                db.SubmitChanges();

            }

        }
        // Thêm Hóa Đơn
        public Boolean ThemHoaDon(HoaDon thd)
        {
            var p = db.HoaDons.Where(x => x.maHD == thd.maHD).FirstOrDefault();
            if (p == null)
            {
                HoaDon hd = new HoaDon();
                hd.maHD = thd.maHD;
                hd.ngayLapHD = thd.ngayLapHD;
                hd.loaiHD = thd.loaiHD;
                hd.ghiChu = thd.ghiChu;
                hd.maNV = thd.maNV;
                hd.maKH = thd.maKH;
                db.HoaDons.InsertOnSubmit(hd);
                db.SubmitChanges();
                return true;
            }
            else return false;
        }
        // Thêm Chi Tiết Hóa Đơn
        public Boolean ThemCTHoaDon(CT_HoaDon tcthd)
        {
            var p = db.CT_HoaDons.Where(x => x.maThuoc == tcthd.maThuoc && x.maHD == tcthd.maHD).FirstOrDefault();
            if (p == null)
            {
                CT_HoaDon cthd = new CT_HoaDon();
                cthd.maHD = tcthd.maHD;
                cthd.maThuoc = tcthd.maThuoc;
                cthd.soLuong = tcthd.soLuong;
                cthd.gia = tcthd.gia;
                cthd.donViTinh = tcthd.donViTinh;
                cthd.vAT = tcthd.vAT;
                db.CT_HoaDons.InsertOnSubmit(cthd);
                db.SubmitChanges();
                return true;
            }
            else return false;
        }
        // lấy hóa đơn
        public int SoHoaDon()
        {
            int count = 0;
            var p = db.HoaDons.ToList();
            
            foreach (var item in p)
            {
                if (item != null)
                {
                    count = count + 1;
                }
            }
            return p.Count;
        }
    }
}
