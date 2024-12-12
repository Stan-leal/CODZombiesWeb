using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CODZombiesWeb.Models;

namespace CODZombiesWeb.Pages_Maps
{
    public class EditModel : PageModel
    {
        private readonly CODZombiesWeb.Models.AppDbContext _context;

        public EditModel(CODZombiesWeb.Models.AppDbContext context)
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

            var map =  await _context.Maps.FirstOrDefaultAsync(m => m.MapID == id);
            if (map == null)
            {
                return NotFound();
            }
            Map = map;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Map).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapExists(Map.MapID))
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

        private bool MapExists(int id)
        {
            return _context.Maps.Any(e => e.MapID == id);
        }
    }
}
