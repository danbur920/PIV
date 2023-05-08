using System.ComponentModel.DataAnnotations;

namespace BazaTestow.Entities
{
    public class Pytanie
    {
        [Key]
        public int IDpytania { get; set; }
        public int IDtestu { get; set; }
        [Required]
        [MaxLength(500)]
        public string TrescPytania { get; set; }
        [MaxLength]
        public string? OpcjeOdpowiedzi { get; set; }
        [MaxLength(20)]
        public string? RodzajPytania { get; set; }
        public float? MaksymalnaIloscPunktow { get; set; }
        [MaxLength(500)]
        public string? PrawidlowaOdpowiedz { get; set; }
        public Test? Test { get; set; }
        public ICollection<Odpowiedz>? Odpowiedzi { get; set; }
    }
}