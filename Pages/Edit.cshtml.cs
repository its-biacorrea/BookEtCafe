using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookEtCafe.Services;
using BookEtCafe.Models;
using Microsoft.AspNetCore.Authorization;

namespace BookEtCafe.Pages;

[Authorize]
public class EditModel : PageModel
{
    public SelectList EditoraOptionItems { get; set; }
    private ILivroService _service;
    public EditModel(ILivroService service)
    {
        _service = service;
    }

    
    [BindProperty]
       public Livro Livro { get; set; }

    public IActionResult OnGet(int id)
    {
        Livro = _service.Obter(id);
        EditoraOptionItems = new SelectList(_service.ObterTodasEditoras(),
        nameof(Editora.EditoraId),
        nameof(Editora.EditoraNome));
        if (Livro == null)
        {
            return NotFound();
        }

        return Page();
    }
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _service.Alterar(Livro);

        return RedirectToPage("/Main");
    }
    public IActionResult OnPostExclusao()
    {
        _service.Excluir(Livro.LivroId);

        return RedirectToPage("/Main");
    }
}
