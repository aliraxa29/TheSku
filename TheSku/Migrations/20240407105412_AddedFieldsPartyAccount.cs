using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSku.Migrations
{
    /// <inheritdoc />
    public partial class AddedFieldsPartyAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "parenttype",
                table: "tabSupplier",
                newName: "tax_id");

            migrationBuilder.RenameColumn(
                name: "parentfield",
                table: "tabSupplier",
                newName: "supplier_type");

            migrationBuilder.AddColumn<int>(
                name: "block_supplier",
                table: "tabSupplier",
                type: "int(1)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "disabled",
                table: "tabSupplier",
                type: "int(1)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "primary_address",
                table: "tabSupplier",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "primary_contact",
                table: "tabSupplier",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "supplier_details",
                table: "tabSupplier",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tabParty Accuount",
                columns: table => new
                {
                    name = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    creation = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    modified_by = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    owner = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    docstatus = table.Column<int>(type: "int", nullable: false),
                    parent = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    account = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabParty Accuount", x => x.name);
                    table.ForeignKey(
                        name: "FK_tabParty Accuount_tabSupplier_Parent",
                        column: x => x.parent,
                        principalTable: "tabSupplier",
                        principalColumn: "name", onUpdate: ReferentialAction.Cascade, onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tabParty Accuount_Parent",
                table: "tabParty Accuount",
                column: "parent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tabParty Accuount");

            migrationBuilder.DropColumn(
                name: "block_supplier",
                table: "tabSupplier");

            migrationBuilder.DropColumn(
                name: "disabled",
                table: "tabSupplier");

            migrationBuilder.DropColumn(
                name: "primary_address",
                table: "tabSupplier");

            migrationBuilder.DropColumn(
                name: "primary_contact",
                table: "tabSupplier");

            migrationBuilder.DropColumn(
                name: "supplier_details",
                table: "tabSupplier");

            migrationBuilder.RenameColumn(
                name: "tax_id",
                table: "tabSupplier",
                newName: "parenttype");

            migrationBuilder.RenameColumn(
                name: "supplier_type",
                table: "tabSupplier",
                newName: "parentfield");
        }
    }
}
