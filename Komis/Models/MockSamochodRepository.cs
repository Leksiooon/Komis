using System.Collections.Generic;
using System.Linq;

namespace Komis.Models
{
    public class MockSamochodRepository : ISamochodRepository
    {
        private List<Samochod> samochody;

        public MockSamochodRepository()
        {
            if (samochody == null)
            {
                ZaladujSamochody();
            }
        }

        private void ZaladujSamochody()
        {
            samochody = new List<Samochod>
            {
                new Samochod { Id=1, Marka="Ford", Model="Mustang", RokProdukcji=2016, Przebieg = "34 000 km", Pojemnosc="4 900 cm3", RodzajPaliwa="benzyna", Moc="421 KM", Cena=2450000, Opis="Najlepszy samochód ever.", ZdjecieUrl="wwwroot/images/car1.jpg", MiniaturkaUrl="images/car1.jpg", JestSamochodemTygodnia= true },
                new Samochod { Id=2, Marka="Opel", Model="Vectra", RokProdukcji=2016, Przebieg = "34 000 km", Pojemnosc="4 900 cm3", RodzajPaliwa="benzyna", Moc="421 KM", Cena=2450000, Opis="Najlepszy samochód ever.", ZdjecieUrl="images/car2.jpg", MiniaturkaUrl="images/car2.jpg", JestSamochodemTygodnia= true },
                new Samochod { Id=3, Marka="Toyota", Model="Corolla", RokProdukcji=2016, Przebieg = "34 000 km", Pojemnosc="4 900 cm3", RodzajPaliwa="benzyna", Moc="421 KM", Cena=2450000, Opis="Najlepszy samochód ever.", ZdjecieUrl="~/images/car3.jpg", MiniaturkaUrl="images/car3.jpg", JestSamochodemTygodnia= true },
                new Samochod { Id=4, Marka="Skoda", Model="Octavia", RokProdukcji=2016, Przebieg = "34 000 km", Pojemnosc="4 900 cm3", RodzajPaliwa="benzyna", Moc="421 KM", Cena=2450000, Opis="Najlepszy samochód ever.", ZdjecieUrl="to/jest/to/miejsce.jpg", MiniaturkaUrl="images/car4.jpg", JestSamochodemTygodnia= true },
                new Samochod { Id=5, Marka="Audi", Model="A6", RokProdukcji=2016, Przebieg = "34 000 km", Pojemnosc="4 900 cm3", RodzajPaliwa="benzyna", Moc="421 KM", Cena=2450000, Opis="Najlepszy samochód ever.", ZdjecieUrl="to/jest/to/miejsce.jpg", MiniaturkaUrl="images/car5.jpg", JestSamochodemTygodnia= true },
                new Samochod { Id=6, Marka="Mercedes", Model="Benz", RokProdukcji=2016, Przebieg = "34 000 km", Pojemnosc="4 900 cm3", RodzajPaliwa="benzyna", Moc="421 KM", Cena=2450000, Opis="Najlepszy samochód ever.", ZdjecieUrl="to/jest/to/miejsce.jpg", MiniaturkaUrl="images/car6.jpg", JestSamochodemTygodnia= true }
            };
        
        }

        public Samochod PobierzSamochodOId(int samochodId)
        {
            return samochody.FirstOrDefault(s => s.Id == samochodId);
        }

        public IEnumerable<Samochod> PobierzWszystkieSamochody()
        {
            return samochody;
        }
    }
}
