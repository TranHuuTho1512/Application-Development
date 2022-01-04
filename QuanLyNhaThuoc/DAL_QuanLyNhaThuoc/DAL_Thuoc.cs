using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNhaThuoc;

namespace DAL_QuanLyNhaThuoc
{
    public class DAL_Thuoc
    {
        QLQTDataContext db;
        public DAL_Thuoc()
        {
            db = new QLQTDataContext();
        }       
        public List<DTO_Thuoc> LayHetThuocT()
        {
            List<DTO_Thuoc> lst = new List<DTO_Thuoc>();
            var p = (from t in db.Thuocs
                     join nt in db.NhomThuocs on t.maNhomThuoc equals nt.maNhomThuoc
                     select new
                     {
                         maT = t.maThuoc,
                         tenT = t.tenThuoc,
                         maNT = nt.maNhomThuoc,
                         tenNT = nt.tenNhomThuoc,
                         loaiT = t.loaiThuoc,
                         hcc = t.hoatChatChinh,
                         tt = t.trangThai
                     }).ToList();
            if (p.Count >0)
            {              
                foreach (var item in p)
                {
                    DTO_Thuoc t = new DTO_Thuoc();
                    t.MaThuoc = item.maT;
                    t.TenThuoc = item.tenT;
                    t.MaNhomThuoc = item.maNT;
                    t.TenNhomThuoc = item.tenNT;
                    if (item.loaiT == true)
                    {
                        t.LoaiThuoc = "Thuốc Kê Đơn";
                    }
                    else t.LoaiThuoc = "Không Kê Đơn";
                    t.HoatChatChinh = item.hcc;
                    if (item.tt == true)
                    {
                        t.TrangThai = "Đang Hoạt Động";
                    }
                    else t.TrangThai = "Ngưng Hoạt Động";
                    lst.Add(t);
                }
                return lst;
            }
            else return null;
        }
        // Tìm Kiếm mã tên thuốc kết 2 bảng
        public List<DTO_Thuoc> TimKiemTheoMaTenT(string maten, string mant)
        {
            List<DTO_Thuoc> lst = new List<DTO_Thuoc>();
            var p = (from t in db.Thuocs
                     join nt in db.NhomThuocs on t.maNhomThuoc equals nt.maNhomThuoc
                     where (t.maThuoc.ToLower().StartsWith(maten.Trim().ToLower()) || t.maThuoc.Contains(maten) || t.tenThuoc.ToLower().StartsWith(maten.Trim().ToLower()) || t.tenThuoc.Contains(maten)) && t.maNhomThuoc == mant
                     select new
                     {
                         maT = t.maThuoc,
                         tenT = t.tenThuoc,
                         maNT = nt.maNhomThuoc,
                         tenNT = nt.tenNhomThuoc,
                         loaiT = t.loaiThuoc,
                         hcc = t.hoatChatChinh,
                         tt = t.trangThai
                     }).ToList();
            if (p.Count >0)
            {
                int a = 0;
                foreach (var item in p)
                {
                    DTO_Thuoc t = new DTO_Thuoc();
                    t.MaThuoc = item.maT;
                    t.TenThuoc = item.tenT;
                    t.MaNhomThuoc = item.maNT;
                    t.TenNhomThuoc = item.tenNT;
                    if (item.loaiT == true)
                    {
                        t.LoaiThuoc = "Thuốc Kê Đơn";
                    }
                    else t.LoaiThuoc = "Không Kê Đơn";
                    t.HoatChatChinh = item.hcc;
                    if (item.tt == true)
                    {
                        t.TrangThai = "Đang Hoạt Động";
                    }
                    else t.TrangThai = "Ngưng Hoạt Động";
                    lst.Add(t);
                    a++;
                    if (a == 50)
                        return lst;
                }
                return lst;
            }
            else return null;
        }
        // Lấy thuốc theo mã kết 2 bảng
        public List<DTO_Thuoc> LayThuocTheoMaT(string mant)
        {
            List<DTO_Thuoc> lst = new List<DTO_Thuoc>();
            var p = (from t in db.Thuocs
                     join nt in db.NhomThuocs on t.maNhomThuoc equals nt.maNhomThuoc
                     where t.maNhomThuoc==mant
                     select new
                     {
                         maT = t.maThuoc,
                         tenT = t.tenThuoc,
                         maNT = nt.maNhomThuoc,
                         tenNT = nt.tenNhomThuoc,
                         loaiT = t.loaiThuoc,
                         hcc = t.hoatChatChinh,
                         tt = t.trangThai
                     }).ToList();
            if (p.Count >0)
            {
                foreach (var item in p)
                {
                    DTO_Thuoc t = new DTO_Thuoc();
                    t.MaThuoc = item.maT;
                    t.TenThuoc = item.tenT;
                    t.MaNhomThuoc = item.maNT;
                    t.TenNhomThuoc = item.tenNT;
                    if (item.loaiT == true)
                    {
                        t.LoaiThuoc = "Thuốc Kê Đơn";
                    }
                    else t.LoaiThuoc = "Không Kê Đơn";
                    t.HoatChatChinh = item.hcc;
                    if (item.tt == true)
                    {
                        t.TrangThai = "Đang Hoạt Động";
                    }
                    else t.TrangThai = "Ngưng Hoạt Động";
                    lst.Add(t);
                }
                return lst;
            }
            else return null;
        }

        //Thêm Thuốc        
        public Boolean ThemThuoc(DTO_Thuoc t)
        {
            var p = db.Thuocs.Where(x => x.maThuoc == t.MaThuoc).FirstOrDefault();
            if (p == null)
            {
                Thuoc tt = new Thuoc();
                tt.maThuoc = t.MaThuoc;
                tt.tenThuoc = t.TenThuoc;
                tt.maNhomThuoc = t.MaNhomThuoc;
                if (t.LoaiThuoc == "Thuốc Kê Đơn")
                {
                    tt.loaiThuoc = true;
                }
                else tt.loaiThuoc = false;
                tt.hoatChatChinh = t.HoatChatChinh;
                if (t.TrangThai == "Đang Hoạt Động")
                {
                    tt.trangThai = true;
                }
                else tt.trangThai = false;
                db.Thuocs.InsertOnSubmit(tt);
                db.SubmitChanges();
                return true;
            }
            else return false;
        }
        //Sửa Thuốc
        public Boolean SuaThuoc(DTO_Thuoc t)
        {
            var p = db.Thuocs.Where(x => x.maThuoc == t.MaThuoc).FirstOrDefault();
            if (p != null)
            {
                p.tenThuoc = t.TenThuoc;
                p.maNhomThuoc = t.MaNhomThuoc;
                if (t.LoaiThuoc == "Thuốc Kê Đơn")
                {
                    p.loaiThuoc = true;
                }
                else p.loaiThuoc = false;
                p.hoatChatChinh = t.HoatChatChinh;
                if (t.TrangThai == "Đang Hoạt Động")
                {
                    p.trangThai = true;
                }
                else p.trangThai = false;
                db.SubmitChanges();
                return true;
            }
            else return false;
        }
        // Lấy Số Thuốc
        public int SoThuoc()
        {
            var p = db.Thuocs.ToList();
            
            return p.Count;
        }
    }
}
