using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemasRafa.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "ID",
                keyValue: 3,
                column: "Controller",
                value: "Worker");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Controller", "Label" },
                values: new object[] { "Customer", "Customer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Peliculas");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "ID",
                keyValue: 3,
                column: "Controller",
                value: "Workers");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Controller", "Label" },
                values: new object[] { "Customers", "Customers" });
        }
    }
}
