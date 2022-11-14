using BusinessObject.BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Authorization;
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
    public class BillDetailsController : ControllerBase
    {
        private IBillDetailRepository _billDetailRepository = new BillDetailRepository();
        [Authorize(Roles = "Admin")]
        //GET: api/Accounts
        [HttpGet]
        public async Task<IActionResult> GetBillDetailList()
        {
            var isSuccessResult = await _billDetailRepository.GetBillDetailList();
            if (isSuccessResult == null) return BadRequest();
            return Ok(isSuccessResult);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PostBillDetail([FromForm] BillDetail billDetail)
        {
            await _billDetailRepository.AddBillDetail(billDetail);
            return Ok(billDetail);
        }
    }
}
