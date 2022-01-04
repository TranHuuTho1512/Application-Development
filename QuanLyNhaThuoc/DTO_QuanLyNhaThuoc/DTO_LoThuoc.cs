
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNhaThuoc
{
    public class DTO_LoThuoc
    {
        private string maLoThuoc;
        private string maThuoc;
        private string tenThuoc;
        private string maNCC;
        private string tenNCC;
        private string xuatXu;
        private DateTime ngaySanXuat;
        private DateTime hanSuDung;
        private string donViTinh;
        private string donViQuyDoi;
        private int tyLeQuyDoi;
        private double giaBanChan;
        private double giaBanLe;
        private string lieuLuongDung;
        private string moTa;
        private double vAT;
        private int soLuongTon;
        public string MaLoThuoc { get => maLoThuoc; set => maLoThuoc = value; }
        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }
        public DateTime NgaySanXuat { get => ngaySanXuat; set => ngaySanXuat = value; }
        public DateTime HanSuDung { get => hanSuDung; set => hanSuDung = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string DonViQuyDoi { get => donViQuyDoi; set => donViQuyDoi = value; }
        public int TyLeQuyDoi { get => tyLeQuyDoi; set => tyLeQuyDoi = value; }
        public double GiaBanChan { get => giaBanChan; set => giaBanChan = value; }
        public double GiaBanLe { get => giaBanLe; set => giaBanLe = value; }
        public string LieuLuongDung { get => lieuLuongDung; set => lieuLuongDung = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public double VAT { get => vAT; set => vAT = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }

        public DTO_LoThuoc()
        {

        }
        public DTO_LoThuoc(string malt, string mat, string tenthuoc, string mancc, string tenncc, string xx, DateTime nsx, DateTime hsd, string dvt, string dvqd, int tlqd, double gbc, double gbl, string lld, string mt, double vat, int slt)
        {
            this.MaLoThuoc = malt;
            this.MaThuoc = mat;
            this.TenThuoc = tenthuoc;
            this.MaNCC = mancc;
            this.TenNCC = tenncc;
            this.XuatXu = xx;
            this.NgaySanXuat = nsx;
            this.HanSuDung = hsd;
            this.DonViTinh = dvt;
            this.DonViQuyDoi = dvqd;
            this.TyLeQuyDoi = tlqd;
            this.GiaBanChan = gbc;
            this.GiaBanLe = gbl;
            this.LieuLuongDung = lld;
            this.MoTa = mt;
            this.VAT = vat;
            this.SoLuongTon = slt;

        }
    }
}
