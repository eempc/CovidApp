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
    public class DetailsModel : PageModel
    {
        private readonly CovidApp.Data.CovidAppContext _context;

        public DetailsModel(CovidApp.Data.CovidAppContext context)
        {
            _context = context;
        }

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
    }
}
