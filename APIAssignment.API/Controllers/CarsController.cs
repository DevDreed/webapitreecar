using APIAssignment.API.DAL;
using APIAssignment.API.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIAssignment.API.Controllers
{
    public class CarsController : ApiController
    {
        readonly ICarRepository _carRepo;

        public CarsController()
        {
            _carRepo = new CarRepository();
        }

        public CarsController(ICarRepository carRepo)
        {
            _carRepo = carRepo;
        }

        [HttpGet]
        [Route("api/car/{id}")]
        public HttpResponseMessage CarById(int id)
        {
            var car = _carRepo.GetCarById(id);
            if (car == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"The car with an id of {id} does not exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, car);
        }

        [HttpGet]
        [Route("api/car")]
        public HttpResponseMessage AllCars()
        {
            var cars = _carRepo.GetAllCars();
            if (cars.Count == 0)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"No cars returned");
            }

            return Request.CreateResponse(HttpStatusCode.OK, cars);
        }

        [HttpPost]
        [Route("api/car")]
        public HttpResponseMessage PostCar([FromBody] Car car)
        {
            _carRepo.CreateNewCar(car);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
