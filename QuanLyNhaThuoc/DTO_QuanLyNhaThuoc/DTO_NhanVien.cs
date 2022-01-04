using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNhaThuoc
{
    public class DTO_NhanVien
    {
        private string maNV;
        private string tenNV;
        private string sdtNV;
        private string email;
        private string diaChi;
        private string cMND;
        private string matKhau;
        private string trangThai;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string SdtNV { get => sdtNV; set => sdtNV = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public DTO_NhanVien()
        {

        }

        public DTO_NhanVien(string ma, string ten, string sdt, string email, string diachi, string cmnd, string matkhau, string trangthai)
        {
            this.MaNV = ma;
            this.TenNV = ten;
            this.SdtNV = sdt;
            this.Email = email;
            this.DiaChi = diachi;
            this.CMND = cmnd;
            this.MatKhau = matkhau;
            this.TrangThai = trangthai;

        }
    }
}
