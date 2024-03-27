using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anh_SP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapnhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenDN = table.Column<string>(type: "varchar(50)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "vouchers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaTriVoucher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vouchers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sanPhamCTs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_SP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HangSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChatLieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong_SPCT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gia_SPCT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gia_NiemYet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhamCTs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SP_SPCT",
                        column: x => x.ID_SP,
                        principalTable: "sanPhams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gIoHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Users = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gIoHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gIoHangs_Users_ID_Users",
                        column: x => x.ID_Users,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Users = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TongTien_HD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ngaytao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HD_USer",
                        column: x => x.ID_Users,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userAddress",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userAddress", x => x.ID);
                    table.ForeignKey(
                        name: "FK_USADD_USer",
                        column: x => x.ID_User,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userRoles",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Role = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Users = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRoles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ROLE_USERROLE",
                        column: x => x.ID_Role,
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "KF_User_UserRole",
                        column: x => x.ID_Users,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gioHangCTs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_SPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_GioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong_GHCT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHangCTs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GH_GHCT",
                        column: x => x.ID_GioHang,
                        principalTable: "gIoHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SPCT_GHCT",
                        column: x => x.ID_SPCT,
                        principalTable: "sanPhamCTs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonCTs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_HD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_SPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong_HDCT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia_HDCT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ID_Voucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonCTs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HD_HDCT",
                        column: x => x.ID_HD,
                        principalTable: "hoaDons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HDCT_SPCT",
                        column: x => x.ID_SPCT,
                        principalTable: "sanPhamCTs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VC_HDCT",
                        column: x => x.ID_Voucher,
                        principalTable: "vouchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_gioHangCTs_ID_GioHang",
                table: "gioHangCTs",
                column: "ID_GioHang");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangCTs_ID_SPCT",
                table: "gioHangCTs",
                column: "ID_SPCT");

            migrationBuilder.CreateIndex(
                name: "IX_gIoHangs_ID_Users",
                table: "gIoHangs",
                column: "ID_Users",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonCTs_ID_HD",
                table: "hoaDonCTs",
                column: "ID_HD");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonCTs_ID_SPCT",
                table: "hoaDonCTs",
                column: "ID_SPCT");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonCTs_ID_Voucher",
                table: "hoaDonCTs",
                column: "ID_Voucher");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_ID_Users",
                table: "hoaDons",
                column: "ID_Users");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamCTs_ID_SP",
                table: "sanPhamCTs",
                column: "ID_SP");

            migrationBuilder.CreateIndex(
                name: "IX_userAddress_ID_User",
                table: "userAddress",
                column: "ID_User");

            migrationBuilder.CreateIndex(
                name: "IX_userRoles_ID_Role",
                table: "userRoles",
                column: "ID_Role");

            migrationBuilder.CreateIndex(
                name: "IX_userRoles_ID_Users",
                table: "userRoles",
                column: "ID_Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gioHangCTs");

            migrationBuilder.DropTable(
                name: "hoaDonCTs");

            migrationBuilder.DropTable(
                name: "userAddress");

            migrationBuilder.DropTable(
                name: "userRoles");

            migrationBuilder.DropTable(
                name: "gIoHangs");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "sanPhamCTs");

            migrationBuilder.DropTable(
                name: "vouchers");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "sanPhams");
        }
    }
}
