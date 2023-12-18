using BookEtCafe.Models;
using System;

namespace BookEtCafe.Services { 
public class LivroServiceM
{
        public LivroServiceM() => CarregarListaInicial();

        private IList<Livro> _livros;

        private void CarregarListaInicial()
        {
            _livros = new List<Livro>()
        {
            new Livro
            {
                LivroId = 1,
        Nome = "E não sobrou nenhum",
        Sinopse = "",
        ImagemUri = "/images/ENaoSobrouNenhum.jpg",
        Preco = 45.00,
        Disponivel = true,
        DataDeEntrega = DateTime.Now
    },
            new Livro
            {
                LivroId = 2,
        Nome = "A volta ao mundo em 80 dias",
        Sinopse = "",
        ImagemUri = "/images/AVoltaAoMundoEm80Dias.jpg",
        Preco = 45.00,
        Disponivel = false,
        DataDeEntrega = DateTime.Now
    },
            new Livro
            {
                LivroId = 3,
        Nome = "Mulherzinhas",
        Sinopse = "",
        ImagemUri = "/images/Mulherzinhas.jpg",
        Preco = 45.00,
        Disponivel = true,
        DataDeEntrega = DateTime.Now
    },
            new Livro
            {
                LivroId = 4,
        Nome = "O clube de crimes das quintas-feiras",
        Sinopse = "",
        ImagemUri = "/images/OClubeDeCrimesDasQuintasFeiras.jpg",
        Preco = 45.00,
        Disponivel = true,
        DataDeEntrega = DateTime.Now
    },
            new Livro
            {
                LivroId = 5,
        Nome = "Orgulho e Preconceito",
        Sinopse = "",
        ImagemUri = "/images/OrgulhoEPreconceito.jpg",
        Preco = 45.00,
        Disponivel = false,
        DataDeEntrega = DateTime.Now
    }

    };
        }
	
        public IList<Livro> ObterTodos() => _livros;
    
        public Livro  Obter(int id)
        {
            return ObterTodos().SingleOrDefault(item => item.LivroId == id);
        }

        public void Incluir(Livro livro)
        {
            var proximoId = _livros.Max(item => item.LivroId) + 1;
            livro.LivroId = proximoId;
            _livros.Add(livro);
        }

        public void Alterar(Livro livro) 
        {
            var livroEncontrado = _livros.SingleOrDefault(item => item.LivroId == livro.LivroId);
            livroEncontrado.Nome = livro.Nome;
            livroEncontrado.Sinopse = livro.Sinopse;
            livroEncontrado.ImagemUri = livro.ImagemUri;
            livroEncontrado.Preco = livro.Preco;
            livroEncontrado.Disponivel = livro.Disponivel;
            livroEncontrado.DataDeEntrega = livro.DataDeEntrega;
        }

        public void Excluir(int id)
        {
            var livroEncontrado = Obter(id);
            _livros.Remove(livroEncontrado);
        }

        
    }
}
