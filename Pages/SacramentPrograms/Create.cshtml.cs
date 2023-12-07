using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SacramentProgramBuilder.Data;
using SacramentProgramBuilder.Models;

namespace SacramentProgramBuilder.Pages.SacramentPrograms
{
    public class CreateModel : PageModel
    {
        private readonly SacramentProgramBuilderContext _context;

        public CreateModel(SacramentProgramBuilderContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SacramentProgram SacramentProgram { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.SacramentProgram == null || SacramentProgram == null)
            {
                return Page();
            }

            _context.SacramentProgram.Add(SacramentProgram);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
