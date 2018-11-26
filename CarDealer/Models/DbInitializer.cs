using System.Linq;

namespace CarDealer.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Cars.Any())
            {
                context.Cars.AddRange(
                    new Car {  Brand = "Ford", Model = "Mustang", Year = 2016, Mileage = "34 000 km", EngineCapacity = "4 900 cm3", Fuel = "benzyna", Power = "421 KM", Description = "Mam do sprzedania Mustanga 5.0 GT V8 421KM. Kupiony w Polskim SALONIE FORDA w Opolu jako NOWY w kwietniu 2016", Price = 160000M, UrlPhoto = "/images/fordMustang.jpg", UrlMiniature = "/images/fordMustang.jpg", CarOfTheWeek = true },
                new Car {  Brand = "Audi", Model = "S5", Year = 2013, Mileage = "112 000 km", EngineCapacity = "3 000 cm3", Fuel = "benzyna", Power = "280 KM", Description = "Do sprzedania Audi S5 z 2013 roku. Jestem właścicielem tego samochodu od ponad dwóch lat.", Price = 115000M, UrlPhoto = "/images/audiS5.jpg", UrlMiniature = "/images/audiS5.jpg", CarOfTheWeek = true },
                new Car {  Brand = "BMW", Model = "X4", Year = 2017, Mileage = "4 300 km", EngineCapacity = "1 995 cm3", Fuel = "benzyna", Power = "190 KM", Description = "BMW X4 20d xDrive. Samochód krajowy. Samochód serwisowany. Wystawiamy fakturę VAT 23%. Samochód bezwypadkowy. I właściciel.", Price = 194000M, UrlPhoto = "/images/bmvx4.jpg", UrlMiniature = "/images/bmvx4.jpg", CarOfTheWeek = true },
                new Car {  Brand = "Chevrolet", Model = "Corvette", Year = 1972, Mileage = "28 000 km", EngineCapacity = "5 700 cm3", Fuel = "benzyna", Power = "300 KM", Description = "Corvetta jest w świetnym stanie wizualnym i mechanicznym. Oczywiście jest ZAREJESTROWANA i ubezpieczona w PL.", Price = 90000M, UrlPhoto = "/images/chevroletCorvete.jpg", UrlMiniature = "/images/chevroletCorvete.jpg", CarOfTheWeek = true },
                new Car {  Brand = "Nissan", Model = "Skyline", Year = 1995, Mileage = "144 000 km", EngineCapacity = "2 500 cm3", Fuel = "benzyna", Power = "410 KM", Description = "Na sprzedaż trafia moja perełka Nissan Skyline R33.Auto z Japonii sprowadzone do Szwecji, gdzie było przez wiele lat modyfikowane, uczestniczyło w zlotach, zdobywało nagrody, samochód sponsorowany latami przez Sonax Sweden.", Price = 120000M, UrlPhoto = "/images/nissan.jpg", UrlMiniature = "/images/nissan.jpg", CarOfTheWeek = true },
                new Car {  Brand = "Jaguar", Model = "ZX", Year = 2006, Mileage = "78000 km", EngineCapacity = "5 000 cm3", Fuel = "benzyna", Power = "510 KM", Description = "Przedstawiam Państwu wyjątkowe auto jakim jest Jaguar XKR, a zwłaszcza ten egzemplarz. Jaguar XKR to ikona światowej i brytyjskiem motoryzacji, a przede wszystkim kontynuator legendarnego już Jaguara E-typa, przez wielu uważany za najpiękniejsze auto w historii motoryzacji.", Price = 200000M, UrlPhoto = "/images/jaguar.jpg", UrlMiniature = "/images/jaguar.jpg", CarOfTheWeek = true }
                );
            }
            context.SaveChanges();
        }
    }
}
