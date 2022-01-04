using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNhaThuoc;
namespace DAL_QuanLyNhaThuoc
{
    public class DAL_NhanVien
    {
        QLQTDataContext db;
        public DAL_NhanVien()
        {
            db = new QLQTDataContext();
        }
        // lấy nhân viên
        public List<DTO_NhanVien> LayHetNhanVien()
        {
            List<DTO_NhanVien> lnv = new List<DTO_NhanVien>();
            var p = db.NhanViens.ToList();
            if (p.Count > 0)
            {
                foreach (var item in p)
                {
                    DTO_NhanVien nv = new DTO_NhanVien();
                    nv.MaNV = item.maNV;
                    nv.TenNV = item.tenNV;
                    nv.SdtNV = item.sdtNV;
                    nv.Email = item.email;
                    nv.DiaChi = item.diaChi;
                    nv.CMND = item.cMND;
                    nv.MatKhau = item.matKhau;
                    if (item.trangThai == true)
                    {
                        nv.TrangThai = "Đang Hoạt Động";
                    }
                    else
                    {
                        nv.TrangThai = "Ngưng Hoạt Động";

                    }
                    lnv.Add(nv);
                }
                return lnv;
            }
            return null;
        }

        public List<DTO_NhanVien> Lay50NhanVien()
        {
            List<DTO_NhanVien> lnv = new List<DTO_NhanVien>();
            var p = db.NhanViens.ToList();
            if (p.Count > 0)
            {
                int a = 0;
                foreach (var item in p)
                {
                    DTO_NhanVien nv = new DTO_NhanVien();
                    nv.MaNV = item.maNV;
                    nv.TenNV = item.tenNV;
                    nv.SdtNV = item.sdtNV;
                    nv.Email = item.email;
                    nv.DiaChi = item.diaChi;
                    nv.CMND = item.cMND;
                    nv.MatKhau = item.matKhau;
                    if (item.trangThai == true)
                    {
                        nv.TrangThai = "Đang Hoạt Động";
                    }
                    else
                    {
                        nv.TrangThai = "Ngưng Hoạt Động";

                    }
                    lnv.Add(nv);
                    a++;
                    if (a == 50)
                        return lnv;
                }
                return lnv;
            }
            return null;
        }


        // Lấy nhân viên theo tên
        public List<DTO_NhanVien> TimKiemTheoMaTen(string maten)
        {
            List<DTO_NhanVien> lnv = new List<DTO_NhanVien>();
            var p = db.NhanViens.Where(x => x.tenNV.ToLower().StartsWith(maten.Trim().ToLower()) || x.tenNV.Contains(maten) || x.maNV.ToLower().StartsWith(maten.Trim().ToLower()) || x.maNV.Contains(maten)).ToList();
            if (p.Count > 0)
            {
                int a = 0;
                foreach (var item in p)
                {
                    DTO_NhanVien nv = new DTO_NhanVien();
                    nv.MaNV = item.maNV;

                    nv.TenNV = item.tenNV;
                    nv.SdtNV = item.sdtNV;
                    nv.Email = item.email;
                    nv.DiaChi = item.diaChi;
                    nv.CMND = item.cMND;
                    nv.MatKhau = item.matKhau;
                    if (item.trangThai == true)
                    {
                        nv.TrangThai = "Đang Hoạt Động";
                    }
                    else
                    {
                        nv.TrangThai = "Ngưng Hoạt Động";

                    }
                    lnv.Add(nv);
                    a++;
                    if (a == 50)
                        return lnv;
                }
                return lnv;
            }
            return null;
        }

        // Them nhan vien
        public Boolean ThemNhanVien(DTO_NhanVien nv)
        {
            try
            {
                var p = db.NhanViens.Where(x => x.maNV == nv.MaNV).FirstOrDefault();
                if (p == null)
                {
                    NhanVien dbnv = new NhanVien();
                    dbnv.maNV = nv.MaNV;
                    dbnv.tenNV = nv.TenNV;
                    dbnv.sdtNV = nv.SdtNV;
                    dbnv.email = nv.Email;
                    dbnv.diaChi = nv.DiaChi;
                    dbnv.cMND = nv.CMND;
                    dbnv.matKhau = nv.MatKhau;
                    if (nv.TrangThai == "Đang Hoạt Động")
                    {
                        dbnv.trangThai = true;
                    }
                    else dbnv.trangThai = false;
                    db.NhanViens.InsertOnSubmit(dbnv);
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
        // Sua Nhan Vien
        public Boolean SuaNhanVien(DTO_NhanVien nv)
        {
            var p = db.NhanViens.Where(x => x.maNV == nv.MaNV).FirstOrDefault();
            if (p != null)
            {
                p.tenNV = nv.TenNV;
                p.sdtNV = nv.SdtNV;
                p.email = nv.Email;
                p.diaChi = nv.DiaChi;
                p.cMND = nv.CMND;
                p.matKhau = nv.MatKhau;
                if (nv.TrangThai == "Đang Hoạt Động")
                {
                    p.trangThai = true;
                }
                else p.trangThai = false;
                db.SubmitChanges();
                return true;
            }
            else return false;
        }
        public int SoNhanVien()
        {
            var p = db.NhanViens.ToList();

            return p.Count;
        }
    }
}
