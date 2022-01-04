using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNhaThuoc
{
    public class DTO_KhachHang
    {
        private string maKH;
        private string tenKH;
        private string sdtKH;
        private string diaChi;
        private string email;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SdtKH { get => sdtKH; set => sdtKH = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DTO_KhachHang()
        {

        }

        public DTO_KhachHang(string makh, string ten, string sdt, string diachi, string email)
        {
            this.MaKH = makh;
            this.TenKH = ten;
            this.SdtKH = sdt;
            this.DiaChi = diachi;
            this.Email = email;
        }

    }
}

