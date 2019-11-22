using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberShop.Migrations
{
    public partial class JoinCustomerAndMenuToBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "CustomerId",
                table: "Bookings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "Bookings",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cut = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_MenuId",
                table: "Bookings",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Customers_CustomerId",
                table: "Bookings",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Menu_MenuId",
                table: "Bookings",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Customers_CustomerId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Menu_MenuId",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_MenuId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Bookings");
        }
    }
}
