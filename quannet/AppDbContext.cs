using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations; // Thêm dòng này để dùng [Key]
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1
{
    public class ttMayTram
    {
        [Key]
        public string somay { get; set; }
        public string tenmay { get; set; }
        public string trangthai { get; set; }

        [NotMapped] 
        public string tendangnhap { get; set; }

        [NotMapped] 
        public int? sodu { get; set; }

        [NotMapped]
        public DateTime? batdauluc { get; set; }
        [NotMapped]
        public string? thoigianchoi { get; set; }
    }
    public class lichsunaptien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Để EF biết ID này tự tăng
        public int id_nap { get; set; }

        public string tendangnhap { get; set; }
        public int sotiennap { get; set; }
        public DateTime thoigiannap { get; set; }
        public string ghichu { get; set; }
    }
    public class LichSuNapView
    {
        [Key]
        public int id_nap { get; set; }
        public string tendangnhap { get; set; }
        public int sotiennap { get; set; }
        public DateTime thoigiannap { get; set; }
        public string ghichu { get; set; }
        public int tongtiennap { get; set; } // Lấy từ bảng TaiKhoan sang
    }
    // ... (Các class ttMayTram, TaiKhoan ku giữ nguyên) ...

    public class menudichvu
    {
        [Key]
        public int id { get; set; }
        public string tenmon { get; set; }
        public int dongia { get; set; }
        public int soluong { get; set; }
        public string hinhanh { get; set; }
    }

    public class lichsugiochoi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string tendangnhap { get; set; }
        public string somay { get; set; }
        public DateTime batdauluc { get; set; }
        public DateTime ketthuc { get; set; }
        public string? thoigianchoi { get; set; }
        public int sotienchu { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public DbSet<TaiKhoan> taikhoans { get; set; }
        public DbSet<ttMayTram> ttMayTrams { get; set; }
        public DbSet<lichsunaptien> lichsunaptiens { get; set; }
        public DbSet<lichsugiochoi> lichsugiochois { get; set; }

        // THÊM DÒNG NÀY VÀO ĐÂY KU ƠI!
        public DbSet<menudichvu> menudichvus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=LAPTOP-71A4N08C;Initial Catalog=winform;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<lichsugiochoi>().ToTable("lichsugiochoi");
            modelBuilder.Entity<TaiKhoan>().ToTable("taikhoan")
                .ToTable(tb => tb.HasTrigger("checksodu")); // báo EF biết có trigger

            modelBuilder.Entity<ttMayTram>().ToTable("ttMayTram");
            modelBuilder.Entity<lichsunaptien>().ToTable("lichsunaptien");

            modelBuilder.Entity<menudichvu>(entity =>
            {
                entity.ToTable("menudichvu");
                entity.HasKey(e => e.id);
            });
        }
    }
}