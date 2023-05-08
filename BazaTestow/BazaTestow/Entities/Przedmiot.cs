using System.ComponentModel.DataAnnotations;

namespace BazaTestow.Entities
{
    public class Przedmiot
    {
        [Key]
        public int IDprzedmiotu { get; set; }
        [Required]
        [MaxLength(50)]
        public string NazwaPrzedmiotu { get; set; }
        [MaxLength]
        public string? OpisPrzedmiotu { get; set; }
        public ICollection<PrzedmiotNauczyciel>? PrzedmiotyNauczyciele { get; set; }
        public ICollection<Test>? Testy { get; set; }
    }
}