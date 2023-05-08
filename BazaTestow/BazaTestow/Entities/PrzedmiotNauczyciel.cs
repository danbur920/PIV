using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaTestow.Entities
{
    //Tabela pośrednicząca pomiędzy encjami Przedmiot oraz Nauczyciel. Umożliwia to stworzenie relacji N:N. Przykłady:

    // 1) IDprzedmiotu = 1, IDnauczyciele = 1 2) IDprzedmiotu = 1, IDnauczyciela = 2 (ten sam przedmiot, różni nauczyciele)

    // 1) IDprzedmiotu = 3, IDnauczyciela = 4 2) IDprzedmiotu = 4, IDnauczyciela = 4 (ten sam nauczyciel, różne przedmioty)

    public class PrzedmiotNauczyciel
    {
        public int IDprzedmiotu { get; set; }
        public int IDnauczyciela { get; set; }
        public Przedmiot? Przedmiot { get; set; }
        public Nauczyciel? Nauczyciel { get; set; }
    }
}
