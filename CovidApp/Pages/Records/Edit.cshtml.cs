using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CovidApp.Data;
using CovidApp.Models;

namespace CovidApp
{
    public class EditModel : PageModel
    {
        private readonly CovidApp.Data.CovidAppContext _context;

        public EditModel(CovidApp.Data.CovidAppContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AccessionRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccessionRecordExists(AccessionRecord.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AccessionRecordExists(int id)
        {
            return _context.AccessionRecord.Any(e => e.Id == id);
        }
    }
}
