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
        public int id_nap { get; set; }
        public string tendangnhap { get; set; }
        public int sotiennap { get; set; }
        public DateTime thoigiannap { get; set; }
        public string ghichu { get; set; }
        public int tongtiennap { get; set; } // Lấy từ bảng TaiKhoan sang
    }
    public class AppDbContext : DbContext
    {
        public DbSet<TaiKhoan> taikhoans { get; set; }
        public DbSet<ttMayTram> ttMayTrams { get; set; }
        public DbSet<lichsunaptien> lichsunaptiens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=LAPTOP-71A4N08C;Initial Catalog=winform;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.ToTable("taikhoan");
                entity.HasKey(t => t.tendangnhap);
                entity.ToTable(tb => tb.HasTrigger("checksodu"));
            });
            modelBuilder.Entity<ttMayTram>(entity =>
            {
                entity.ToTable("ttMayTram"); 
                entity.HasKey(t => t.somay);
            });
                modelBuilder.Entity<lichsunaptien>(entity =>
                {
                    entity.ToTable("lichsunaptien"); 
                    entity.HasKey(t => t.id_nap);
                });
        }
    }
}