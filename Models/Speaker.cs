using System.ComponentModel.DataAnnotations;

namespace SacramentProgramBuilder.Models
{
    public class Speaker
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? Name { get; set; }

        [Display(Name = "Speaker Type")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? SpeakerType { get; set; } //Youth speaker, Speaker, or Article of Faith Enum?

        public bool MarkedForDeletion { get; set; }
    }
}
