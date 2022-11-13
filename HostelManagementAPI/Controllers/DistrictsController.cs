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
    public class DistrictsController : ControllerBase
    {
        private IDistrictRepository districtRepository = new DistrictRepository();


        [HttpGet("GetDistrictListByProvinceId/{id}")]
        public async Task<IEnumerable<District>> GetDistrictListByProvinceId(int id) => await districtRepository.GetDistrictListByProvinceId(id);
    }
}
