using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public static class SessionInfo
    {
        public static string TenDangNhap { get; set; }
        public static string VaiTro { get; set; }

        public static bool IsAdmin()
        {
            return VaiTro == "admin";
        }
    }
}