using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.BusinessObject;
using DataAccess;
using Microsoft.AspNetCore.Authorization;
using DataAccess.Repository;
using System.Security.Claims;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace HostelManagement.Pages.Accounts
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly HttpClient client = null;
        private string AccountApiUrl = "";

        private readonly DataAccess.HostelManagementContext _context;
        private IAccountRepository _accountRepository;
        private IIdentityCardRepository _identityCardRepository;

        public IndexModel(DataAccess.HostelManagementContext context, IAccountRepository accountRepository, IIdentityCardRepository identityCardRepository)
        {
            _context = context;
            _accountRepository = accountRepository;
            _identityCardRepository = identityCardRepository;
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            AccountApiUrl = "https://localhost:44376/api/Accounts";
        }

        public IEnumerable<Account> Account { get;set; }

        public async Task OnGetAsync(string searchUser)
        {
            Account = await _accountRepository.GetAccountList();
            IEnumerable<Account> AccountSearch = Account;
            if (!String.IsNullOrEmpty(searchUser))
            {
                Account = Account.Where(a => a.FullName.ToLower().Contains(searchUser.ToLower()) ||
                                            a.UserEmail.ToLower().Contains(searchUser.ToLower()))
                                        .ToList();
            }
            /*HttpResponseMessage response = await client.GetAsync(AccountApiUrl);
            string strData = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            Account = JsonSerializer.Deserialize<IEnumerable<Account>>(strData, options);
            IEnumerable<Account> AccountSearch = Account;
            {
                Account = Account.Where(a => a.FullName.ToLower().Contains(searchUser.ToLower()) ||
                                            a.UserEmail.ToLower().Contains(searchUser.ToLower()))
                                        .ToList();
            }*/
            if (!String.IsNullOrEmpty(searchUser))
                ViewData["searchUser"] = searchUser;
        }
        public async Task<IActionResult> OnPostDeactivate(int id)
        {
            await _accountRepository.InactivateUser(id);
            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnPostReactivate(int id)
        {
            await _accountRepository.ActivateUser(id);
            return RedirectToPage("./Index");
        }
    }
}
