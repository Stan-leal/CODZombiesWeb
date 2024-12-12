using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CODZombiesWeb.Models;

namespace CODZombiesWeb.Pages_Maps
{
    public class CreateModel : PageModel
    {
        private readonly CODZombiesWeb.Models.AppDbContext _context;

        public CreateModel(CODZombiesWeb.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Map Map { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Maps.Add(Map);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
