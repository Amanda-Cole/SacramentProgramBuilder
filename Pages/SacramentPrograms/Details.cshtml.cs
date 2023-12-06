using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentProgramBuilder.Data;
using SacramentProgramBuilder.Models;

namespace SacramentProgramBuilder.Pages.SacramentPrograms
{
    public class DetailsModel : PageModel
    {
        private readonly SacramentProgramBuilder.Data.SacramentProgramBuilderContext _context;

        public DetailsModel(SacramentProgramBuilder.Data.SacramentProgramBuilderContext context)
        {
            _context = context;
        }

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
            else
            {
                SacramentProgram = sacramentprogram;
            }
            return Page();
        }
    }
}
