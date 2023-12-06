using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentProgramBuilder.Models
{
    public class SacramentProgram
    {
        public int Id { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime ProgramDate { get; set; }

        [Display(Name = "Presiding")]
        public string? PresidingName { get; set; }

        [Display(Name = "Conducting")]
        public string? ConductingName { get; set; }

        [Display(Name = "Invocation")]
        public string? OpeningPrayerName { get; set; }

        [Display(Name = "Opening Hymn")]
        public string? OpeningHymnName { get; set; }
        [Display(Name = "Page")]
        public int? OpeningHymnNum { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public string? SacramentHymnName { get; set; }

        [Display(Name = "Page")]
        public int? SacramentHymnNum { get; set; }

        [Display(Name = "Speaker")]
        public List<Speaker> Speakers { get; set; } = new List<Speaker>();

        [Display(Name = "Special Musical Number")]
        public string? SpecialMusicalNumber { get; set; }//choir Name or musical quest name

        [Display(Name = "Intermediate Hymn")]
        public string? IntermediateHymnName { get; set; }

        [Display(Name = "Page")]
        public int? IntermediateHymnNum { get; set; }

        [Display(Name = "Closing Prayer")]
        public string? ClosingPrayerName { get; set; }

        [Display(Name = "Closing Hymn")]
        public string? ClosingHymnName { get; set; }

        [Display(Name = "Page")]
        public int? ClosingHymnNum { get; set; }

    }
}

