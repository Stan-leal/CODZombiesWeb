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
    public class DeleteModel : PageModel
    {
        private readonly CODZombiesWeb.Models.AppDbContext _context;

        public DeleteModel(CODZombiesWeb.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var map = await _context.Maps.FindAsync(id);
            if (map != null)
            {
                Map = map;
                _context.Maps.Remove(Map);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
