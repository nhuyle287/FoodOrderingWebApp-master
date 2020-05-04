using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FoodOrderingWebApp.Models
{
    public partial class FoodOrderingWebAppDbContext : DbContext
    {
        public FoodOrderingWebAppDbContext()
        {
        }

        public FoodOrderingWebAppDbContext(DbContextOptions<FoodOrderingWebAppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<BinhLuan> BinhLuan { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual DbSet<HinhAnh> HinhAnh { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMai { get; set; }
        public virtual DbSet<LoaiKhachHang> LoaiKhachHang { get; set; }
        public virtual DbSet<LoaiKhachHangKhuyenMai> LoaiKhachHangKhuyenMai { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhanLoai> PhanLoai { get; set; }
        public virtual DbSet<PhiShip> PhiShip { get; set; }
        public virtual DbSet<Reply> Reply { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<SanPhamKhuyenMai> SanPhamKhuyenMai { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<VaiTro> VaiTro { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\;Database=FoodOrderingWebAppTest;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Admin__A9D10534ECBDCF4B")
                    .IsUnique();

                entity.HasIndex(e => e.Sdt)
                    .HasName("UQ__Admin__CA1930A53B20DDE3")
                    .IsUnique();

                entity.Property(e => e.Adminid).HasColumnName("adminid");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ho)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TaiKhoan)
                    .WithMany(p => p.Admin)
                    .HasForeignKey(d => d.TaiKhoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKAdmin457962");
            });

            modelBuilder.Entity<BinhLuan>(entity =>
            {
                entity.Property(e => e.KhachHangId).HasColumnName("khachHangId");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");

                entity.HasOne(d => d.KhachHang)
                    .WithMany(p => p.BinhLuan)
                    .HasForeignKey(d => d.KhachHangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QQ");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.BinhLuan)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKBinhLuan224061");
            });

            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.HasKey(e => new { e.HoaDonId, e.SanPhamId })
                    .HasName("PK__ChiTietH__39074EB4DF42D0D2");

                entity.HasOne(d => d.HoaDon)
                    .WithMany(p => p.ChiTietHoaDon)
                    .HasForeignKey(d => d.HoaDonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKChiTietHoa204072");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.ChiTietHoaDon)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKChiTietHoa598700");
            });

            modelBuilder.Entity<HinhAnh>(entity =>
            {
                entity.HasIndex(e => e.TenFile)
                    .HasName("UQ__HinhAnh__4E25C6E260D8A80D")
                    .IsUnique();

                entity.Property(e => e.TenFile)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.HinhAnh)
                    .HasForeignKey(d => d.SanPhamId)
                    .HasConstraintName("FKHinhAnh781525");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.Property(e => e.HoaDonId).ValueGeneratedNever();

                entity.Property(e => e.NgayGiao).HasColumnType("datetime");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.PhuongThucThanhToan)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Quan)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SoNha)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TinNhan).HasColumnType("text");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.KhachHang)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.KhachHangId)
                    .HasConstraintName("FKHoaDon363575");

                entity.HasOne(d => d.NhanVien)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.NhanVienId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKHoaDon185377");

                entity.HasOne(d => d.PhiShip)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.PhiShipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKHoaDon241522");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ__KhachHan__A9D10534C0E45CF8")
                    .IsUnique();

                entity.HasIndex(e => e.Sdt)
                    .HasName("UQ__KhachHan__CA1930A50AB6226B")
                    .IsUnique();

                entity.Property(e => e.KhachHangId).HasColumnName("khachHangId");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ho)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LoaiKhachHang)
                    .WithMany(p => p.KhachHang)
                    .HasForeignKey(d => d.LoaiKhachHangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKKhachHang891044");

                entity.HasOne(d => d.TaiKhoan)
                    .WithMany(p => p.KhachHang)
                    .HasForeignKey(d => d.TaiKhoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKKhachHang993389");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasIndex(e => e.TenKhuyenMai)
                    .HasName("UQ__KhuyenMa__A956B87CD7233493")
                    .IsUnique();

                entity.Property(e => e.KhuyenMaiId).ValueGeneratedNever();

                entity.Property(e => e.Hinhanh)
                    .HasColumnName("hinhanh")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MoTa).HasColumnType("text");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");

                entity.Property(e => e.TenKhuyenMai)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoaiKhachHang>(entity =>
            {
                entity.Property(e => e.TenLoai)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoaiKhachHangKhuyenMai>(entity =>
            {
                entity.HasKey(e => new { e.LoaiKhachHangId, e.KhuyenMaiId })
                    .HasName("PK__LoaiKhac__06BDA987D554D22A");

                entity.ToTable("LoaiKhachHang_KhuyenMai");

                entity.HasOne(d => d.KhuyenMai)
                    .WithMany(p => p.LoaiKhachHangKhuyenMai)
                    .HasForeignKey(d => d.KhuyenMaiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKLoaiKhachH146696");

                entity.HasOne(d => d.LoaiKhachHang)
                    .WithMany(p => p.LoaiKhachHangKhuyenMai)
                    .HasForeignKey(d => d.LoaiKhachHangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKLoaiKhachH282953");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ__NhanVien__A9D10534BC475773")
                    .IsUnique();

                entity.HasIndex(e => e.Sdt)
                    .HasName("UQ__NhanVien__CA1930A5B1A44BC6")
                    .IsUnique();

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ho)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TaiKhoan)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.TaiKhoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKNhanVien22888");
            });

            modelBuilder.Entity<PhanLoai>(entity =>
            {
                entity.HasIndex(e => e.Loai)
                    .HasName("UQ__PhanLoai__4E48BB7550817CDE")
                    .IsUnique();

                entity.Property(e => e.Loai)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MoTa).HasColumnType("text");
            });

            modelBuilder.Entity<PhiShip>(entity =>
            {
                entity.HasIndex(e => e.Quan)
                    .HasName("UQ__PhiShip__D06970C31B51179A")
                    .IsUnique();
            });

            modelBuilder.Entity<Reply>(entity =>
            {
                entity.Property(e => e.ThoiGian).HasColumnType("datetime");

                entity.HasOne(d => d.BinhLuan)
                    .WithMany(p => p.Reply)
                    .HasForeignKey(d => d.BinhLuanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKReply278339");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasIndex(e => e.TenSanPham)
                    .HasName("UQ__SanPham__FCA80469EB68D194")
                    .IsUnique();

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.PhanLoai)
                    .WithMany(p => p.SanPham)
                    .HasForeignKey(d => d.PhanLoaiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKSanPham562583");
            });

            modelBuilder.Entity<SanPhamKhuyenMai>(entity =>
            {
                entity.HasKey(e => new { e.SanPhamId, e.KhuyenMaiId })
                    .HasName("PK__SanPham___6D38D89DA1E3B2DB");

                entity.ToTable("SanPham_KhuyenMai");

                entity.HasOne(d => d.KhuyenMai)
                    .WithMany(p => p.SanPhamKhuyenMai)
                    .HasForeignKey(d => d.KhuyenMaiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKSanPham_Kh61916");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.SanPhamKhuyenMai)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKSanPham_Kh126751");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasIndex(e => e.Username)
                    .HasName("UQ__TaiKhoan__F3DBC5721C5D6382")
                    .IsUnique();

                entity.Property(e => e.KichHoat).HasDefaultValueSql("((1))");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VaiTro)
                    .WithMany(p => p.TaiKhoan)
                    .HasForeignKey(d => d.VaiTroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKTaiKhoan804946");
            });

            modelBuilder.Entity<VaiTro>(entity =>
            {
                entity.HasIndex(e => e.MoTa)
                    .HasName("UQ__VaiTro__24B0CA9E594B5903")
                    .IsUnique();

                entity.Property(e => e.MoTa)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
