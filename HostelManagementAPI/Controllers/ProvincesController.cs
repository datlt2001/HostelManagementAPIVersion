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
    public class ProvincesController : ControllerBase
    {
        private IProvinceRepository provinceRepository = new ProvinceRepository();


        [HttpGet]
        public async Task<IEnumerable<Province>> GetProvincesList() => await provinceRepository.GetProvincesList();

    }
}
