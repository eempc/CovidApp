using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CovidApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CovidApp
{
    public class MapModel : PageModel
    {
        private readonly CovidApp.Data.CovidAppContext _context;
        private readonly IWebHostEnvironment _env;

        public string testDir;
        public IEnumerable<string> contents;

        public IList<AccessionRecord> Records { get; set; }
        public AccessionRecord ReferenceStrain { get; set; }

        public MapModel(CovidApp.Data.CovidAppContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
            testDir = _env.ContentRootPath;
            contents = Directory.EnumerateDirectories(testDir);
        }

        public void OnGet()
        {
            Records = _context.AccessionRecord.ToList();
            ReferenceStrain = Records.Single(x => x.Id == -1);
        }
    }
}