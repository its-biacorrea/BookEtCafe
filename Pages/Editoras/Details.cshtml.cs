using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookEtCafe.Data;
using BookEtCafe.Models;

namespace BookEtCafe.Pages.Editoras
{
    public class DetailsModel : PageModel
    {
        private readonly BookEtCafe.Data.BookEtCafeDbContext _context;

        public DetailsModel(BookEtCafe.Data.BookEtCafeDbContext context)
        {
            _context = context;
        }

      public Editora Editora { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Editora == null)
            {
                return NotFound();
            }

            var editora = await _context.Editora.FirstOrDefaultAsync(m => m.EditoraId == id);
            if (editora == null)
            {
                return NotFound();
            }
            else 
            {
                Editora = editora;
            }
            return Page();
        }
    }
}
