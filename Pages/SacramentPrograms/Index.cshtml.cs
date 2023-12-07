using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentProgramBuilder.Data;
using SacramentProgramBuilder.Models;

namespace SacramentProgramBuilder.Pages.SacramentPrograms
{
    public class IndexModel : PageModel
    {
        private readonly SacramentProgramBuilderContext _context;

        public IndexModel(SacramentProgramBuilderContext context)
        {
            _context = context;
        }

        public IList<SacramentProgram> SacramentProgram { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.SacramentProgram != null)
            {
                SacramentProgram = await _context.SacramentProgram
                    .OrderBy(sp => sp.ProgramDate)
                    .ToListAsync();
            }
        }
    }
}
