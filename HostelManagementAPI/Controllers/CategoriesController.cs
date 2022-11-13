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
    public class CategoriesController : ControllerBase
    {
        private ICategoryRepository categoryRepository = new CategoryRepository();

        [HttpGet]
        public async Task<IActionResult> GetCategoriesList()
        {
            var isSuccessResult = await categoryRepository.GetCategoriesList();
            if (isSuccessResult == null) return BadRequest();
            return Ok(isSuccessResult);
        }

    }
}
