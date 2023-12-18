using BookEtCafe.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookEtCafe.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTabelaDadosIniciaisEditora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new BookEtCafeDbContext();
            context.Editora.AddRange(ObterCargaInicialEditora());
            context.SaveChanges();
        }

        private IList<Editora> ObterCargaInicialEditora()
        {
            return new List<Editora>()
            {
                new Editora() {EditoraNome = "Globo Livros"},
                new Editora() {EditoraNome = "Intrínseca"},
                new Editora() {EditoraNome = "L&PM"}
            };
        }
    }
}
