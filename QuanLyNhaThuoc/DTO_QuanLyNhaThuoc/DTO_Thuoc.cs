using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNhaThuoc
{
    public class DTO_Thuoc
    {
        private string maThuoc;
        private string tenThuoc;
        private string maNhomThuoc;
        private string tenNhomThuoc;
        private string loaiThuoc;
        private string hoatChatChinh;
        private string trangThai;

        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public string MaNhomThuoc { get => maNhomThuoc; set => maNhomThuoc = value; }
        public string TenNhomThuoc { get => tenNhomThuoc; set => tenNhomThuoc = value; }
        public string LoaiThuoc { get => loaiThuoc; set => loaiThuoc = value; }
        public string HoatChatChinh { get => hoatChatChinh; set => hoatChatChinh = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public DTO_Thuoc()
        {

        }
        public DTO_Thuoc(string ma, string ten, string mn, string tennt, string lt, string hcc, string tt)
        {
            this.MaThuoc = ma;
            this.TenThuoc = ten;
            this.MaNhomThuoc = mn;
            this.TenNhomThuoc = tennt;
            this.LoaiThuoc = lt;
            this.HoatChatChinh = hcc;
            this.TrangThai = tt;

        }
    }
}
