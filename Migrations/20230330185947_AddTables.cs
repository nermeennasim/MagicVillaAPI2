using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaAPI.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amenity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 3, 30, 11, 59, 47, 260, DateTimeKind.Local).AddTicks(8229), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "C:\\Users\\nerme\\full-stack-learning-projects\\DotNetMastery_RESTAPIS\\ASP.NET MVC\\MagicVilla\\MagicVilla_VillaAPI\\Images\\01.jpg", "Royal Villa", 5, 220.0, 550, null },
                    { 2, "", new DateTime(2023, 3, 30, 11, 59, 47, 260, DateTimeKind.Local).AddTicks(8271), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "C:\\Users\\nerme\\full-stack-learning-projects\\DotNetMastery_RESTAPIS\\ASP.NET MVC\\MagicVilla\\MagicVilla_VillaAPI\\Images\\01.jpg", "Ghoyal Villa", 4, 120.0, 230, null },
                    { 3, "", new DateTime(2023, 3, 30, 11, 59, 47, 260, DateTimeKind.Local).AddTicks(8273), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "C:\\Users\\nerme\\full-stack-learning-projects\\DotNetMastery_RESTAPIS\\ASP.NET MVC\\MagicVilla\\MagicVilla_VillaAPI\\Images\\01.jpg", "Shriya Ghoshal Villa", 3, 320.0, 140, null },
                    { 4, "", new DateTime(2023, 3, 30, 11, 59, 47, 260, DateTimeKind.Local).AddTicks(8275), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "C:\\Users\\nerme\\full-stack-learning-projects\\DotNetMastery_RESTAPIS\\ASP.NET MVC\\MagicVilla\\MagicVilla_VillaAPI\\Images\\01.jpg", "Social Villa", 2, 310.0, 400, null },
                    { 5, "", new DateTime(2023, 3, 30, 11, 59, 47, 260, DateTimeKind.Local).AddTicks(8278), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "C:\\Users\\nerme\\full-stack-learning-projects\\DotNetMastery_RESTAPIS\\ASP.NET MVC\\MagicVilla\\MagicVilla_VillaAPI\\Images\\01.jpg", "Ghost Villa", 1, 780.0, 480, null },
                    { 6, "", new DateTime(2023, 3, 30, 11, 59, 47, 260, DateTimeKind.Local).AddTicks(8280), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "C:\\Users\\nerme\\full-stack-learning-projects\\DotNetMastery_RESTAPIS\\ASP.NET MVC\\MagicVilla\\MagicVilla_VillaAPI\\Images\\01.jpg", "KOyal Ka Ghosla Villa", 6, 447.0, 700, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
