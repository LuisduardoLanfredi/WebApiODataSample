using System.Collections.Generic;
using System.Linq;
using WebApiODataSample.Models;

namespace WebApiODataSample.Database
{
    public class DataSource
    {
        private static DataSource instance = null;
        public static DataSource Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataSource();

                return instance;
            }
        }

        public List<Brand> Brands { get; set; }
        public List<Car> Cars { get; set; }

        private DataSource()
        {
            Reset();
            Initialize();
        }

        private void Reset()
        {
            Brands = new List<Brand>();
            Cars = new List<Car>();
        }

        private void Initialize()
        {
            Brands.AddRange(new List<Brand>()
            {
                new Brand() { Id = 1, Name = "Chevrolet" },
                new Brand() { Id = 2, Name = "Nissan" },
                new Brand() { Id = 3, Name = "Toyota" },
                new Brand() { Id = 4, Name = "Honda" },
                new Brand() { Id = 5, Name = "Fiat" },
                new Brand() { Id = 6, Name = "Jeep" }}
            );

            Cars.AddRange(new List<Car>()
            {
                //Chevrolet
                new Car() { Id = 1, Name = "Corsa", Brand = Brands.Where(x => x.Name == "Chevrolet").SingleOrDefault() },
                new Car() { Id = 2, Name = "Malibu", Brand = Brands.Where(x => x.Name == "Chevrolet").SingleOrDefault() },
                new Car() { Id = 3, Name = "Impala", Brand = Brands.Where(x => x.Name == "Chevrolet").SingleOrDefault() },
                new Car() { Id = 4, Name = "Camaro", Brand = Brands.Where(x => x.Name == "Chevrolet").SingleOrDefault() },
                new Car() { Id = 5, Name = "Corvete", Brand = Brands.Where(x => x.Name == "Chevrolet").SingleOrDefault() },
                new Car() { Id = 6, Name = "Silverado", Brand = Brands.Where(x => x.Name == "Chevrolet").SingleOrDefault() },
                new Car() { Id = 7, Name = "Captiva", Brand = Brands.Where(x => x.Name == "Chevrolet").SingleOrDefault() },

                //Nissan
                new Car() { Id = 8, Name = "Titan", Brand = Brands.Where(x => x.Name == "Nissan").SingleOrDefault() },
                new Car() { Id = 9, Name = "Pathfinder", Brand = Brands.Where(x => x.Name == "Nissan").SingleOrDefault() },
                new Car() { Id = 10, Name = "Xterra", Brand = Brands.Where(x => x.Name == "Nissan").SingleOrDefault() },
                new Car() { Id = 11, Name = "Skyline", Brand = Brands.Where(x => x.Name == "Nissan").SingleOrDefault() },
                new Car() { Id = 12, Name = "March", Brand = Brands.Where(x => x.Name == "Nissan").SingleOrDefault() },
                new Car() { Id = 13, Name = "Versa", Brand = Brands.Where(x => x.Name == "Nissan").SingleOrDefault() },
                new Car() { Id = 14, Name = "Sentra", Brand = Brands.Where(x => x.Name == "Nissan").SingleOrDefault() },

                //Toyta
                new Car() { Id = 15, Name = "Etios", Brand = Brands.Where(x => x.Name == "Toyota").SingleOrDefault() },
                new Car() { Id = 16, Name = "Hylux", Brand = Brands.Where(x => x.Name == "Toyota").SingleOrDefault() },
                new Car() { Id = 17, Name = "Corolla", Brand = Brands.Where(x => x.Name == "Toyota").SingleOrDefault() },
                new Car() { Id = 18, Name = "Supra", Brand = Brands.Where(x => x.Name == "Toyota").SingleOrDefault() },
                new Car() { Id = 19, Name = "Rav4", Brand = Brands.Where(x => x.Name == "Toyota").SingleOrDefault() },
                new Car() { Id = 20, Name = "Lexus", Brand = Brands.Where(x => x.Name == "Toyota").SingleOrDefault() },
                new Car() { Id = 21, Name = "SW4", Brand = Brands.Where(x => x.Name == "Toyota").SingleOrDefault() },

                //Honda
                new Car() { Id = 22, Name = "Fit", Brand = Brands.Where(x => x.Name == "Honda").SingleOrDefault() },
                new Car() { Id = 23, Name = "WR-V", Brand = Brands.Where(x => x.Name == "Honda").SingleOrDefault() },
                new Car() { Id = 24, Name = "CR-V", Brand = Brands.Where(x => x.Name == "Honda").SingleOrDefault() },
                new Car() { Id = 25, Name = "HR-V", Brand = Brands.Where(x => x.Name == "Honda").SingleOrDefault() },
                new Car() { Id = 26, Name = "City", Brand = Brands.Where(x => x.Name == "Honda").SingleOrDefault() },
                new Car() { Id = 27, Name = "Civic", Brand = Brands.Where(x => x.Name == "Honda").SingleOrDefault() },
                new Car() { Id = 28, Name = "Accord", Brand = Brands.Where(x => x.Name == "Honda").SingleOrDefault() },
     
                //Fiat
                new Car() { Id = 29, Name = "Mobi", Brand = Brands.Where(x => x.Name == "Fiat").SingleOrDefault() },
                new Car() { Id = 30, Name = "Uno", Brand = Brands.Where(x => x.Name == "Fiat").SingleOrDefault() },
                new Car() { Id = 31, Name = "Argo", Brand = Brands.Where(x => x.Name == "Fiat").SingleOrDefault() },
                new Car() { Id = 32, Name = "Palio", Brand = Brands.Where(x => x.Name == "Fiat").SingleOrDefault() },
                new Car() { Id = 33, Name = "Uno", Brand = Brands.Where(x => x.Name == "Fiat").SingleOrDefault() },
                new Car() { Id = 34, Name = "500", Brand = Brands.Where(x => x.Name == "Fiat").SingleOrDefault() },
                new Car() { Id = 35, Name = "Siena", Brand = Brands.Where(x => x.Name == "Fiat").SingleOrDefault() },

                //Jeep
                new Car() { Id = 36, Name = "Compass", Brand = Brands.Where(x => x.Name == "Jeep").SingleOrDefault() },
                new Car() { Id = 37, Name = "Renegade", Brand = Brands.Where(x => x.Name == "Jeep").SingleOrDefault() },
                new Car() { Id = 38, Name = "Wrandler", Brand = Brands.Where(x => x.Name == "Jeep").SingleOrDefault() },
                new Car() { Id = 39, Name = "Cherokee", Brand = Brands.Where(x => x.Name == "Jeep").SingleOrDefault() },
                new Car() { Id = 40, Name = "Grand Cherokee", Brand = Brands.Where(x => x.Name == "Jeep").SingleOrDefault() },
                new Car() { Id = 41, Name = "Patriot", Brand = Brands.Where(x => x.Name == "Jeep").SingleOrDefault() },
                new Car() { Id = 42, Name = "Liberty", Brand = Brands.Where(x => x.Name == "Jeep").SingleOrDefault() }
            });
        }
    }
}