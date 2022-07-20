using CSGregs.Services;
using Microsoft.AspNetCore.Mvc;
using CSGregs.Models;
using System.Collections.Generic;

namespace CSGregs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CarsController : ControllerBase
    {
        private readonly CarsService _carsService;

        public CarsController(CarsService carsService)
        {
            _carsService = carsService;
        }

        [HttpGet]
        public ActionResult<List<Car>> Get()
        {
            try
            {
                List<Car> cars = _carsService.Get();
                return Ok(cars);
            }
            catch (System.Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        // [HttpGet("{id}")]
        // public ActionResult<Car> Get(string id)
        // {
        //     try
        //     {
        //         Car car = _carsService.Get(id);
        //         return Ok(car);
        //     }
        //     catch (System.Exception exception)
        //     {
        //         return BadRequest(exception.Message);
        //     }
        // }

        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car carData)
        {
            try
            {
                Car newCar = _carsService.Create(carData);
                return Ok(newCar);
            }
            catch (System.Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        // [HttpPut("{id}")]
        // public ActionResult<Car> Edit(int id, [FromBody] Car carData)
        // {
        //     try
        //     {
        //         Car editedCar = _carsService.Edit(carData);
        //         return Ok(editedCar);
        //     }
        //     catch (System.Exception exception)
        //     {
        //         return BadRequest(exception.Message);
        //     }
        // }

        // [HttpDelete("{id}")]
        // public ActionResult<Car> Delete(string id)
        // {
        //     try
        //     {
        //         Car deletedCar = _carsService.Delete(id);
        //         return Ok(deletedCar);
        //     }
        //     catch (System.Exception exception)
        //     {
        //         return BadRequest(exception.Message);
        //     }
        // }
    }
}