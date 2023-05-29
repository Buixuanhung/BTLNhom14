using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CuaHangHung.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CuaHangHung.Models.NhanVien> NhanVien { get; set; } = default!;

        public DbSet<CuaHangHung.Models.SanPham> SanPham { get; set; } = default!;

        public DbSet<CuaHangHung.Models.KhachHang> KhachHang { get; set; } = default!;

        public DbSet<CuaHangHung.Models.HoaDon> HoaDon { get; set; } = default!;

        public DbSet<CuaHangHung.Models.Kho> Kho { get; set; } = default!;
    }
