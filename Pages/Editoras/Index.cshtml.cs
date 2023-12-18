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
    public class IndexModel : PageModel
    {
        private readonly BookEtCafe.Data.BookEtCafeDbContext _context;

        public IndexModel(BookEtCafe.Data.BookEtCafeDbContext context)
        {
            _context = context;
        }

        public IList<Editora> Editora { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Editora != null)
            {
                Editora = await _context.Editora.ToListAsync();
            }
        }
    }
}
