using APIAssignment.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAssignment.API.Controllers
{
    public interface ICarRepository
    {
        Car GetCarById(int id);

        List<Car> GetAllCars();

        void CreateNewCar(Car car);
    }
}
