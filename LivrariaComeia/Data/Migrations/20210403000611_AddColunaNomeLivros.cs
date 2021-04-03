using Microsoft.EntityFrameworkCore.Migrations;

namespace LivrariaComeia.Data.Migrations
{
    public partial class AddColunaNomeLivros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Livros");
        }
    }
}
