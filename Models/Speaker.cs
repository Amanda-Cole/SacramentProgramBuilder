using System.ComponentModel.DataAnnotations;

namespace SacramentProgramBuilder.Models
{
    public class Speaker
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Speaker Type")]
        public string? SpeakerType { get; set; } //Youth speaker, Speaker, or Article of Faith Enum?
    }
}
