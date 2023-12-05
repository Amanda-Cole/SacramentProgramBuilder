using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacramentProgramBuilder.Models;

namespace SacramentProgramBuilder.Data
{
    public class SacramentProgramBuilderContext : DbContext
    {
        public SacramentProgramBuilderContext (DbContextOptions<SacramentProgramBuilderContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentProgramBuilder.Models.SacramentProgram> SacramentProgram { get; set; } = default!;
    }
}
