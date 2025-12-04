using cinematicketBackend.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinematicketBackend.Models
{
    public class Bilet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SeansId { get; set; }
        public Seans? Seans { get; set; }

        [Required]
        public int NumerMiejsca { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}