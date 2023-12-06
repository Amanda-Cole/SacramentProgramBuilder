using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentProgramBuilder.Data;
using SacramentProgramBuilder.Models;

namespace SacramentProgramBuilder.Pages.SacramentPrograms
{
    public class EditModel : PageModel
    {
        private readonly SacramentProgramBuilder.Data.SacramentProgramBuilderContext _context;

        public EditModel(SacramentProgramBuilder.Data.SacramentProgramBuilderContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SacramentProgram SacramentProgram { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.SacramentProgram == null)
            {
                return NotFound();
            }

            var sacramentprogram = await _context.SacramentProgram
                .Include(s => s.Speakers)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sacramentprogram == null)
            {
                return NotFound();
            }
            SacramentProgram = sacramentprogram;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            SacramentProgram.Speakers.RemoveAll(speaker => speaker.Name == "DELETED");

            _context.Attach(SacramentProgram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SacramentProgramExists(SacramentProgram.Id))
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

        private bool SacramentProgramExists(int id)
        {
            return (_context.SacramentProgram?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
