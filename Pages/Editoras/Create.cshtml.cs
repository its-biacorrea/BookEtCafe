using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookEtCafe.Data;
using BookEtCafe.Models;

namespace BookEtCafe.Pages.Editoras
{
    public class CreateModel : PageModel
    {
        private readonly BookEtCafe.Data.BookEtCafeDbContext _context;

        public CreateModel(BookEtCafe.Data.BookEtCafeDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Editora Editora { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Editora == null || Editora == null)
            {
                return Page();
            }

            _context.Editora.Add(Editora);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
