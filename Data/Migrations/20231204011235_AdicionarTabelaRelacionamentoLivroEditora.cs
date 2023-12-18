using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookEtCafe.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTabelaRelacionamentoLivroEditora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EditoraId",
                table: "Livro",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livro_EditoraId",
                table: "Livro",
                column: "EditoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Editora_EditoraId",
                table: "Livro",
                column: "EditoraId",
                principalTable: "Editora",
                principalColumn: "EditoraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Editora_EditoraId",
                table: "Livro");

            migrationBuilder.DropIndex(
                name: "IX_Livro_EditoraId",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "EditoraId",
                table: "Livro");
        }
    }
}
