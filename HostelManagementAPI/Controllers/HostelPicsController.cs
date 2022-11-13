using BusinessObject.BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HostelManagementAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostelPicsController : ControllerBase
    {
        private IHostelPicRepository repository = new HostelPicRepository();
        [HttpPost]
        public async Task<IActionResult> AddHostelPic([FromBody] HostelPic hostelPic)
        {
            hostelPic.HostelId = 0;
            await repository.AddHostelPic(hostelPic);
            return Ok();
        }
        [HttpGet]
        public async Task<IEnumerable<HostelPic>> GetHostelPicsOfAHostel(int hostelId) => await repository.GetHostelPicsOfAHostel(hostelId);

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHostelPic(int id)
        {
            HostelPic hostelPic = await repository.GetHostelPic(id);
            await repository.DeleteHostelPic(hostelPic);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<HostelPic> GetHostelPic(int id)
        {
            return await repository.GetHostelPic(id);
        }
    }
}
