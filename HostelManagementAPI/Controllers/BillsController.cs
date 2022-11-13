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
    public class BillsController : ControllerBase
    {
        private IBillRepository _billRepository = new BillRepository();

        //GET: api/Accounts
        [HttpGet]
        public async Task<IActionResult> GetBillList()
        {
            var isSuccessResult = await _billRepository.GetBillList();
            if (isSuccessResult == null) return BadRequest();
            return Ok(isSuccessResult);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBillById(int id)
        {
            var bill = await _billRepository.GetBillById(id);
            if (bill == null)
            {
                return NotFound();
            }

            return Ok(bill);
        }

        [HttpPost]
        public async Task<IActionResult> PostBill([FromForm] Bill bill)
        {
            await _billRepository.AddBill(bill);
            return Ok(bill);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBill(int id, [FromForm] Bill bill)
        {
            var aTmp = await _billRepository.GetBillById(id);
            if (aTmp == null)
            {
                return NotFound();
            }
            await _billRepository.UpdateBill(bill);
            return Ok(bill);
        }

    }
}
