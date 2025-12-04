using System.ComponentModel.DataAnnotations;

namespace CinematicketBackend.Models
{
    public class Sala
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nazwa { get; set; } = null!;  

        [Required]
        public int LiczbaMiejsc { get; set; }

        public ICollection<Seans>? Seanse { get; set; }
    }
}
