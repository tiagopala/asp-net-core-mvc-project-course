using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCore.Site.Migrations
{
    public partial class AlunosEmailRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Alunos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Alunos",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
