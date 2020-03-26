using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CovidApp
{
    public class MapModel : PageModel
    {
        private readonly CovidApp.Data.CovidAppContext _context;

        public MapModel(CovidApp.Data.CovidAppContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }
    }
}