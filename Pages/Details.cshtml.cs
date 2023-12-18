using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookEtCafe.Services;

namespace BookEtCafe.Pages { 

public class DetailsModel : PageModel
{
        private ILivroService _service;
    public DetailsModel(ILivroService service)
        {
            _service = service;
        }

        public Livro Livro { get; private set; }
    public IActionResult OnGet(int id)
    {
            Livro = _service.Obter(id);

            if(Livro == null)
            {
                return NotFound();
            }

            return Page();
        }
}
}