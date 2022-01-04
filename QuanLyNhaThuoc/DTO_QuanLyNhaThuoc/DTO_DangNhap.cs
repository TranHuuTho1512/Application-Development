using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNhaThuoc
{
   public class DTO_DangNhap
    {
        private string userName;
        private string matKhau;

        public string UserName { get => userName; set => userName = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public DTO_DangNhap()
        {

        }
        public DTO_DangNhap(string n, string mk)
        {
            this.UserName = n;
            this.MatKhau = mk;
        }
    }
}
