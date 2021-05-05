using Microsoft.EntityFrameworkCore.Migrations;

namespace vFoodApi.Migrations
{
    public partial class vFoods2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Merchants_MerchantId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "MerchantId",
                table: "Orders",
                newName: "BusinessId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_MerchantId",
                table: "Orders",
                newName: "IX_Orders_BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Businesses_BusinessId",
                table: "Orders",
                column: "BusinessId",
                principalTable: "Businesses",
                principalColumn: "BussinessId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Businesses_BusinessId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "BusinessId",
                table: "Orders",
                newName: "MerchantId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_BusinessId",
                table: "Orders",
                newName: "IX_Orders_MerchantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Merchants_MerchantId",
                table: "Orders",
                column: "MerchantId",
                principalTable: "Merchants",
                principalColumn: "MerchantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
