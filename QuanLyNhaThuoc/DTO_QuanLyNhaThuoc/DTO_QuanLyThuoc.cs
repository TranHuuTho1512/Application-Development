using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNhaThuoc
{
    public class DTO_QuanLyThuoc
    {
        private string maThuoc;
        private string tenThuoc;
        private string maNhomThuoc;
        private string tenNhomThuoc;
        private string hoatChatChinh;
        private int sLTL;
        private double giaBanLe;
        private string dVTL;
        private string lieuLuongDung;
        private int sLTC;
        private double giaBanChan;
        private string dVTC;
        private string loaiThuoc;
        private string trangThai;

        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public string MaNhomThuoc { get => maNhomThuoc; set => maNhomThuoc = value; }
        public string TenNhomThuoc { get => tenNhomThuoc; set => tenNhomThuoc = value; }
        public string HoatChatChinh { get => hoatChatChinh; set => hoatChatChinh = value; }
        public int SLTL { get => sLTL; set => sLTL = value; }
        public double GiaBanLe { get => giaBanLe; set => giaBanLe = value; }
        public string DVTL { get => dVTL; set => dVTL = value; }
        public int SLTC { get => sLTC; set => sLTC = value; }
        public double GiaBanChan { get => giaBanChan; set => giaBanChan = value; }
        public string DVTC { get => dVTC; set => dVTC = value; }
        public string LieuLuongDung { get => lieuLuongDung; set => lieuLuongDung = value; }
        public string LoaiThuoc { get => loaiThuoc; set => loaiThuoc = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }


        public DTO_QuanLyThuoc()
        {

        }
        public DTO_QuanLyThuoc(string ma, string ten, string mn, string tenma, string hcc, int sltl, double gbl, string dvtl, int sltc, double gbc, string dvbc, string lld, string loait, string tt)
        {
            this.MaThuoc = ma;
            this.TenThuoc = ten;
            this.MaNhomThuoc = mn;
            this.TenNhomThuoc = tenma;
            this.HoatChatChinh = hcc;
            this.SLTL = sltl;
            this.GiaBanLe = gbl;
            this.DVTL = dvtl;
            this.SLTC = sltc;
            this.GiaBanChan = gbc;
            this.DVTC = dvbc;
            this.LieuLuongDung = lld;
            this.LoaiThuoc = loait;
            this.TrangThai = tt;
        }

    }
}
