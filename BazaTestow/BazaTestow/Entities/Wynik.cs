using System.ComponentModel.DataAnnotations;

namespace BazaTestow.Entities
{
    public class Wynik
    {
        [Key]
        public int IDwyniku { get; set; }
        public int IDtestu { get; set; }
        public int IDucznia { get; set; }
        [Required]
        public int WynikPunktowy { get; set; }
        public DateTime? DataUzyskania { get; set; }
        public Uczen? Uczen { get; set; } 
        public Test? Test { get; set; } 
    }
}