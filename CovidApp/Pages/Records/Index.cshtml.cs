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
    public class IndexModel : PageModel
    {
        private readonly CovidApp.Data.CovidAppContext _context;

        public IndexModel(CovidApp.Data.CovidAppContext context)
        {
            _context = context;
        }

        public IList<AccessionRecord> AccessionRecord { get;set; }

        public async Task OnGetAsync()
        {
            AccessionRecord = await _context.AccessionRecord.ToListAsync();
        }
    }
}
