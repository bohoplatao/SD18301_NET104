using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppData.Models
{
    public partial class SD18301_NET104Context : DbContext
    {
        public SD18301_NET104Context()
        {
        }

        public SD18301_NET104Context(DbContextOptions<SD18301_NET104Context> options)
            : base(options)
        {
        }

        // Thêm DBSET Vào 
        public DbSet<Users> Users { get; set; }
        //public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<GIoHang> gIoHangs { get; set; }
        public DbSet<GioHangCT> gioHangCTs { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<HoaDonCT>  hoaDonCTs { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<SanPhamCT> sanPhamCTs { get; set; }
        public DbSet<UserAddress> userAddress { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
        public DbSet<Voucher> vouchers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-CXH2410\\SQLEXPRESS;Database=SD18301_NET104_02;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //OnModelCreatingPartial(modelBuilder);
            //base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
