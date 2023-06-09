﻿// <auto-generated />
using System;
using BazaTestow.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BazaTestow.Migrations
{
    [DbContext(typeof(BazaTestowContext))]
    [Migration("20230508194940_BazaTestowTest")]
    partial class BazaTestowTest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BazaTestow.Entities.Nauczyciel", b =>
                {
                    b.Property<int>("IDnauczyciela")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDnauczyciela"));

                    b.Property<string>("Email")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KodPocztowy")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Miejscowosc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NumerDomu")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ulica")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("WychowawcaKlasy")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("IDnauczyciela");

                    b.ToTable("Nauczyciele");
                });

            modelBuilder.Entity("BazaTestow.Entities.Odpowiedz", b =>
                {
                    b.Property<int>("IDodpowiedzi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDodpowiedzi"));

                    b.Property<TimeSpan?>("CzasUdzielaniaOdpowiedzi")
                        .HasColumnType("time");

                    b.Property<int>("IDpytania")
                        .HasColumnType("int");

                    b.Property<int>("IDucznia")
                        .HasColumnType("int");

                    b.Property<float?>("IloscPunktow")
                        .HasColumnType("real");

                    b.Property<string>("OdpowiedzUcznia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDodpowiedzi");

                    b.HasIndex("IDpytania");

                    b.HasIndex("IDucznia");

                    b.ToTable("Odpowiedzi");
                });

            modelBuilder.Entity("BazaTestow.Entities.Przedmiot", b =>
                {
                    b.Property<int>("IDprzedmiotu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDprzedmiotu"));

                    b.Property<string>("NazwaPrzedmiotu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OpisPrzedmiotu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDprzedmiotu");

                    b.ToTable("Przedmioty");
                });

            modelBuilder.Entity("BazaTestow.Entities.PrzedmiotNauczyciel", b =>
                {
                    b.Property<int>("IDprzedmiotu")
                        .HasColumnType("int");

                    b.Property<int>("IDnauczyciela")
                        .HasColumnType("int");

                    b.HasKey("IDprzedmiotu", "IDnauczyciela");

                    b.HasIndex("IDnauczyciela");

                    b.ToTable("PrzedmiotNauczyciel");
                });

            modelBuilder.Entity("BazaTestow.Entities.Pytanie", b =>
                {
                    b.Property<int>("IDpytania")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDpytania"));

                    b.Property<int>("IDtestu")
                        .HasColumnType("int");

                    b.Property<float?>("MaksymalnaIloscPunktow")
                        .HasColumnType("real");

                    b.Property<string>("OpcjeOdpowiedzi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrawidlowaOdpowiedz")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("RodzajPytania")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TrescPytania")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("IDpytania");

                    b.HasIndex("IDtestu");

                    b.ToTable("Pytania");
                });

            modelBuilder.Entity("BazaTestow.Entities.Test", b =>
                {
                    b.Property<int>("IDtestu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDtestu"));

                    b.Property<TimeSpan?>("CzasTrwania")
                        .HasColumnType("time");

                    b.Property<DateTime?>("DataUtworzenia")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDprzedmiotu")
                        .HasColumnType("int");

                    b.Property<int?>("LiczbaPytan")
                        .HasColumnType("int");

                    b.Property<string>("NazwaTestu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IDtestu");

                    b.HasIndex("IDprzedmiotu");

                    b.ToTable("Testy");
                });

            modelBuilder.Entity("BazaTestow.Entities.Uczen", b =>
                {
                    b.Property<int>("IDucznia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDucznia"));

                    b.Property<DateTime?>("DataUrodzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Klasa")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("KodPocztowy")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Miejscowosc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NumerDomu")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ulica")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IDucznia");

                    b.ToTable("Uczniowie");
                });

            modelBuilder.Entity("BazaTestow.Entities.Wynik", b =>
                {
                    b.Property<int>("IDucznia")
                        .HasColumnType("int");

                    b.Property<int>("IDtestu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataUzyskania")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDwyniku")
                        .HasColumnType("int");

                    b.Property<int>("WynikPunktowy")
                        .HasColumnType("int");

                    b.HasKey("IDucznia", "IDtestu");

                    b.HasIndex("IDtestu");

                    b.ToTable("Wyniki");
                });

            modelBuilder.Entity("BazaTestow.Entities.Odpowiedz", b =>
                {
                    b.HasOne("BazaTestow.Entities.Pytanie", "Pytanie")
                        .WithMany("Odpowiedzi")
                        .HasForeignKey("IDpytania")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BazaTestow.Entities.Uczen", "Uczen")
                        .WithMany("Odpowiedzi")
                        .HasForeignKey("IDucznia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pytanie");

                    b.Navigation("Uczen");
                });

            modelBuilder.Entity("BazaTestow.Entities.PrzedmiotNauczyciel", b =>
                {
                    b.HasOne("BazaTestow.Entities.Nauczyciel", "Nauczyciel")
                        .WithMany("PrzedmiotyNauczyciele")
                        .HasForeignKey("IDnauczyciela")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BazaTestow.Entities.Przedmiot", "Przedmiot")
                        .WithMany("PrzedmiotyNauczyciele")
                        .HasForeignKey("IDprzedmiotu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nauczyciel");

                    b.Navigation("Przedmiot");
                });

            modelBuilder.Entity("BazaTestow.Entities.Pytanie", b =>
                {
                    b.HasOne("BazaTestow.Entities.Test", "Test")
                        .WithMany("Pytania")
                        .HasForeignKey("IDtestu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("BazaTestow.Entities.Test", b =>
                {
                    b.HasOne("BazaTestow.Entities.Przedmiot", "Przedmiot")
                        .WithMany("Testy")
                        .HasForeignKey("IDprzedmiotu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Przedmiot");
                });

            modelBuilder.Entity("BazaTestow.Entities.Wynik", b =>
                {
                    b.HasOne("BazaTestow.Entities.Test", "Test")
                        .WithMany("Wyniki")
                        .HasForeignKey("IDtestu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BazaTestow.Entities.Uczen", "Uczen")
                        .WithMany("Wyniki")
                        .HasForeignKey("IDucznia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");

                    b.Navigation("Uczen");
                });

            modelBuilder.Entity("BazaTestow.Entities.Nauczyciel", b =>
                {
                    b.Navigation("PrzedmiotyNauczyciele");
                });

            modelBuilder.Entity("BazaTestow.Entities.Przedmiot", b =>
                {
                    b.Navigation("PrzedmiotyNauczyciele");

                    b.Navigation("Testy");
                });

            modelBuilder.Entity("BazaTestow.Entities.Pytanie", b =>
                {
                    b.Navigation("Odpowiedzi");
                });

            modelBuilder.Entity("BazaTestow.Entities.Test", b =>
                {
                    b.Navigation("Pytania");

                    b.Navigation("Wyniki");
                });

            modelBuilder.Entity("BazaTestow.Entities.Uczen", b =>
                {
                    b.Navigation("Odpowiedzi");

                    b.Navigation("Wyniki");
                });
#pragma warning restore 612, 618
        }
    }
}
