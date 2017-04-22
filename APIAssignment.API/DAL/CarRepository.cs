using APIAssignment.API.Controllers;
using System.Collections.Generic;
using System.Linq;
using APIAssignment.API.Models;

namespace APIAssignment.API.DAL
{
    public class CarRepository : ICarRepository
    {
        private static List<Car> cars = new List<Car>();

        public void CreateNewCar(Car car)
        {
            cars.Add(car);
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }

        public Car GetCarById(int id)
        {
            return cars.FirstOrDefault(x => x.CarId == id);
        }
    }
}