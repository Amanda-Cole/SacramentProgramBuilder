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
    public class IndexModel : PageModel
    {
        private readonly SacramentProgramBuilder.Data.SacramentProgramBuilderContext _context;

        public IndexModel(SacramentProgramBuilder.Data.SacramentProgramBuilderContext context)
        {
            _context = context;
        }

        public IList<SacramentProgram> SacramentProgram { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.SacramentProgram != null)
            {
                SacramentProgram = await _context.SacramentProgram.ToListAsync();
            }
        }
    }
}
