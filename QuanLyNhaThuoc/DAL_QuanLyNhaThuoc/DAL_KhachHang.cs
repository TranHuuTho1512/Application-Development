using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNhaThuoc;
namespace DAL_QuanLyNhaThuoc
{
    public class DAL_KhachHang
    {
        QLQTDataContext db;
        public DAL_KhachHang()
        {
            db = new QLQTDataContext();
        }
        // Lay Nhan Vien Len
        public List<DTO_KhachHang> LayHetKhachHang()
        {
            List<DTO_KhachHang> lkh = new List<DTO_KhachHang>();
            var p = db.KhachHangs.ToList();
            if (p.Count > 0)
            {
                foreach (var item in p)
                {
                    DTO_KhachHang kh = new DTO_KhachHang();
                    kh.MaKH = item.maKH;
                    kh.TenKH = item.tenKH;
                    kh.SdtKH = item.sdtKH;
                    kh.DiaChi = item.diaChi;
                    kh.Email = item.email;
                    lkh.Add(kh);
                }
                return lkh;
            }
            else return null;

        }
        public List<DTO_KhachHang> Lay50KhachHang()
        {
            List<DTO_KhachHang> lkh = new List<DTO_KhachHang>();
            var p = db.KhachHangs.ToList();
            if (p.Count > 0)
            {
                int a = 0;
                foreach (var item in p)
                {
                    DTO_KhachHang kh = new DTO_KhachHang();
                    kh.MaKH = item.maKH;
                    kh.TenKH = item.tenKH;
                    kh.SdtKH = item.sdtKH;
                    kh.DiaChi = item.diaChi;
                    kh.Email = item.email;
                    lkh.Add(kh);
                    a++;
                    if (a == 50)
                    {
                        return lkh;
                    }
                }
                return lkh;
            }
            else return null;

        }

        // Lấy khách hàng theo mã  tên
        public List<DTO_KhachHang> TimKiemKhachHangTheoMaTen(string maTen)
        {
            List<DTO_KhachHang> lkh = new List<DTO_KhachHang>();
            var p = db.KhachHangs.Where(x => x.tenKH.ToLower().StartsWith(maTen.Trim().ToLower()) || x.tenKH.Contains(maTen) || x.maKH.ToLower().StartsWith(maTen.Trim().ToLower()) || x.maKH.Contains(maTen) || x.sdtKH.ToLower().StartsWith(maTen.Trim().ToLower()) || x.sdtKH.Contains(maTen)).ToList();
            if (p.Count > 0)
            {
                int a = 0;
                foreach (var item in p)
                {
                    DTO_KhachHang kh = new DTO_KhachHang();
                    kh.MaKH = item.maKH;
                    kh.TenKH = item.tenKH;
                    kh.SdtKH = item.sdtKH;
                    kh.DiaChi = item.diaChi;
                    kh.Email = item.email;
                    lkh.Add(kh);
                    a++;
                    if (a == 50)
                    {
                        return lkh;
                    }
                }
                return lkh;
            }
            else return null;

        }

        // Thêm Khách Hàng Mới
        public Boolean ThemKhachHang(DTO_KhachHang kh)
        {
            try
            {
                var p = db.KhachHangs.Where(x => x.maKH == kh.MaKH).FirstOrDefault();
                if (p == null)
                {
                    KhachHang khm = new KhachHang();
                    khm.maKH = kh.MaKH;
                    khm.tenKH = kh.TenKH;
                    khm.sdtKH = kh.SdtKH;
                    khm.diaChi = kh.DiaChi;
                    khm.email = kh.Email;
                    db.KhachHangs.InsertOnSubmit(khm);
                    db.SubmitChanges();
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        // Sửa khách hàng
        public Boolean SuaKhachHang(DTO_KhachHang kh)
        {
            var p = db.KhachHangs.Where(x => x.maKH == kh.MaKH).FirstOrDefault();
            if (p != null)
            {
                p.tenKH = kh.TenKH;
                p.sdtKH = kh.SdtKH;
                p.diaChi = kh.DiaChi;
                p.email = kh.Email;
                db.SubmitChanges();
                return true;
            }
            else return false;
        }
        public int SoKH()
        {
            var p = db.KhachHangs.ToList();

            return p.Count;
        }
    }
}
