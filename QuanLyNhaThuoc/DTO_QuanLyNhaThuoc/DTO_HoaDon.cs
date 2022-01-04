using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNhaThuoc
{
    public class DTO_HoaDon
    {
        private string maHD;
        private DateTime ngayLapHD;
        private string loaiHD;
        private string ghiChu;
        private string tenNV;
        private string sdtNV;
        private string tenKH;
        private string sdtKH;
        private string maNV;
        private string maKH;

        public string MaHD { get => maHD; set => maHD = value; }
        
        public DateTime NgayLapHD { get => ngayLapHD; set => ngayLapHD = value; }
        public string LoaiHD { get => loaiHD; set => loaiHD = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string SdtNV { get => sdtNV; set => sdtNV = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SdtKH { get => sdtKH; set => sdtKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
     

        public DTO_HoaDon()
        {

        }
        public DTO_HoaDon(string ma, DateTime nl, string lhd, string gc,string tennv, string sdtnv,string tenkh,string sdtkh, string manv, string makh)
        {
            this.MaHD = ma;
            this.NgayLapHD = nl;
            this.LoaiHD = lhd;
            this.GhiChu = gc;
            this.TenNV = tennv;
            this.SdtNV = sdtnv;
            this.TenKH = tenkh;
            this.SdtKH = sdtkh;
            this.MaNV = manv;
            this.MaKH = makh;
        }
    }
}
