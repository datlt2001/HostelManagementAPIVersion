using BusinessObject.BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HostelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentsController : ControllerBase
    {
        private IRentRepository repository = new RentRepository();
        [Authorize]
        [HttpGet]
        public async Task<IEnumerable<Rent>> GetRentList() => await repository.GetRentList();
        [Authorize]
        //GET
        [HttpGet("GetRentListByRoom/{id}")]
        public async Task<IEnumerable<Rent>> GetRentListByRoom(int id) => await repository.GetRentListByRoom(id);
        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRentByID(int id)
        {
            var rent = await repository.GetRentByID(id);
            if (rent == null)
            {
                return NotFound();
            }

            return Ok(rent);
        }
        [Authorize]
        //POST: RentsController/Rents
        [HttpPost]
        public async Task<IActionResult> PostRent([FromForm] Rent rent)
        {
            await repository.AddRent(rent);
            return Ok();
        }
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRent(int id, [FromForm] Rent rent)
        {
            var aTmp = await repository.GetRentByID(id);
            if (aTmp == null)
            {
                return NotFound();
            }
            await repository.UpdateRent(rent);
            return NoContent();
        }
    }
}
