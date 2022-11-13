using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.BusinessObject;
using DataAccess.Repository;
using DataAccess;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace HostelManagement.Pages.Accounts
{
    public class DetailsModel : PageModel
    {
        private readonly DataAccess.HostelManagementContext _context;
        private IIdentityCardRepository _identityCardRepository;
        private IAccountRepository _accountRepository;
        private readonly HttpClient client = null;
        private string AccountApiUrl = "";
        public DetailsModel(DataAccess.HostelManagementContext context, IIdentityCardRepository identityCardRepository, IAccountRepository accountRepository)
        {
            _context = context;
            _identityCardRepository = identityCardRepository;
            _accountRepository = accountRepository;

            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            AccountApiUrl = "https://localhost:44376/api/Accounts/";
        }

        public Account Account { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Account = await _accountRepository.GetAccountByID(id.Value);
            /*HttpResponseMessage response = await client.GetAsync(AccountApiUrl+id);
            string strData = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            Account = JsonSerializer.Deserialize<Account>(strData, options);

            ViewData["IdCardNumber"] = new SelectList(_context.IdentityCards, "IdCardNumber", "IdCardNumber");
            ViewData["FrontPic"] = new SelectList(_context.IdentityCards, "FrontIdPicUrl", "FrontIdPicUrl");
            ViewData["BackPic"] = new SelectList(_context.IdentityCards, "BackIdPicUrl", "BackIdPicUrl");
*/
            if (Account == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
