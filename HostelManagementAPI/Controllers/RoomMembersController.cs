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
    public class RoomMembersController : ControllerBase
    {
        private IRoomMemberRepository repository = new RoomMemberRepository();
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddRoomMember([FromBody] RoomMember roomMember)
        {
            await repository.AddRoomMember(roomMember);
            return Ok();
        }
        [Authorize]
        [HttpGet]
        public async Task<IEnumerable<RoomMember>> GetRoomMemberList()
        {
            return await repository.GetRoomMemberList();
        }
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoomMember(int id, [FromBody] RoomMember roomMember)
        {
            var roomMemberTmp = await repository.GetRoomMemberByID(id);
            if (roomMember == null)
            {
                return NotFound();
            }
            roomMember.RoomMemberId = roomMemberTmp.RoomMemberId;
            roomMember.RoomId = roomMemberTmp.RoomId;
            roomMember.UserEmail = roomMemberTmp.UserEmail;
            roomMember.RentId = roomMemberTmp.RentId;
            await repository.UpdateRoomMember(roomMember);
            return Ok(roomMemberTmp);
        }
        [Authorize]
        [HttpGet("{id}")]
        public async Task<RoomMember> GetRoomMemberByID(int id)
        {
            return await repository.GetRoomMemberByID(id);
        }
        [Authorize]
        [HttpGet("GetRoomMemberByEmail")]
        public async Task<RoomMember> GetRoomMemberByEmail(string email, int rentId)
        {
            return await repository.GetRoomMemberByEmail(email, rentId);
        }
    }
}
