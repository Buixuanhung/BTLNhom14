using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CuaHangHung.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_HoaDon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    HoaDonCode = table.Column<string>(type: "TEXT", nullable: false),
                    HoaDonName = table.Column<string>(type: "TEXT", nullable: false),
                    SanPhamCode = table.Column<string>(type: "TEXT", nullable: false),
                    SoLuong = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.HoaDonCode);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    KhachHangCode = table.Column<string>(type: "TEXT", nullable: false),
                    KhachHangName = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.KhachHangCode);
                });

            migrationBuilder.CreateTable(
                name: "Khoss",
                columns: table => new
                {
                    KhoID = table.Column<string>(type: "TEXT", nullable: false),
                    SanPhamName = table.Column<string>(type: "TEXT", nullable: false),
                    NumberbKho = table.Column<string>(type: "TEXT", nullable: false),
                    KhoStoreExists = table.Column<string>(type: "TEXT", nullable: false),
                    InventoryKho = table.Column<string>(type: "TEXT", nullable: false),
                    ExportKho = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoss", x => x.KhoID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    NhanVienCode = table.Column<string>(type: "TEXT", nullable: false),
                    NhanVienName = table.Column<string>(type: "TEXT", nullable: false),
                    Sex = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.NhanVienCode);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    SanPhamCode = table.Column<string>(type: "TEXT", nullable: false),
                    SanPhamName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.SanPhamCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "Khoss");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "SanPham");
        }
    }
}
