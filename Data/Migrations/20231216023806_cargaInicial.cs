using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookEtCafe.Data.Migrations
{
    /// <inheritdoc />
    public partial class cargaInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "LivroId", "Nome", "Sinopse", "ImagemUri", "Preco", "Disponivel", "DataDeEntrega" },
                values: new object[,]
                {
                    { 1, "E não sobrou nenhum", "", "/images/ENaoSobrouNenhum.jpg", 45.00, true, DateTime.Now },
                    { 2, "A volta ao mundo em 80 dias", "", "/images/AVoltaAoMundoEm80Dias.jpg", 45.00, false, DateTime.Now },
                    { 3, "Mulherzinhas", "", "/images/Mulherzinhas.jpg", 45.00, true, DateTime.Now },
                    { 4, "O clube de crimes das quintas-feiras", "", "/images/OClubeDeCrimesDasQuintasFeiras.jpg", 45.00, true, DateTime.Now },
                    { 5, "Orgulho e Preconceito", "", "/images/OrgulhoEPreconceito.jpg", 45.00, false, DateTime.Now }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
