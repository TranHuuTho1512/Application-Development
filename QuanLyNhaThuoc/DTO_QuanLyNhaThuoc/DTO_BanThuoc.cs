using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNhaThuoc
{
    public class DTO_BanThuoc
    {

        private string maThuoc;
        private string tenThuoc;
        private string hoatChatChinh;
        private string loaiThuoc;
        private string maNhomThuoc;
        private string tenNhomThuoc;
        private string donViTinh;
        private double giaBanChan;
        private string donViQuyDoi;
        private double giaBanLe;
        private int tyLeQuyDoi;
        private DateTime ngaySanXuat;
        private DateTime hanSuDung;
        private string xuatXu;
        private string moTa;
        private string maLoThuoc;
        private double vAT;
        private int soLuongTon;
        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public string HoatChatChinh { get => hoatChatChinh; set => hoatChatChinh = value; }
        public string LoaiThuoc { get => loaiThuoc; set => loaiThuoc = value; }
        public string MaNhomThuoc { get => maNhomThuoc; set => maNhomThuoc = value; }
        public string TenNhomThuoc { get => tenNhomThuoc; set => tenNhomThuoc = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public double GiaBanChan { get => giaBanChan; set => giaBanChan = value; }
        public string DonViQuyDoi { get => donViQuyDoi; set => donViQuyDoi = value; }
        public double GiaBanLe { get => giaBanLe; set => giaBanLe = value; }
        public int TyLeQuyDoi { get => tyLeQuyDoi; set => tyLeQuyDoi = value; }
        public DateTime NgaySanXuat { get => ngaySanXuat; set => ngaySanXuat = value; }
        public DateTime HanSuDung { get => hanSuDung; set => hanSuDung = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string MaLoThuoc { get => maLoThuoc; set => maLoThuoc = value; }
        public double VAT { get => vAT; set => vAT = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }

        public DTO_BanThuoc(string mathc, string tent, string hcc, string lt, string mnt, string tnt, string dvt, double gbc, string dvqd, double gbl, int tlqd, DateTime nsx, DateTime hsd, int slt, string mota, string maLo, double v, string xx)
        {
            this.MaThuoc = mathc;
            this.TenThuoc = tent;
            this.HoatChatChinh = hcc;
            this.LoaiThuoc = lt;
            this.MaNhomThuoc = mnt;
            this.TenNhomThuoc = tnt;
            this.DonViTinh = dvt;
            this.GiaBanChan = gbc;
            this.DonViQuyDoi = dvqd;
            this.GiaBanLe = gbl;
            this.TyLeQuyDoi = tlqd;
            this.NgaySanXuat = nsx;
            this.HanSuDung = hsd;
            this.XuatXu = xx;
            this.SoLuongTon = slt;
            this.MoTa = mota;
            this.MaLoThuoc = maLo;
            this.VAT = v;
        }

        public DTO_BanThuoc()
        {
        }
    }
}
