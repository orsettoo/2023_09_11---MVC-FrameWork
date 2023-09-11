using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class Kisi_Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Soyadi",
                table: "Kisiler",
                newName: "soyisim");

            migrationBuilder.RenameColumn(
                name: "Adi",
                table: "Kisiler",
                newName: "isim");

            migrationBuilder.AlterColumn<string>(
                name: "soyisim",
                table: "Kisiler",
                type: "ntext",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "isim",
                table: "Kisiler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "soyisim",
                table: "Kisiler",
                newName: "Soyadi");

            migrationBuilder.RenameColumn(
                name: "isim",
                table: "Kisiler",
                newName: "Adi");

            migrationBuilder.AlterColumn<string>(
                name: "Soyadi",
                table: "Kisiler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Adi",
                table: "Kisiler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
