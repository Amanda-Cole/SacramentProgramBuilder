using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentProgramBuilder.Data;
using SacramentProgramBuilder.Models;

namespace SacramentProgramBuilder.Pages.SacramentPrograms
{
    public class EditModel : PageModel
    {
        private readonly SacramentProgramBuilderContext _context;

        public EditModel(SacramentProgramBuilderContext context)
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

            _context.Attach(SacramentProgram).State = EntityState.Modified;

            try
            {
                var speakersToRemove = SacramentProgram.Speakers.Where(speaker => speaker.MarkedForDeletion).ToList();

                if (speakersToRemove.Count > 0)
                {
                    foreach (var speaker in speakersToRemove)
                    {
                        var speakerToRemove = _context.Speaker.Find(speaker.Id);
                        if (speakerToRemove != null)
                        {
                            _context.Speaker.Remove(speakerToRemove);
                        }
                    }
                }

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
