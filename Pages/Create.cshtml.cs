using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookEtCafe.Services;
using BookEtCafe.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace BookEtCafe.Pages;

[Authorize]
public class CreateModel : PageModel
{
    public SelectList EditoraOptionItems { get; set; }
    private ILivroService _service;
    public CreateModel(ILivroService service)
    {
        _service = service;
    }

    public void OnGet()
    {
        EditoraOptionItems = new SelectList(_service.ObterTodasEditoras(),
        nameof(Editora.EditoraId),
        nameof(Editora.EditoraNome));
    }

    [BindProperty]
    public Livro Livro { get; set; }
    
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _service.Incluir(Livro);

        return RedirectToPage("/Main");
    }
}
