using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CovidApp.Data;
using CovidApp.Models;

namespace CovidApp
{
    public class CreateModel : PageModel
    {
        private readonly CovidApp.Data.CovidAppContext _context;

        public CreateModel(CovidApp.Data.CovidAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AccessionRecord AccessionRecord { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AccessionRecord.Add(AccessionRecord);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
