using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.BusinessObject;
using DataAccess.Repository;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;

namespace HostelManagement.Pages.Accounts
{
    public class DeleteModel : PageModel
    {
        private readonly DataAccess.HostelManagementContext _context;
        private IAccountRepository _accountRepository;
        private readonly HttpClient client = null;
        private string AccountApiUrl = "";
        public DeleteModel(DataAccess.HostelManagementContext context, IAccountRepository accountRepository)
        {
            _context = context;
            _accountRepository = accountRepository;

            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            AccountApiUrl = "https://localhost:44376/api/Accounts/";
        }

        [BindProperty]
        public Account Account { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Account = await _accountRepository.GetAccountByID(id.Value);
            HttpResponseMessage response = await client.GetAsync(AccountApiUrl + id);
            string strData = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            Account = JsonSerializer.Deserialize<Account>(strData, options);

            if (Account == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Account = await _accountRepository.GetAccountByID(id.Value);
            HttpResponseMessage response = await client.GetAsync(AccountApiUrl + id);
            string strData = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            Account = JsonSerializer.Deserialize<Account>(strData, options);

            if (Account != null)
            {
                //_context.Accounts.Remove(Account);
                //await _context.SaveChangesAsync();
                Account.Status = 0;
                await _accountRepository.UpdateAccount(Account);

                /*var httpRequestMessage = new HttpRequestMessage();
                httpRequestMessage.Method = HttpMethod.Put;
                httpRequestMessage.RequestUri = new Uri(AccountApiUrl+ Account.UserId);
                Account.Status = 0;
                // Tạo StringContent
                string jsoncontent = JsonSerializer.Serialize(Account);
                var httpContent = new StringContent(jsoncontent, Encoding.UTF8, "application/json");
                httpRequestMessage.Content = httpContent;

                await client.SendAsync(httpRequestMessage);*/
            }

            return RedirectToPage("./Index");
        }
    }
}
