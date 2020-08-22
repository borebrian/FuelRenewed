using Microsoft.EntityFrameworkCore.Migrations;

namespace Fuela.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pets",
                table: "Pets");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Station_reg");

            migrationBuilder.RenameTable(
                name: "Pets",
                newName: "Station_owners");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Station_reg",
                table: "Station_reg",
                column: "Station_ref");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Station_owners",
                table: "Station_owners",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Station_reg",
                table: "Station_reg");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Station_owners",
                table: "Station_owners");

            migrationBuilder.RenameTable(
                name: "Station_reg",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Station_owners",
                newName: "Pets");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Station_ref");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pets",
                table: "Pets",
                column: "ID");
        }
    }
}
