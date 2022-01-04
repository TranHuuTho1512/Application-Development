using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNhaThuoc
{
    public class DTO_NhomThuoc
    {
        private string maNhomThuoc;
        private string tenNhomThuoc;

        public string MaNhomThuoc { get => maNhomThuoc; set => maNhomThuoc = value; }
        public string TenNhomThuoc { get => tenNhomThuoc; set => tenNhomThuoc = value; }

        public DTO_NhomThuoc(string ma, string ten)
        {
            this.MaNhomThuoc = ma;
            this.TenNhomThuoc = ten;
        }
        public DTO_NhomThuoc()
        {

        }
    }
}
