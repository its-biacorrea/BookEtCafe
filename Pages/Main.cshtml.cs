using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookEtCafe.Services;

namespace BookEtCafe.Pages;

public class MainModel : PageModel
{
    private ILivroService _service;
    public MainModel(ILivroService service)
    {
        _service = service;
    }

    public IList<Livro> ListaLivros { get; private set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home page";

        ListaLivros = _service.ObterTodos();
    }

}
