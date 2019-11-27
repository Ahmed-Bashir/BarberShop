using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberShop.Migrations
{
    public partial class addCustomerFKeyToBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomersId",
                table: "Bookings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomersId",
                table: "Bookings",
                column: "CustomersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Customers_CustomersId",
                table: "Bookings",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Customers_CustomersId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_CustomersId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CustomersId",
                table: "Bookings");
        }
    }
}
