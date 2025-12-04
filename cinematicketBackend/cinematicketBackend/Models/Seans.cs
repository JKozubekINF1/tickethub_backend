using System;

namespace CinematicketBackend.Models
{
    public class Seans
    {
        public int Id { get; set; }

        public int SalaId { get; set; }  
        public Sala? Sala { get; set; }  

        public string Miejscowosc { get; set; } 
        public string Tytul { get; set; } = null!;
        public string TypSeansu { get; set; } = null!;
        public DateTime Data { get; set; }
        public string Godzina { get; set; } = null!;
        public string Gatunek { get; set; } = null!;
        public int WiekMin { get; set; }
    }
}
