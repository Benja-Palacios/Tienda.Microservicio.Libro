using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tienda.Microservicio.Libro.Migrations
{
    /// <inheritdoc />
    public partial class AddBD_LibroV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "LibreriaMaterial",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Precio",
                table: "LibreriaMaterial",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "LibreriaMaterial");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "LibreriaMaterial");
        }
    }
}
