using BusinessObject.BusinessObject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IRoomPicRepository
    {
        Task AddRoomPic(RoomPic RoomPic);
        Task<IEnumerable<RoomPic>> GetRoomPicsOfARoom(int RoomId);
        Task DeleteRoomPic(RoomPic RoomPic);
        Task<RoomPic> GetRoomPic(int id);
    }
}
