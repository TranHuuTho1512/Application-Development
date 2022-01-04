using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNhaThuoc
{
    public class DTO_NhaCungCap
    {
        private string maNCC;
        private string tenNCC;
        private string diaChi;
        private string sdt;
        private string email;
        private string trangThai;

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DTO_NhaCungCap()
        {

        }
        public DTO_NhaCungCap(string ma, string ten, string dc, string sdt, string email, string trangthai)
        {
            this.MaNCC = ma;
            this.TenNCC = ten;
            this.DiaChi = dc;
            this.Sdt = sdt;
            this.Email = email;
            this.TrangThai = trangthai;

        }

    }
}
