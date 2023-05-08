using System.ComponentModel.DataAnnotations;

namespace BazaTestow.Entities
{
    public class Uczen
    {
        [Key]
        public int IDucznia { get; set; }
        [Required]
        [MaxLength(50)]
        public string Imie { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nazwisko { get; set; }
        public DateTime? DataUrodzenia { get; set; }
        [MaxLength(80)]
        public string? Email { get; set; }
        [MaxLength(5)]
        public string? Klasa { get; set; }
        [MaxLength(50)]
        public string? Miejscowosc { get; set; }
        [MaxLength(50)]
        public string? Ulica { get; set; }
        [MaxLength(10)]
        public string? NumerDomu { get; set; }
        [MaxLength(15)]
        public string? KodPocztowy { get; set; }
        public ICollection<Wynik>? Wyniki { get; set; }
        public ICollection<Odpowiedz>? Odpowiedzi { get; set; }
    }
}