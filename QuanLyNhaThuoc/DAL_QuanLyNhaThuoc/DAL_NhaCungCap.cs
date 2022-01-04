using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNhaThuoc;
namespace DAL_QuanLyNhaThuoc
{
   public class DAL_NhaCungCap
    {
        QLQTDataContext db;
        public DAL_NhaCungCap()
        {
            db = new QLQTDataContext();
        }
        // Lấy hết nhà cung cấp
        public List<DTO_NhaCungCap> LayHetNhaCungCap()
        {
            List<DTO_NhaCungCap> lncc = new List<DTO_NhaCungCap>();
            var p = db.NhaCungCaps.ToList();
            if (p.Count > 0)
            {
                foreach (var item in p)
                {
                    DTO_NhaCungCap ncc = new DTO_NhaCungCap();
                    ncc.MaNCC = item.maNCC;
                    ncc.TenNCC = item.tenNCC;
                    ncc.DiaChi = item.diaChi;
                    ncc.Sdt = item.sdt;
                    ncc.Email = item.email;
                    if (item.trangThai == true)
                    {
                        ncc.TrangThai = "Đang Hoạt Động";
                    }
                    else
                    {
                        ncc.TrangThai = "Ngưng Hoạt Động";
                    }
                    lncc.Add(ncc);
                }
                return lncc;
            }
            else return null;
        }
        public List<DTO_NhaCungCap> Lay50NhaCungCap()
        {
            List<DTO_NhaCungCap> lncc = new List<DTO_NhaCungCap>();
            var p = db.NhaCungCaps.ToList();
            if (p.Count > 0)
            {
                int a = 0;
                foreach (var item in p)
                {
                    DTO_NhaCungCap ncc = new DTO_NhaCungCap();
                    ncc.MaNCC = item.maNCC;
                    ncc.TenNCC = item.tenNCC;
                    ncc.DiaChi = item.diaChi;
                    ncc.Sdt = item.sdt;
                    ncc.Email = item.email;
                    if (item.trangThai == true)
                    {
                        ncc.TrangThai = "Đang Hoạt Động";
                    }
                    else
                    {
                        ncc.TrangThai = "Ngưng Hoạt Động";
                    }
                    lncc.Add(ncc);
                    a++;
                    if (a == 50)
                        return lncc;
                }
                return lncc;
            }
            else return null;
        }
        // Tìm Kiếm Nhà Cung Cấp Theo Tên
        public List<DTO_NhaCungCap> TimKiemTheoMaTen(string maten)
        {
            List<DTO_NhaCungCap> lncc = new List<DTO_NhaCungCap>();
            var p = db.NhaCungCaps.Where(x => x.tenNCC.ToLower().StartsWith(maten.Trim().ToLower()) || x.tenNCC.Contains(maten) || x.maNCC.ToLower().StartsWith(maten.Trim().ToLower()) || x.maNCC.Contains(maten)).ToList();
            if (p.Count > 0)
            {
                int a = 0;
                foreach (var item in p)
                {
                    DTO_NhaCungCap ncc = new DTO_NhaCungCap();
                    ncc.MaNCC = item.maNCC;
                    ncc.TenNCC = item.tenNCC;
                    ncc.DiaChi = item.diaChi;
                    ncc.Sdt = item.sdt;
                    ncc.Email = item.email;
                    if (item.trangThai == true)
                    {
                        ncc.TrangThai = "Đang Hoạt Động";
                    }
                    else
                    {
                        ncc.TrangThai = "Ngưng Hoạt Động";
                    }
                    lncc.Add(ncc);
                    a++;
                    if (a == 50)
                        return lncc;
                }
                return lncc;
            }
            else return null;
        }

        // Thêm nhà cung cấp

        public Boolean ThemNhaCungCap(DTO_NhaCungCap ncc)
        {
            var p = db.NhaCungCaps.Where(x => x.maNCC == ncc.MaNCC).FirstOrDefault();
            if (p == null)
            {
                NhaCungCap kncc = new NhaCungCap();
                kncc.maNCC = ncc.MaNCC;
                kncc.tenNCC = ncc.TenNCC;
                kncc.diaChi = ncc.DiaChi;
                kncc.sdt = ncc.Sdt;
                kncc.email = ncc.Email;
                if (ncc.TrangThai == "Đang Hoạt Đông")
                {
                    kncc.trangThai = true;
                }
                else kncc.trangThai = false;
                db.NhaCungCaps.InsertOnSubmit(kncc);
                db.SubmitChanges();
                return true;
            }
            else return false;
        }
        // Sửa nhà cung cấp
        public Boolean SuaNhaCungCap(DTO_NhaCungCap ncc)
        {
            var p = db.NhaCungCaps.Where(x => x.maNCC == ncc.MaNCC).FirstOrDefault();
            if (p != null)
            {
                p.tenNCC = ncc.TenNCC;
                p.diaChi = ncc.DiaChi;
                p.sdt = ncc.Sdt;
                p.email = ncc.Email;
                if (ncc.TrangThai == "Đang Hoạt Động")
                {
                    p.trangThai = true;
                }
                else p.trangThai = false;
                db.SubmitChanges();
                return true;
            }
            else return false;
        }
        public int SoNCC()
        {
            var p = db.NhaCungCaps.ToList();

            return p.Count;
        }
    }
}
