using System.ComponentModel.DataAnnotations;

namespace BazaTestow.Entities
{
    public class Nauczyciel
    {
        [Key]
        public int IDnauczyciela { get; set; }
        [Required]
        [MaxLength(50)]
        public string Imie { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nazwisko { get; set; }
        [MaxLength(80)]
        public string? Email { get; set; }
        [MaxLength(5)]
        public string? WychowawcaKlasy { get; set; }
        [MaxLength(50)]
        public string? Miejscowosc { get; set; }
        [MaxLength(50)]
        public string? Ulica { get; set; }
        [MaxLength(10)]
        public string? NumerDomu { get; set; }
        [MaxLength(15)]
        public string? KodPocztowy { get; set; }
        public ICollection<PrzedmiotNauczyciel>? PrzedmiotyNauczyciele { get; set; }
    }
}