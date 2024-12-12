using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CODZombiesWeb.Models;

namespace CODZombiesWeb.Pages_Maps
{
    public class IndexModel : PageModel
    {
        private readonly CODZombiesWeb.Models.AppDbContext _context;

        public IndexModel(CODZombiesWeb.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Map> Map { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string CurrentSearch { get; set; } = string.Empty;

        public async Task OnGetAsync()
        {
            var query = _context.Maps.AsQueryable(); 

           
            if (!string.IsNullOrEmpty(CurrentSearch))
            {
                query = query.Where(m => m.MapName.Contains(CurrentSearch));
            }

            Map = await query.ToListAsync(); 
        }
    }
}
