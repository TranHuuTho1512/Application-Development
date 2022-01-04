using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace QuanLyNhaThuoc
{
    public static class MethodRegularExtention
    {
        public static Boolean NameCheck(this String s)
        {
            return Regex.Match(s, @"^((([a-zA-Z])|([Đđ]))\w+(\s(([a-zA-Z])|([Đđ]))\w+)*)$").Success;
            
        }
        public static Boolean EmailCheck(this String s)
        {

            return Regex.Match(s, @"^(\w+@\w+([.][a-zA-Z]+){1,4})$").Success;
        }
        public static Boolean PhoneCheck(this String s)
        {
            return Regex.Match(s, @"^([0][0-9]{2})([1-9]\d{6})$").Success;
        }
        public static Boolean CheckUserName(this String s)
        {
            return Regex.Match(s,@"^(([N][V])|([Q][L]))([0-1][0-9]{3})$").Success;
        }
        public static Boolean CheckMK(this String s)
        {
           return Regex.Match(s, @"^(.){6}\w{0,17}$").Success;
        }
        public static Boolean CheckCMND(this String s)
        {
            return Regex.Match(s, @"^(([0-9]{9})|([0-9]{12}))$").Success;
        }
      
        public static Boolean CheckNumber(this String s)
        {
            return Regex.Match(s, @"^((\D*\d+)|(\d+\D*\d+)|(\D*\d+\D*\d+))$").Success;
        }

        public static Boolean CheckNguyen(this String s)
        {
            return Regex.Match(s, @"^\d+$").Success;       
        }
    }
}
