using System;

namespace WinFormsApp1
{
    public class TaiKhoan
    {
        public string tendangnhap { get; set; } = "";
        public string matkhau { get; set; } = "";
        public int sodu { get; set; }
        public string? somay { get; set; }
        public DateTime? batdauluc { get; set; }

        public int? tongtiennap { get; set; }  
        public int? tongtiendung { get; set; }
    }
}