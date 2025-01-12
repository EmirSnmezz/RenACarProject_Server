using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        ICarService _service;
        public CarController(ICarService carService)
        {
            _service = carService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var test = _service.GetAll();
            return Ok(test);
        }

        [HttpPost("add")]
        public IActionResult Add(Entity.Entities.Concrete.Car car)
        {
            var result = _service.Add(car);
            return Ok(result);
        }
    }
}
