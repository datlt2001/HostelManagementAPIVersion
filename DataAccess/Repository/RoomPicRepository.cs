using BusinessObject.BusinessObject;
using DataAccess.DAO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class RoomPicRepository : IRoomPicRepository
    {
        public async Task AddRoomPic(RoomPic RoomPic) => await RoomPicDAO.Instance.AddRoomPic(RoomPic);
        public async Task<RoomPic> GetRoomPic(int id) => await RoomPicDAO.Instance.GetRoomPic(id);
        public async Task DeleteRoomPic(RoomPic RoomPic) => await RoomPicDAO.Instance.DeleteRoomPic(RoomPic);
        public async Task<IEnumerable<RoomPic>> GetRoomPicsOfARoom(int RoomId) => await RoomPicDAO.Instance.GetRoomPicsOfARoom(RoomId);
    }
}
