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
    public class RoomsController : ControllerBase
    {
        private IRoomRepository repository = new RoomRepository();

        [HttpGet]
        public async Task<IEnumerable<Room>> GetRooms() => await repository.GetRoomList();

        [HttpGet("GetRoomsOfAHostel")]
        public async Task<IEnumerable<Room>> GetRoomsOfAHostel(int hostelId) => await repository.GetRoomsOfAHostel(hostelId);

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoomByID(int id)
        {
            var hostel = await repository.GetRoomByID(id);
            if (hostel == null)
            {
                return NotFound();
            }

            return Ok(hostel);
        }
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoom(int id, [FromForm] Room room)
        {
            var aTmp = await repository.GetRoomByID(id);
            if (aTmp == null)
            {
                return NotFound();
            }
            await repository.UpdateRoom(room);
            return Ok();
        }
        [Authorize]
        //PUT
        [HttpPut("ActivateRoom/{id}")]
        public async Task<IActionResult> ActivateRoom(int id)
        {
            var room = await repository.GetRoomByID(id);
            if (room == null)
            {
                return NotFound();
            }
            await repository.ActivateRoom(id);
            return Ok();
        }
        [Authorize]
        //PUT
        [HttpPut("DenyRoom/{id}")]
        public async Task<IActionResult> DenyRoom(int id)
        {
            var room = await repository.GetRoomByID(id);
            if (room == null)
            {
                return NotFound();
            }
            await repository.DenyRoom(id);
            return Ok();
        }
        [Authorize]
        //PUT
        [HttpPut("PendingRoom/{id}")]
        public async Task<IActionResult> PendingRoom(int id)
        {
            var room = await repository.GetRoomByID(id);
            if (room == null)
            {
                return NotFound();
            }
            await repository.PendingRoom(id);
            return Ok();
        }
        [Authorize]
        //POST
        [HttpPost]
        public async Task<IActionResult> AddRoom([FromBody] Room room)
        {
            room.RoomId = 0;
            await repository.AddRoom(room);
            return Ok();
        }


    }
}
