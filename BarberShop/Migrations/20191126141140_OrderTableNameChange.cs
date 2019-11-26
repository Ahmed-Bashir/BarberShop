using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberShop.Migrations
{
    public partial class OrderTableNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Barbers_BarbersId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Bookings_BookingsId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customers_CustomersId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Cuts_CutsId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CutsId",
                table: "Orders",
                newName: "IX_Orders_CutsId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomersId",
                table: "Orders",
                newName: "IX_Orders_CustomersId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_BookingsId",
                table: "Orders",
                newName: "IX_Orders_BookingsId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_BarbersId",
                table: "Orders",
                newName: "IX_Orders_BarbersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Barbers_BarbersId",
                table: "Orders",
                column: "BarbersId",
                principalTable: "Barbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Bookings_BookingsId",
                table: "Orders",
                column: "BookingsId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomersId",
                table: "Orders",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cuts_CutsId",
                table: "Orders",
                column: "CutsId",
                principalTable: "Cuts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Barbers_BarbersId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Bookings_BookingsId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomersId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cuts_CutsId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CutsId",
                table: "Order",
                newName: "IX_Order_CutsId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomersId",
                table: "Order",
                newName: "IX_Order_CustomersId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_BookingsId",
                table: "Order",
                newName: "IX_Order_BookingsId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_BarbersId",
                table: "Order",
                newName: "IX_Order_BarbersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Barbers_BarbersId",
                table: "Order",
                column: "BarbersId",
                principalTable: "Barbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Bookings_BookingsId",
                table: "Order",
                column: "BookingsId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customers_CustomersId",
                table: "Order",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Cuts_CutsId",
                table: "Order",
                column: "CutsId",
                principalTable: "Cuts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
