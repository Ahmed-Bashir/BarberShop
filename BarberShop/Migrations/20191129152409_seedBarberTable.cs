using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberShop.Migrations
{
    public partial class seedBarberTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Barbers",
                columns: new[] { "Id", "Name", "Number", "Shop" },
                values: new object[] { 1, "Kabrone", 78, "Brixton" });

            migrationBuilder.InsertData(
                table: "Barbers",
                columns: new[] { "Id", "Name", "Number", "Shop" },
                values: new object[] { 2, "Andre", 208, "Stockwell" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
