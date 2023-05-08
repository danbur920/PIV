using System.ComponentModel.DataAnnotations;

namespace BazaTestow.Entities
{
    public class Odpowiedz
    {
        [Key]
        public int IDodpowiedzi { get; set; }
        public int IDpytania { get; set; }
        public int IDucznia { get; set; }
        [MaxLength]
        public string? OdpowiedzUcznia { get; set; }
        public TimeSpan? CzasUdzielaniaOdpowiedzi { get; set; }
        public float? IloscPunktow { get; set; }
        public Pytanie? Pytanie { get; set; }
        public Uczen? Uczen { get; set; }
    }
}