using System.Collections.Generic;

namespace CarDealer.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> TakeAllCars();
        Car TakeCarById(int carId);

        void AddCar(Car car);
        void EditCar(Car car);
        void DeleteCar(Car car);
    }
}
