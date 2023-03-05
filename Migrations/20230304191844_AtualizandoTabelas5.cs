using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory_Control.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoTabelas5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Client",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Seller",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "ProductsToSales");

            migrationBuilder.DropColumn(
                name: "Sale",
                table: "ProductsToSales");

            migrationBuilder.DropColumn(
                name: "Seller",
                table: "ProductsToSales");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductsToSales",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "ProductsToSales",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "ProductsToSales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ClientId",
                table: "Sales",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SellerId",
                table: "Sales",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsToSales_ProductId",
                table: "ProductsToSales",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsToSales_SaleId",
                table: "ProductsToSales",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsToSales_SellerId",
                table: "ProductsToSales",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsToSales_Products_ProductId",
                table: "ProductsToSales",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsToSales_Sales_SaleId",
                table: "ProductsToSales",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsToSales_Sellers_SellerId",
                table: "ProductsToSales",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Clients_ClientId",
                table: "Sales",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Sellers_SellerId",
                table: "Sales",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsToSales_Products_ProductId",
                table: "ProductsToSales");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsToSales_Sales_SaleId",
                table: "ProductsToSales");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsToSales_Sellers_SellerId",
                table: "ProductsToSales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Clients_ClientId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Sellers_SellerId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ClientId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_SellerId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_ProductsToSales_ProductId",
                table: "ProductsToSales");

            migrationBuilder.DropIndex(
                name: "IX_ProductsToSales_SaleId",
                table: "ProductsToSales");

            migrationBuilder.DropIndex(
                name: "IX_ProductsToSales_SellerId",
                table: "ProductsToSales");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductsToSales");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "ProductsToSales");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "ProductsToSales");

            migrationBuilder.AddColumn<int>(
                name: "Client",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Seller",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Product",
                table: "ProductsToSales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sale",
                table: "ProductsToSales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Seller",
                table: "ProductsToSales",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
