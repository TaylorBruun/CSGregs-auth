using CSGregs.Services;
using Microsoft.AspNetCore.Mvc;
using CSGregs.Models;
using System.Collections.Generic;

namespace CSGregs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HousesController : ControllerBase
    {
        private readonly HousesService _housesService;

        public HousesController(HousesService housesService)
        {
            _housesService = housesService;
        }

        [HttpGet]
        public ActionResult<List<House>> Get()
        {
            try
            {
                List<House> houses = _housesService.Get();
                return Ok(houses);
            }
            catch (System.Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<House> Get(string id)
        {
            try
            {
                House house = _housesService.Get(id);
                return Ok(house);
            }
            catch (System.Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPost]
        public ActionResult<House> Create([FromBody] House houseData)
        {
            try
            {
                House newHouse = _housesService.Create(houseData);
                return Ok(newHouse);
            }
            catch (System.Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<House> Edit(string id, [FromBody] House houseData)
        {
            try
            {
                House editedHouse = _housesService.Edit(houseData);
                return Ok(editedHouse);
            }
            catch (System.Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<House> Delete(string id)
        {
            try
            {
                House deletedHouse = _housesService.Delete(id);
                return Ok(deletedHouse);
            }
            catch (System.Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}