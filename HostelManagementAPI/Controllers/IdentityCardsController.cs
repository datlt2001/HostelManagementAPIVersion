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
    public class IdentityCardsController : ControllerBase
    {
        private IIdentityCardRepository identityCardRepository = new IdentityCardRepository();

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIdentityCardByID(string id)
        {
            var identityCard = await identityCardRepository.GetIdentityCardByID(id);
            if (identityCard == null)
            {
                return NotFound();
            }

            return Ok(identityCard);
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> AddIdCard([FromBody] IdentityCard identityCard)
        {
            await identityCardRepository.AddIdCard(identityCard);
            return Ok(identityCard);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIdCard(string id, [FromForm] IdentityCard identityCard)
        {
            var aTmp = await identityCardRepository.GetIdentityCardByID(id);
            if (aTmp == null)
            {
                return NotFound();
            }
            await identityCardRepository.UpdateIdCard(identityCard);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var aTmp = await identityCardRepository.GetIdentityCardByID(id);
            if (aTmp == null)
            {
                return NotFound();
            }
            await identityCardRepository.DeleteIdCard(aTmp);
            return Ok();
        }
    }
}
