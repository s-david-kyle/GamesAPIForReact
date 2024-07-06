using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameData.Migrations
{
    /// <inheritdoc />
    public partial class renamingPaltforToPlatforms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatform_Platform_PlatformsPlatformId",
                table: "GamePlatform");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platform",
                table: "Platform");

            migrationBuilder.RenameTable(
                name: "Platform",
                newName: "Platforms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platforms",
                table: "Platforms",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Platforms_PlatformsPlatformId",
                table: "GamePlatform",
                column: "PlatformsPlatformId",
                principalTable: "Platforms",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatform_Platforms_PlatformsPlatformId",
                table: "GamePlatform");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platforms",
                table: "Platforms");

            migrationBuilder.RenameTable(
                name: "Platforms",
                newName: "Platform");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platform",
                table: "Platform",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Platform_PlatformsPlatformId",
                table: "GamePlatform",
                column: "PlatformsPlatformId",
                principalTable: "Platform",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
