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
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? PresidingName { get; set; }

        [Display(Name ="Conducting")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? ConductingName { get; set; }

        [Display(Name ="Invocation")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? OpeningPrayerName { get; set; }

        [Display(Name ="Opening Hymn")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? OpeningHymnName { get; set; }

        [Display(Name = "Page")]
        [Required]
        [Range(1,341)]
        public int? OpeningHymnNum { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? SacramentHymnName { get; set; }

        [Display(Name = "Page")]
        [Required]
        [Range(1, 341)]
        public int? SacramentHymnNum { get; set; }

        [Display(Name = "Speaker Type")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? SpeakerType { get; set; } //Youth speaker, Speaker, or Article of Faith Enum?

        [Display(Name = "Speaker")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? SpeakerName { get; set; }

        [Display(Name = "Special Musical Number")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? SpecialMusicalNumber { get; set; }//choir Name or musical quest name

        [Display(Name = "Intermediate Hymn")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? IntermediateHymnName { get; set; }

        [Display(Name = "Page")]
        [Range(1, 341)]
        public int? IntermediateHymnNum { get; set; }

        [Display(Name = "Closing Prayer")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? ClosingPrayerName { get; set; }

        [Display(Name = "Closing Hymn")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? ClosingHymnName { get; set; }

        [Display(Name = "Page")]
        [Required]
        [Range(1, 341)]
        public int? ClosingHymnNum { get; set; }

    }
}

