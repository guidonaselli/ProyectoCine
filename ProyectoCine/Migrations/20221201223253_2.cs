using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoCine.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fila",
                table: "entradas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Horario",
                table: "entradas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombrePelicula",
                table: "entradas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreYApellido",
                table: "entradas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Horario",
                table: "entradas");

            migrationBuilder.DropColumn(
                name: "NombrePelicula",
                table: "entradas");

            migrationBuilder.DropColumn(
                name: "NombreYApellido",
                table: "entradas");

            migrationBuilder.AlterColumn<int>(
                name: "Fila",
                table: "entradas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
