using BusinessObject.BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private ILocationRepository locationRepository = new LocationRepository();

        [HttpGet]
        public async Task<IEnumerable<Location>> GetLocationsList() => await locationRepository.GetLocationsList();

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocationByID(int id)
        {
            var location = await locationRepository.GetLocationByID(id);
            if (location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> AddLocation([FromBody] Location location)
        {
            await locationRepository.AddLocation(location);
            return Ok(location);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLocation(int id, [FromForm] Location location)
        {
            var aTmp = await locationRepository.GetLocationByID(id);
            if (aTmp == null)
            {
                return NotFound();
            }
            await locationRepository.UpdateLocation(location);
            return Ok();
        }

    }
}
