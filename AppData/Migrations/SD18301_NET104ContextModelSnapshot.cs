﻿// <auto-generated />
using System;
using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppData.Migrations
{
    [DbContext(typeof(SD18301_NET104Context))]
    partial class SD18301_NET104ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppData.Models.GIoHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_Users")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ID_Users")
                        .IsUnique();

                    b.ToTable("gIoHangs");
                });

            modelBuilder.Entity("AppData.Models.GioHangCT", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_GioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_SPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("SoLuong_GHCT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ID_GioHang");

                    b.HasIndex("ID_SPCT");

                    b.ToTable("gioHangCTs");
                });

            modelBuilder.Entity("AppData.Models.HoaDon", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_Users")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ngaytao")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongTien_HD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ID_Users");

                    b.ToTable("hoaDons");
                });

            modelBuilder.Entity("AppData.Models.HoaDonCT", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia_HDCT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ID_HD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_SPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_Voucher")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SoLuong_HDCT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("ID_HD");

                    b.HasIndex("ID_SPCT");

                    b.HasIndex("ID_Voucher");

                    b.ToTable("hoaDonCTs");
                });

            modelBuilder.Entity("AppData.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("AppData.Models.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Anh_SP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayCapnhat")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("sanPhams");
                });

            modelBuilder.Entity("AppData.Models.SanPhamCT", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChatLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Gia_NiemYet")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Gia_SPCT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HangSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ID_SP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Size")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SoLuong_SPCT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte>("TrangThai")
                        .HasColumnType("tinyint");

                    b.HasKey("ID");

                    b.HasIndex("ID_SP");

                    b.ToTable("sanPhamCTs");
                });

            modelBuilder.Entity("AppData.Models.UserAddress", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ID_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ID_User");

                    b.ToTable("userAddress");
                });

            modelBuilder.Entity("AppData.Models.UserRole", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_Role")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_Users")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ID_Role");

                    b.HasIndex("ID_Users");

                    b.ToTable("userRoles");
                });

            modelBuilder.Entity("AppData.Models.Users", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TenDN");

                    b.HasKey("ID");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Voucher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GiaTriVoucher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("vouchers");
                });

            modelBuilder.Entity("AppData.Models.GIoHang", b =>
                {
                    b.HasOne("AppData.Models.Users", "Users")
                        .WithOne("GIoHang")
                        .HasForeignKey("AppData.Models.GIoHang", "ID_Users")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("AppData.Models.GioHangCT", b =>
                {
                    b.HasOne("AppData.Models.GIoHang", "GIoHang")
                        .WithMany("GioHangCTs")
                        .HasForeignKey("ID_GioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_GH_GHCT");

                    b.HasOne("AppData.Models.SanPhamCT", "SanPhamCT")
                        .WithMany("GioHangCTs")
                        .HasForeignKey("ID_SPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SPCT_GHCT");

                    b.Navigation("GIoHang");

                    b.Navigation("SanPhamCT");
                });

            modelBuilder.Entity("AppData.Models.HoaDon", b =>
                {
                    b.HasOne("AppData.Models.Users", "Users")
                        .WithMany("HoaDons")
                        .HasForeignKey("ID_Users")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HD_USer");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("AppData.Models.HoaDonCT", b =>
                {
                    b.HasOne("AppData.Models.HoaDon", "HoaDon")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("ID_HD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HD_HDCT");

                    b.HasOne("AppData.Models.SanPhamCT", "SanPhamCT")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("ID_SPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HDCT_SPCT");

                    b.HasOne("AppData.Models.Voucher", "Voucher")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("ID_Voucher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_VC_HDCT");

                    b.Navigation("HoaDon");

                    b.Navigation("SanPhamCT");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("AppData.Models.SanPhamCT", b =>
                {
                    b.HasOne("AppData.Models.SanPham", "SanPham")
                        .WithMany("SanPhamCTs")
                        .HasForeignKey("ID_SP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SP_SPCT");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("AppData.Models.UserAddress", b =>
                {
                    b.HasOne("AppData.Models.Users", "User")
                        .WithMany("UserAddresses")
                        .HasForeignKey("ID_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_USADD_USer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AppData.Models.UserRole", b =>
                {
                    b.HasOne("AppData.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("ID_Role")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ROLE_USERROLE");

                    b.HasOne("AppData.Models.Users", "Users")
                        .WithMany("UserRoles")
                        .HasForeignKey("ID_Users")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("KF_User_UserRole");

                    b.Navigation("Role");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("AppData.Models.GIoHang", b =>
                {
                    b.Navigation("GioHangCTs");
                });

            modelBuilder.Entity("AppData.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonCTs");
                });

            modelBuilder.Entity("AppData.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("AppData.Models.SanPham", b =>
                {
                    b.Navigation("SanPhamCTs");
                });

            modelBuilder.Entity("AppData.Models.SanPhamCT", b =>
                {
                    b.Navigation("GioHangCTs");

                    b.Navigation("HoaDonCTs");
                });

            modelBuilder.Entity("AppData.Models.Users", b =>
                {
                    b.Navigation("GIoHang")
                        .IsRequired();

                    b.Navigation("HoaDons");

                    b.Navigation("UserAddresses");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("AppData.Models.Voucher", b =>
                {
                    b.Navigation("HoaDonCTs");
                });
#pragma warning restore 612, 618
        }
    }
}
