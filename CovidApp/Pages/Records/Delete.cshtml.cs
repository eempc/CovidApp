using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CovidApp.Data;
using CovidApp.Models;

namespace CovidApp
{
    public class DeleteModel : PageModel
    {
        private readonly CovidApp.Data.CovidAppContext _context;

        public DeleteModel(CovidApp.Data.CovidAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AccessionRecord AccessionRecord { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AccessionRecord = await _context.AccessionRecord.FirstOrDefaultAsync(m => m.Id == id);

            if (AccessionRecord == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AccessionRecord = await _context.AccessionRecord.FindAsync(id);

            if (AccessionRecord != null)
            {
                _context.AccessionRecord.Remove(AccessionRecord);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
