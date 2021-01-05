using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Samochody.Any())
            {
                context.AddRange(
                new Samochod { Marka = "Ford", Model = "Mustang", RokProdukcji = 2016, Przebieg = "34 000 km", Pojemnosc = "4 900 cm3", RodzajPaliwa = "benzyna", Moc = "421 KM", Cena = 2450000, Opis = "Najlepszy samochód ever.", ZdjecieUrl = "wwwroot/images/car1.jpg", MiniaturkaUrl = "images/car1.jpg", JestSamochodemTygodnia = true },
                new Samochod { Marka = "Opel", Model = "Vectra", RokProdukcji = 2016, Przebieg = "34 000 km", Pojemnosc = "4 900 cm3", RodzajPaliwa = "benzyna", Moc = "421 KM", Cena = 2450000, Opis = "Najlepszy samochód ever.", ZdjecieUrl = "images/car2.jpg", MiniaturkaUrl = "images/car2.jpg", JestSamochodemTygodnia = true },
                new Samochod { Marka = "Toyota", Model = "Corolla", RokProdukcji = 2016, Przebieg = "34 000 km", Pojemnosc = "4 900 cm3", RodzajPaliwa = "benzyna", Moc = "421 KM", Cena = 2450000, Opis = "Najlepszy samochód ever.", ZdjecieUrl = "~/images/car3.jpg", MiniaturkaUrl = "images/car3.jpg", JestSamochodemTygodnia = true },
                new Samochod { Marka = "Skoda", Model = "Octavia", RokProdukcji = 2016, Przebieg = "34 000 km", Pojemnosc = "4 900 cm3", RodzajPaliwa = "benzyna", Moc = "421 KM", Cena = 2450000, Opis = "Najlepszy samochód ever.", ZdjecieUrl = "to/jest/to/miejsce.jpg", MiniaturkaUrl = "images/car4.jpg", JestSamochodemTygodnia = true },
                new Samochod { Marka = "Audi", Model = "A6", RokProdukcji = 2016, Przebieg = "34 000 km", Pojemnosc = "4 900 cm3", RodzajPaliwa = "benzyna", Moc = "421 KM", Cena = 2450000, Opis = "Najlepszy samochód ever.", ZdjecieUrl = "to/jest/to/miejsce.jpg", MiniaturkaUrl = "images/car5.jpg", JestSamochodemTygodnia = true },
                new Samochod { Marka = "Mercedes", Model = "Benz", RokProdukcji = 2016, Przebieg = "34 000 km", Pojemnosc = "4 900 cm3", RodzajPaliwa = "benzyna", Moc = "421 KM", Cena = 2450000, Opis = "Najlepszy samochód ever.", ZdjecieUrl = "to/jest/to/miejsce.jpg", MiniaturkaUrl = "images/car6.jpg", JestSamochodemTygodnia = true }
                );
            }
            context.SaveChanges();
        }
    }
}
