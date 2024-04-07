using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSku.Migrations
{
    /// <inheritdoc />
    public partial class SupplierAddedFieldSupplierGropu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "supplier_group",
                table: "tabSupplier",
                type: "varchar(255)",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "supplier_group",
                table: "tabSupplier");
        }
    }
}
