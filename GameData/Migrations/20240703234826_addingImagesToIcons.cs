using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameData.Migrations
{
    /// <inheritdoc />
    public partial class addingImagesToIcons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageBackground",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                column: "ImageBackground",
                value: "https://cdn-icons-png.flaticon.com/32/1144/1144549.png");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                column: "ImageBackground",
                value: "https://cdn-icons-png.flaticon.com/32/2175/2175884.png");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                column: "ImageBackground",
                value: "https://cdn-icons-png.flaticon.com/32/3159/3159347.png");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                column: "ImageBackground",
                value: "https://cdn-icons-png.flaticon.com/32/4204/4204638.png");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                column: "ImageBackground",
                value: "https://cdn-icons-png.flaticon.com/32/857/857418.png");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                column: "ImageBackground",
                value: "https://cdn-icons-png.flaticon.com/32/2780/2780137.png");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7,
                column: "ImageBackground",
                value: "https://cdn-icons-png.flaticon.com/32/3976/3976625.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageBackground",
                table: "Genres");
        }
    }
}
