using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNhaThuoc;

namespace DAL_QuanLyNhaThuoc
{
    public class DAL_NhomThuoc
    {

        QLQTDataContext db;
        public DAL_NhomThuoc()
        {
            db = new QLQTDataContext();
        }
        // Lấy Danh Sách Nhóm thuốc
        public List<DTO_NhomThuoc> LayHetNhomThuoc()
        {
            List<DTO_NhomThuoc> dsnt = new List<DTO_NhomThuoc>();
            var p = db.NhomThuocs.ToList();
            if (p.Count > 0)
            {
                foreach (var item in p)
                {
                    DTO_NhomThuoc nt = new DTO_NhomThuoc();
                    nt.MaNhomThuoc = item.maNhomThuoc;
                    nt.TenNhomThuoc = item.tenNhomThuoc;
                    dsnt.Add(nt);
                }
                return dsnt;
            }
            else return null;
        }
        // Thêm Nhóm Thuốc
        public Boolean ThemNhomThuoc(DTO_NhomThuoc nt)
        {
            var p = db.NhomThuocs.Where(x => x.maNhomThuoc == nt.MaNhomThuoc).FirstOrDefault();
            if (p == null)
            {
                NhomThuoc dbt = new NhomThuoc();
                dbt.maNhomThuoc = nt.MaNhomThuoc;
                dbt.tenNhomThuoc = nt.TenNhomThuoc;
                db.NhomThuocs.InsertOnSubmit(dbt);
                db.SubmitChanges();
                return true;
            }
            else return false;
        }
        // Sửa nhóm thuốc
        public Boolean SuaNhomThuoc(DTO_NhomThuoc nt)
        {
            var p = db.NhomThuocs.Where(x => x.maNhomThuoc == nt.MaNhomThuoc).FirstOrDefault();
            if (p != null)
            {
                p.tenNhomThuoc = nt.TenNhomThuoc;
                db.SubmitChanges();
                return true;
            }
            else return false;
        }
        public int SoNhomThuoc()
        {
            var p = db.NhomThuocs.ToList();

            return p.Count;
        }
    }
}
