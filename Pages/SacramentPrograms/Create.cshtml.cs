﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacramentProgramBuilder.Data;
using SacramentProgramBuilder.Models;

namespace SacramentProgramBuilder.Pages.SacramentPrograms
{
    public class CreateModel : PageModel
    {
        private readonly SacramentProgramBuilder.Data.SacramentProgramBuilderContext _context;

        public CreateModel(SacramentProgramBuilder.Data.SacramentProgramBuilderContext context)
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

            // Add speakers to the SacramentProgram
            foreach (var speaker in SacramentProgram.Speakers)
            {
                // You might want to add validation or additional processing here
            }

            _context.SacramentProgram.Add(SacramentProgram);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}