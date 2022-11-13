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
    public class WardsController : ControllerBase
    {
        private IWardRepository wardRepository = new WardRepository();


        [HttpGet("GetWardListByDistrictId/{id}")]
        public async Task<IEnumerable<Ward>> GetWardListByDistrictId(int id) => await wardRepository.GetWardListByDistrictId(id);

    }
}
