using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory_Control.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoTabelas7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatioDate",
                table: "Sellers",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "CreatioDate",
                table: "Sales",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "CreatioDate",
                table: "ProductsToSales",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "CreatioDate",
                table: "Products",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "CreatioDate",
                table: "Clients",
                newName: "CreationDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Sellers",
                newName: "CreatioDate");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Sales",
                newName: "CreatioDate");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "ProductsToSales",
                newName: "CreatioDate");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Products",
                newName: "CreatioDate");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Clients",
                newName: "CreatioDate");
        }
    }
}
