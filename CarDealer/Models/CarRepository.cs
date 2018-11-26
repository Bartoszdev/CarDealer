using System.Collections.Generic;
using System.Linq;

namespace CarDealer.Models
{
    public class CarRepository : ICarRepository
    {

        private readonly AppDbContext _appDbContext;
        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> TakeAllCars()
        {
            return _appDbContext.Cars;
        }

        public Car TakeCarById(int carId)
        {
            return _appDbContext.Cars.FirstOrDefault(s => s.Id == carId);
        }
    }
}
