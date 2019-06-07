using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class MapeamentoTabelas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Grupo_GrupoID",
                table: "Postagens");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupos_Grupo_GrupoId",
                table: "UsuarioGrupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grupo",
                table: "Grupo");

            migrationBuilder.RenameTable(
                name: "Grupo",
                newName: "Grupos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grupos",
                table: "Grupos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Grupos_GrupoID",
                table: "Postagens",
                column: "GrupoID",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupos_Grupos_GrupoId",
                table: "UsuarioGrupos",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Grupos_GrupoID",
                table: "Postagens");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupos_Grupos_GrupoId",
                table: "UsuarioGrupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grupos",
                table: "Grupos");

            migrationBuilder.RenameTable(
                name: "Grupos",
                newName: "Grupo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grupo",
                table: "Grupo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Grupo_GrupoID",
                table: "Postagens",
                column: "GrupoID",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupos_Grupo_GrupoId",
                table: "UsuarioGrupos",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
