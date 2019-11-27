using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberShop.Migrations
{
    public partial class removeBookingsId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Bookings_BookingsId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_BookingsId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BookingsId",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingsId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookingsId",
                table: "Orders",
                column: "BookingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Bookings_BookingsId",
                table: "Orders",
                column: "BookingsId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
