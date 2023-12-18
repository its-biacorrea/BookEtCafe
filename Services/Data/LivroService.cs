using BookEtCafe.Data;
using BookEtCafe.Models;
using System;

namespace BookEtCafe.Services.Data;
public class LivroService : ILivroService
{
    private BookEtCafeDbContext _context;
    public LivroService(BookEtCafeDbContext context)
    {
        _context = context;
    }
    public IList<Livro> ObterTodos()
    {
        return _context.Livro.ToList();
    }
    public Livro Obter(int id)
    {
        return _context.Livro.SingleOrDefault(item => item.LivroId == id);
    }
    public void Incluir(Livro livro)
    {
        _context.Livro.Add(livro);
        _context.SaveChanges();
    }
    public void Alterar(Livro livro)
    {
        var livroEncontrado = Obter(livro.LivroId);
        livroEncontrado.Nome = livro.Nome;
        livroEncontrado.Sinopse = livro.Sinopse;
        livroEncontrado.ImagemUri = livro.ImagemUri;
        livroEncontrado.Preco = livro.Preco;
        livroEncontrado.Disponivel = livro.Disponivel;
        livroEncontrado.DataDeEntrega = livro.DataDeEntrega;
        _context.SaveChanges();
    }
    public void Excluir(int id)
    {
        var livroEncontrado = Obter(id);
        _context.Livro.Remove(livroEncontrado);
        _context.SaveChanges();
    }

    public IList<Editora> ObterTodasEditoras() => _context.Editora.ToList();
}