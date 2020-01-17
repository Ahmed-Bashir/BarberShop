using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberShop.Migrations
{
    public partial class populateSeedCutsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cuts",
                columns: new[] { "Id", "Cuts", "Price" },
                values: new object[,]
                {
                    { 1, "Regular Cut", 15 },
                    { 2, "Childrens Cut", 6 },
                    { 3, "Beard Trim", 5 },
                    { 4, "Mustache Trim", 3 },
                    { 5, "Shape Ups", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cuts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cuts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cuts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cuts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cuts",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
