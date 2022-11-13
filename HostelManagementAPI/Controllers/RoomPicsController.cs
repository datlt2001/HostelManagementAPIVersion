using BusinessObject.BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HostelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomPicsController : ControllerBase
    {
        private IRoomPicRepository repository = new RoomPicRepository();

        [HttpPost]
        public async Task<IActionResult> AddRoomPic([FromBody] RoomPic roomPic)
        {
            await repository.AddRoomPic(roomPic);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoomPic(int id)
        {
            RoomPic roomPic = await repository.GetRoomPic(id);
            await repository.DeleteRoomPic(roomPic);
            return Ok();
        }



        [HttpGet]
        public async Task<IEnumerable<RoomPic>> GetRoomPicOfARoom(int roomId)
        {
            return await repository.GetRoomPicsOfARoom(roomId);
        }
    }
}
