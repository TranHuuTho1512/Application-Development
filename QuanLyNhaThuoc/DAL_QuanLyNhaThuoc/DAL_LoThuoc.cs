using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNhaThuoc;
namespace DAL_QuanLyNhaThuoc
{
    public class DAL_LoThuoc
    {
        QLQTDataContext db;
        public DAL_LoThuoc()
        {
            db = new QLQTDataContext();
        }
        //Lấy Hết Lô Thuốc
        public List<DTO_LoThuoc> LayHetLoThuoc()
        {
            List<DTO_LoThuoc> llt = new List<DTO_LoThuoc>();
            var p = (from n in db.LoThuocs
                     join t in db.Thuocs on n.maThuoc equals t.maThuoc
                     join ncc in db.NhaCungCaps on n.maNCC equals ncc.maNCC
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
                     }).OrderBy(x => x.maLoThuoc).ToList();
            if (p != null)
            {
                foreach (var item in p)
                {
                    DTO_LoThuoc lt = new DTO_LoThuoc();
                    lt.MaLoThuoc = item.maLoThuoc;
                    lt.MaThuoc = item.maThuoc;
                    lt.TenThuoc = item.tenThuoc;
                    lt.MaNCC = item.maNCC;
                    lt.TenNCC = item.tenNCC;
                    lt.XuatXu = item.xuatXu;
                    lt.NgaySanXuat = Convert.ToDateTime(item.ngaySanXuat);
                    lt.HanSuDung = Convert.ToDateTime(item.hanSuDung);
                    lt.DonViTinh = item.donViTinh;
                    lt.DonViQuyDoi = item.donViQuyDoi;
                    lt.TyLeQuyDoi = Convert.ToInt32(item.tyLeQuyDoi);
                    lt.GiaBanChan = Convert.ToDouble(item.giaBanChan);
                    lt.GiaBanLe = Convert.ToDouble(item.giaBanLe);
                    lt.LieuLuongDung = item.lieuLuongDung;
                    lt.MoTa = item.moTa;
                    lt.VAT = Convert.ToDouble(item.VAT);
                    lt.SoLuongTon = Convert.ToInt32(item.soLuongTon);
                    llt.Add(lt);

                }
                return llt;

            }
            else return null;
        }

        public List<DTO_LoThuoc> Lay30LoThuoc()
        {
            List<DTO_LoThuoc> llt = new List<DTO_LoThuoc>();
            var p = (from n in db.LoThuocs
                     join t in db.Thuocs on n.maThuoc equals t.maThuoc
                     join ncc in db.NhaCungCaps on n.maNCC equals ncc.maNCC
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
                     }).OrderBy(x => x.maLoThuoc).ToList();
            if (p != null)
            {
                int a = 0;
                foreach (var item in p)
                {
                    DTO_LoThuoc lt = new DTO_LoThuoc();
                    lt.MaLoThuoc = item.maLoThuoc;
                    lt.MaThuoc = item.maThuoc;
                    lt.TenThuoc = item.tenThuoc;
                    lt.MaNCC = item.maNCC;
                    lt.TenNCC = item.tenNCC;
                    lt.XuatXu = item.xuatXu;
                    lt.NgaySanXuat = Convert.ToDateTime(item.ngaySanXuat);
                    lt.HanSuDung = Convert.ToDateTime(item.hanSuDung);
                    lt.DonViTinh = item.donViTinh;
                    lt.DonViQuyDoi = item.donViQuyDoi;
                    lt.TyLeQuyDoi = Convert.ToInt32(item.tyLeQuyDoi);
                    lt.GiaBanChan = Convert.ToDouble(item.giaBanChan);
                    lt.GiaBanLe = Convert.ToDouble(item.giaBanLe);
                    lt.LieuLuongDung = item.lieuLuongDung;
                    lt.MoTa = item.moTa;
                    lt.VAT = Convert.ToDouble(item.VAT);
                    lt.SoLuongTon = Convert.ToInt32(item.soLuongTon);
                    llt.Add(lt);
                    a++;
                    if (a == 30)
                        return llt;
                }
                return llt;

            }
            else return null;
        }
        // Tìm Kiếm Theo Xuất Xứ
        public List<DTO_LoThuoc> TimKiemTheoXuatXu(string xx)
        {
            List<DTO_LoThuoc> llt = new List<DTO_LoThuoc>();
            var p = (from n in db.LoThuocs
                     join t in db.Thuocs on n.maThuoc equals t.maThuoc
                     join ncc in db.NhaCungCaps on n.maNCC equals ncc.maNCC
                     where n.xuatXu == xx
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
                     }).OrderBy(x => x.maLoThuoc).ToList();
            if (p != null)
            {
                foreach (var item in p)
                {
                    DTO_LoThuoc lt = new DTO_LoThuoc();
                    lt.MaLoThuoc = item.maLoThuoc;
                    lt.MaThuoc = item.maThuoc;
                    lt.TenThuoc = item.tenThuoc;
                    lt.MaNCC = item.maNCC;
                    lt.TenNCC = item.tenNCC;
                    lt.XuatXu = item.xuatXu;
                    lt.NgaySanXuat = Convert.ToDateTime(item.ngaySanXuat);
                    lt.HanSuDung = Convert.ToDateTime(item.hanSuDung);
                    lt.DonViTinh = item.donViTinh;
                    lt.DonViQuyDoi = item.donViQuyDoi;
                    lt.TyLeQuyDoi = Convert.ToInt32(item.tyLeQuyDoi);
                    lt.GiaBanChan = Convert.ToDouble(item.giaBanChan);
                    lt.GiaBanLe = Convert.ToDouble(item.giaBanLe);
                    lt.LieuLuongDung = item.lieuLuongDung;
                    lt.MoTa = item.moTa;
                    lt.VAT = Convert.ToDouble(item.VAT);
                    lt.SoLuongTon = Convert.ToInt32(item.soLuongTon);
                    llt.Add(lt);
                }
                return llt;

            }
            else return null;
        }
        //Tìm Kiếm Theo Mã Tên
        public List<DTO_LoThuoc> TimKiemTheoMaTen(string maten)
        {
            List<DTO_LoThuoc> llt = new List<DTO_LoThuoc>();
            var p = (from n in db.LoThuocs
                     join t in db.Thuocs on n.maThuoc equals t.maThuoc
                     join ncc in db.NhaCungCaps on n.maNCC equals ncc.maNCC
                     where (t.maThuoc.ToLower().StartsWith(maten.Trim().ToLower()) || t.maThuoc.Contains(maten) || t.tenThuoc.ToLower().StartsWith(maten.Trim().ToLower()) || t.tenThuoc.Contains(maten))
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
                     }).OrderBy(x => x.maLoThuoc).ToList();
            if (p != null)
            {
                int a = 0;
                foreach (var item in p)
                {
                    DTO_LoThuoc lt = new DTO_LoThuoc();
                    lt.MaLoThuoc = item.maLoThuoc;
                    lt.MaThuoc = item.maThuoc;
                    lt.TenThuoc = item.tenThuoc;
                    lt.MaNCC = item.maNCC;
                    lt.TenNCC = item.tenNCC;
                    lt.XuatXu = item.xuatXu;
                    lt.NgaySanXuat = Convert.ToDateTime(item.ngaySanXuat);
                    lt.HanSuDung = Convert.ToDateTime(item.hanSuDung);
                    lt.DonViTinh = item.donViTinh;
                    lt.DonViQuyDoi = item.donViQuyDoi;
                    lt.TyLeQuyDoi = Convert.ToInt32(item.tyLeQuyDoi);
                    lt.GiaBanChan = Convert.ToDouble(item.giaBanChan);
                    lt.GiaBanLe = Convert.ToDouble(item.giaBanLe);
                    lt.LieuLuongDung = item.lieuLuongDung;
                    lt.MoTa = item.moTa;
                    lt.VAT = Convert.ToDouble(item.VAT);
                    lt.SoLuongTon = Convert.ToInt32(item.soLuongTon);
                    llt.Add(lt);
                    a++;
                    if (a == 30)
                        return llt;
                }
                return llt;

            }
            else return null;
        }
        // Lấy lô theo mã thuốc
        public List<DTO_LoThuoc> LayLoThuocTheoMaThuoc(string mat)
        {
            List<DTO_LoThuoc> llt = new List<DTO_LoThuoc>();
            var p = (from n in db.LoThuocs
                     join t in db.Thuocs on n.maThuoc equals t.maThuoc
                     join ncc in db.NhaCungCaps on n.maNCC equals ncc.maNCC
                     where t.maThuoc == mat
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
                     }).OrderBy(x => x.maLoThuoc).ToList();
            if (p != null)
            {
                foreach (var item in p)
                {
                    DTO_LoThuoc lt = new DTO_LoThuoc();
                    lt.MaLoThuoc = item.maLoThuoc;
                    lt.MaThuoc = item.maThuoc;
                    lt.TenThuoc = item.tenThuoc;
                    lt.MaNCC = item.maNCC;
                    lt.TenNCC = item.tenNCC;
                    lt.XuatXu = item.xuatXu;
                    lt.NgaySanXuat = Convert.ToDateTime(item.ngaySanXuat);
                    lt.HanSuDung = Convert.ToDateTime(item.hanSuDung);
                    lt.DonViTinh = item.donViTinh;
                    lt.DonViQuyDoi = item.donViQuyDoi;
                    lt.TyLeQuyDoi = Convert.ToInt32(item.tyLeQuyDoi);
                    lt.GiaBanChan = Convert.ToDouble(item.giaBanChan);
                    lt.GiaBanLe = Convert.ToDouble(item.giaBanLe);
                    lt.LieuLuongDung = item.lieuLuongDung;
                    lt.MoTa = item.moTa;
                    lt.VAT = Convert.ToDouble(item.VAT);
                    lt.SoLuongTon = Convert.ToInt32(item.soLuongTon);
                    llt.Add(lt);
                }
                return llt;

            }
            else return null;
        }
        // Thêm Lô Thuốc
        public Boolean ThemLoThuoc(DTO_LoThuoc lt)
        {
            var p = db.LoThuocs.Where(x => x.maLoThuoc == lt.MaLoThuoc).FirstOrDefault();
            if (p == null)
            {
                LoThuoc dblt = new LoThuoc();
                dblt.maLoThuoc = lt.MaLoThuoc;
                dblt.maThuoc = lt.MaThuoc;
                dblt.maNCC = lt.MaNCC;
                dblt.xuatXu = lt.XuatXu;
                dblt.ngaySanXuat = lt.NgaySanXuat;
                dblt.hanSuDung = lt.HanSuDung;
                dblt.donViTinh = lt.DonViTinh;
                dblt.donViQuyDoi = lt.DonViQuyDoi;
                dblt.tyLeQuyDoi = lt.TyLeQuyDoi;
                dblt.giaBanChan = lt.GiaBanChan;
                dblt.giaBanLe = lt.GiaBanLe;
                dblt.lieuLuongDung = lt.LieuLuongDung;
                dblt.moTa = lt.MoTa;
                dblt.VAT = lt.VAT;
                dblt.soLuongTon = lt.SoLuongTon;
                db.LoThuocs.InsertOnSubmit(dblt);
                db.SubmitChanges();
                return true;
            }
            else return false;
        }
        // Sửa Lô Thuốc
        public Boolean SuaLoThuoc(DTO_LoThuoc lt)
        {
            var p = db.LoThuocs.Where(x => x.maLoThuoc == lt.MaLoThuoc).FirstOrDefault();
            if (p != null)
            {
                p.maThuoc = lt.MaThuoc;
                p.maNCC = lt.MaNCC;
                p.xuatXu = lt.XuatXu;
                p.ngaySanXuat = lt.NgaySanXuat;
                p.hanSuDung = lt.HanSuDung;
                p.donViTinh = lt.DonViTinh;
                p.donViQuyDoi = lt.DonViQuyDoi;
                p.tyLeQuyDoi = lt.TyLeQuyDoi;
                p.giaBanChan = lt.GiaBanChan;
                p.giaBanLe = lt.GiaBanLe;
                p.lieuLuongDung = lt.LieuLuongDung;
                p.moTa = lt.MoTa;
                p.VAT = lt.VAT;
                p.soLuongTon = lt.SoLuongTon;
                db.SubmitChanges();
                return true;
            }
            else return false;
        }
        // Lấy Số Lô Thuốc
        public int SoLoThuoc()
        {
            var p = db.LoThuocs.ToList();

            return p.Count;
        }
    }
}
