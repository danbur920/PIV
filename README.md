# Programowanie IV
## Temat: Baza do przygotowywania testów sprawdzających wiedzę uczniów.

W pliku BazaTestow zamieściłem projekt z moją bazą danych. 

Informacje na temat bazy danych:

* Baza danych posiada 8 encji.
* Wykonana w podejściu CodeFirst.
* Wykorzystałem zarówno Data Annotations jak i Fluent API. Za pomocą Fluent API wykonałe relacje, a za pomocą Data Annotations ustawiłem klucze główne czy wielkości typów zmiennych.
* W folderze Entities zamieściłem wszystkie encje jak i główną klasę, dziedziczącą po DBContext - BazaTestowContext. Klasa ta zawiera między innymi nadpisaną metodę "OnConfiguring", w której zamieściłem nazwę mojego serwera, wszystkie "DbSety" czyli odpowiedniki tabel w SSMS czy też relacje między tabelami, które są zawarte w nadpisanej metodzie "OnModelCreating".
* Baza posiada relacje jeden do wielu oraz wiele do wielu - w relacji wiele do wielu wykorzystałem tabele pośredniczące.
* Wykonałem migrację wykorzystując konsolę menedżera pakietów oraz komendy: "add-migration BazaTestowTest" oraz "update-database –verbose".

Schemat bazy danych:
![Schemat bazy danych](SchematBazyDanych.PNG)
