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
    public class DetailsModel : PageModel
    {
        private readonly CODZombiesWeb.Models.AppDbContext _context;

        public DetailsModel(CODZombiesWeb.Models.AppDbContext context)
        {
            _context = context;
        }

        public Map Map { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var map = await _context.Maps.FirstOrDefaultAsync(m => m.MapID == id);

            if (map is not null)
            {
                Map = map;

                return Page();
            }

            return NotFound();
        }
    }
}
