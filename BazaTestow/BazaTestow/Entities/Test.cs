using System.ComponentModel.DataAnnotations;
using System.Timers;

namespace BazaTestow.Entities
{
    public class Test
    {
        [Key]
        public int IDtestu { get; set; }
        public int IDprzedmiotu { get; set; }
        [MaxLength(100)]
        public string? NazwaTestu { get; set; }
        public DateTime? DataUtworzenia { get; set; }
        public TimeSpan? CzasTrwania { get; set; }
        public int? LiczbaPytan { get; set; }
        public Przedmiot? Przedmiot { get; set; }
        public ICollection<Pytanie>? Pytania { get; set; }
        public ICollection<Wynik>? Wyniki { get; set; }
    }
}