using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNhaThuoc
{
    public class DTO_CTHoaDon
    {
        private string maThuoc;
        private string tenThuoc;
        private string hoatChatChinh;
        private int soLuong;
        private double gia;
        private string donViTinh;
        private double vAT;

        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public string HoatChatChinh { get => hoatChatChinh; set => hoatChatChinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double Gia { get => gia; set => gia = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public double VAT { get => vAT; set => vAT = value; }
        public DTO_CTHoaDon()
        {

        }
        public DTO_CTHoaDon(string mat, string tent, string hcc, int sl, double g, string dvt, double vat)
        {
            this.MaThuoc = mat;
            this.TenThuoc = tent;
            this.HoatChatChinh = hcc;
            this.SoLuong = sl;
            this.Gia = g;
            this.DonViTinh = dvt;
            this.VAT = vat;
        }
    }
}
