using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameData.Migrations
{
    /// <inheritdoc />
    public partial class addedSortByFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "Added",
                table: "Games",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "Created",
                table: "Games",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "Released",
                table: "Games",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "Update",
                table: "Games",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2018, 5, 12), new DateOnly(2017, 11, 23), "E10+", new DateOnly(2017, 3, 3), new DateOnly(2022, 8, 7) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2019, 2, 14), new DateOnly(2018, 12, 1), "M", new DateOnly(2018, 10, 26), new DateOnly(2023, 3, 20) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2016, 7, 30), new DateOnly(2015, 9, 5), "M", new DateOnly(2015, 5, 19), new DateOnly(2021, 11, 11) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2015, 3, 8), new DateOnly(2014, 1, 22), "M", new DateOnly(2013, 9, 17), new DateOnly(2022, 6, 15) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2016, 9, 18), new DateOnly(2015, 6, 7), "M", new DateOnly(2015, 3, 24), new DateOnly(2020, 12, 3) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2017, 5, 1), new DateOnly(2016, 8, 14), "M", new DateOnly(2016, 3, 24), new DateOnly(2021, 7, 29) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2018, 2, 9), new DateOnly(2017, 12, 5), "E10+", new DateOnly(2017, 10, 27), new DateOnly(2022, 4, 18) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2019, 1, 7), new DateOnly(2018, 7, 3), "M", new DateOnly(2018, 4, 20), new DateOnly(2023, 2, 14) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2017, 11, 22), new DateOnly(2016, 12, 8), "M", new DateOnly(2016, 9, 15), new DateOnly(2021, 5, 30) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2015, 8, 19), new DateOnly(2014, 4, 3), "M", new DateOnly(2010, 1, 26), new DateOnly(2020, 10, 12) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2017, 3, 11), new DateOnly(2016, 9, 27), "T", new DateOnly(2016, 5, 24), new DateOnly(2022, 1, 5) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2018, 10, 3), new DateOnly(2017, 9, 14), "T", new DateOnly(2017, 7, 25), new DateOnly(2023, 4, 2) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 13,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2015, 6, 25), new DateOnly(2014, 2, 8), "E10+", new DateOnly(2011, 11, 18), new DateOnly(2022, 9, 17) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 14,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2020, 1, 9), new DateOnly(2019, 11, 30), "M", new DateOnly(2019, 10, 25), new DateOnly(2023, 5, 8) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 15,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2020, 7, 22), new DateOnly(2020, 5, 15), "T", new DateOnly(2020, 4, 10), new DateOnly(2023, 1, 3) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 16,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2021, 2, 18), new DateOnly(2020, 12, 28), "M", new DateOnly(2020, 12, 10), new DateOnly(2023, 6, 9) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2020, 9, 5), new DateOnly(2020, 7, 10), "M", new DateOnly(2020, 6, 19), new DateOnly(2022, 11, 25) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 18,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2020, 10, 1), new DateOnly(2020, 8, 9), "M", new DateOnly(2020, 7, 17), new DateOnly(2023, 3, 14) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 19,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2020, 12, 3), new DateOnly(2020, 10, 5), "T", new DateOnly(2020, 9, 17), new DateOnly(2022, 7, 19) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 20,
                columns: new[] { "Added", "Created", "Rating", "Released", "Update" },
                values: new object[] { new DateOnly(2020, 9, 28), new DateOnly(2018, 8, 2), "E", new DateOnly(2018, 6, 15), new DateOnly(2023, 1, 17) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Added",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Released",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Update",
                table: "Games");
        }
    }
}
