using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSku.Migrations
{
    /// <inheritdoc />
    public partial class FieldsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Users",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.AddColumn<DateTime>(
                name: "creation",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "Users",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "full_name",
                table: "Users",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "last_name",
                table: "Users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "modified",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                table: "Users",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "owner",
                table: "Users",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "creation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "first_name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "full_name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "last_name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "modified",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "modified_by",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "owner",
                table: "Users");

            migrationBuilder.AlterColumn<Guid>(
                name: "name",
                table: "Users",
                type: "char(36)",
                nullable: false,
                collation: "utf8mb4_general_ci",
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
