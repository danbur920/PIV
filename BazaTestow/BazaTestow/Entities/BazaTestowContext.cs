using Microsoft.EntityFrameworkCore;

namespace BazaTestow.Entities
{
    public class BazaTestowContext : DbContext
    {
        public BazaTestowContext()
        {

        }

        public BazaTestowContext(DbContextOptions<BazaTestowContext> options) : base(options)
        {

        }

        public virtual DbSet<Test> Testy { get; set; }
        public virtual DbSet<Uczen> Uczniowie { get; set; }
        public virtual DbSet<Wynik> Wyniki { get; set; }
        public virtual DbSet<Przedmiot> Przedmioty { get; set; }
        public virtual DbSet<Nauczyciel> Nauczyciele { get; set; }
        public virtual DbSet<Pytanie> Pytania { get; set; }
        public virtual DbSet<Odpowiedz> Odpowiedzi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DANIEL-BURAZZO;Database=BazaTestow;Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // PrzedmiotNauczyciel (tabela pośrednicza, która pozwala na relację N:N między Przedmiotami a Nauczycielami)
            modelBuilder.Entity<PrzedmiotNauczyciel>()
                .HasKey(sc => new { sc.IDprzedmiotu, sc.IDnauczyciela });

            // Przedmiot-PrzedmiotNauczyciel 1:N
            modelBuilder.Entity<PrzedmiotNauczyciel>()
                .HasOne<Przedmiot>(p => p.Przedmiot)
                .WithMany(pn => pn.PrzedmiotyNauczyciele)
                .HasForeignKey(p => p.IDprzedmiotu);

            // Nauczyciel-PrzedmiotNauczyciel 1:N
            modelBuilder.Entity<PrzedmiotNauczyciel>()
                .HasOne<Nauczyciel>(n => n.Nauczyciel)
                .WithMany(pn => pn.PrzedmiotyNauczyciele)
                .HasForeignKey(n => n.IDnauczyciela);

            // Test-Przedmiot N:1
            modelBuilder.Entity<Test>()
                .HasOne<Przedmiot>(p => p.Przedmiot)
                .WithMany(t => t.Testy)
                .HasForeignKey(p => p.IDprzedmiotu);

            // Pytanie-Test N:1
            modelBuilder.Entity<Pytanie>()
                .HasOne<Test>(t => t.Test)
                .WithMany(p => p.Pytania)
                .HasForeignKey(t => t.IDtestu);

            //Odpowiedz-Pytanie N:1
            modelBuilder.Entity<Odpowiedz>()
                .HasOne<Pytanie>(p => p.Pytanie)
                .WithMany(o => o.Odpowiedzi)
                .HasForeignKey(p => p.IDpytania);

            //Odpowiedz-Uczen N:1
            modelBuilder.Entity<Odpowiedz>()
                .HasOne<Uczen>(u => u.Uczen)
                .WithMany(o => o.Odpowiedzi)
                .HasForeignKey(u=>u.IDucznia);

            // Wynik (tabela pośrednicza, która pozwala na relację N:N między Uczniami a Testami)
            modelBuilder.Entity<Wynik>()
                .HasKey(sc => new { sc.IDucznia, sc.IDtestu });

            //Wynik-Uczen N:1
            modelBuilder.Entity<Wynik>()
                .HasOne<Uczen>(u => u.Uczen)
                .WithMany(w => w.Wyniki)
                .HasForeignKey(u => u.IDucznia);

            //Wynik-Test N:1
            modelBuilder.Entity<Wynik>()
                .HasOne<Test>(t => t.Test)
                .WithMany(w => w.Wyniki)
                .HasForeignKey(t => t.IDtestu);
        }
    }
}
