using Microsoft.EntityFrameworkCore;
using SacramentProgramBuilder.Data;

namespace SacramentProgramBuilder.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SacramentProgramBuilderContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<SacramentProgramBuilderContext>>()))
        {
            if (context == null || context.SacramentProgram == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            if (context.SacramentProgram.Any())
            {
                return;   // DB has been seeded
            }

            context.SacramentProgram.AddRange(
                new SacramentProgram
                {
                    ProgramDate = DateTime.Parse("2023-10-29"),
                    PresidingName = "Bishop Brian Hebdon",
                    ConductingName = "Bishop Brian Hebdon",
                    OpeningPrayerName = "Amanda Cole",
                    OpeningHymnName = "I am a Child of God",
                    OpeningHymnNum = 301,
                    SacramentHymnName = "Upon the cross of Calvary",
                    SacramentHymnNum = 199,
                    Speakers = new List<Speaker>
                        {
                            new Speaker {
                                Name = "Austin Cole",
                                SpeakerType = "Speaker"
                            },
                        },
                    IntermediateHymnName = "Put your Shoulder to the Wheel",
                    IntermediateHymnNum = 84,
                    ClosingPrayerName = "Sarah Lewis",
                    ClosingHymnName = "Follow the Prophet",
                    ClosingHymnNum = 64

                },

                new SacramentProgram
                {
                    ProgramDate = DateTime.Parse("2023-12-3"),
                    PresidingName = "Bishop Brian Hebdon",
                    ConductingName = "Brother Bruce Allen",
                    OpeningPrayerName = "Stephanie Lewis",
                    OpeningHymnName = "O Come all ye faithful",
                    OpeningHymnNum = 298,
                    SacramentHymnName = "I know that my Redeemer Lives",
                    SacramentHymnNum = 197,
                    Speakers = new List<Speaker>
                        {
                            new Speaker {
                                Name = "Justin Lewis",
                                SpeakerType = "Speaker"
                            },
                        },
                    IntermediateHymnName = "Joy to the world",
                    IntermediateHymnNum = 325,
                    ClosingPrayerName = "James Larsen",
                    ClosingHymnName = "Silent Night",
                    ClosingHymnNum = 326
                }
            );
            context.SaveChanges();
        }
    }
}


