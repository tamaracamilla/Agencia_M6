using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAgencia.Migrations
{
    public partial class AtualizaUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "Id_Usuario",
                table: "id_usuario");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "usuario");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "id_usuario",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "id_usuario",
                newName: "senha");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "id_usuario",
                newName: "Login");

            migrationBuilder.AddPrimaryKey(
                name: "Id_Usuario",
                table: "id_usuario",
                column: "id_usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "Id_Usuario",
                table: "id_usuario");


            migrationBuilder.RenameColumn(
                name: "nome",
                table: "id_usuario",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "senha",
                table: "id_usuario",
                newName: "Senha");
                
            migrationBuilder.RenameColumn(
                name: "Login",
                table: "id_usuario",
                newName: "Login");

            migrationBuilder.AddPrimaryKey(
                name: "Id_Usuarios",
                table: "id_usuario",
                column: "Id_Usuario");
        }
    }
}