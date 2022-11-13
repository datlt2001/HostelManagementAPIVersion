using BusinessObject.BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HostelManagement.Pages.Accounts
{
    public class LoginOwnerModel : PageModel
    {
        private IAccountRepository accountRepository { get; }
        private readonly HttpClient client = null;
        private string AccountApiUrl = "";
        public LoginOwnerModel(IAccountRepository _accountRepository)
        {
            accountRepository = _accountRepository; 
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            AccountApiUrl = "https://localhost:44376/api/Accounts/Login";
        }

        [BindProperty]
        public Account Account { get; set; }
        public string message { get; set; }

        public IList<Account> Accounts { get; set; }
        public IActionResult OnGet()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/Index");
            }
            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            //Task<Account> acc = accountRepository.GetLoginAccount(Account.UserEmail, Account.UserPassword);
            var httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = HttpMethod.Post;
            httpRequestMessage.RequestUri = new Uri(AccountApiUrl);

            // Tạo StringContent
            string jsoncontent = "{\"userEmail\": \"" + Account.UserEmail + "\", \"userPassword\": \"" + Account.UserPassword + "\"}";
            var httpContent = new StringContent(jsoncontent, Encoding.UTF8, "application/json");
            httpRequestMessage.Content = httpContent;

            HttpResponseMessage response = await client.SendAsync(httpRequestMessage);
            string strData = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            Account acc = JsonSerializer.Deserialize<Account>(strData, options);

            if (acc == null)
            {
                message = "Your account or password is incorrect. Try again!";
                return Page();
            }
            else if (acc.Status != 1)
            {
                message = "Your account is locked!";
                return Page();
            }
            else if (acc.RoleName.Equals("admin"))
            {
                var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.NameIdentifier, acc.UserId.ToString()),
                            new Claim(ClaimTypes.Role, "Admin"),
                            new Claim(ClaimTypes.Name, acc.FullName),
                            new Claim(ClaimTypes.Email, acc.UserEmail)
                        };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                //HttpContext.Session.SetInt32("isLoggedIn", 1);
                //HttpContext.Session.SetString("ContactName", "Admin");
                //HttpContext.Session.SetString("ID", "admin");
                return RedirectToPage("index"); //return AdminDashboard

            }
            else if (acc.RoleName.Equals("owner"))
            {
                var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.NameIdentifier, acc.UserId.ToString()),
                            new Claim(ClaimTypes.Role, "Owner"),
                            new Claim(ClaimTypes.Name, acc.FullName),
                            new Claim(ClaimTypes.Email, acc.UserEmail)
                        };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                //HttpContext.Session.SetInt32("isLoggedIn", 1);
                //HttpContext.Session.SetString("ID", cus.Result.CustomerId);
                //HttpContext.Session.SetString("ContactName", cus.Result.ContactName);
                return RedirectToPage("../HostelOwnerDashboard");
            }
            else if (acc.RoleName.Equals("renter"))
            {
                var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.NameIdentifier, acc.UserId.ToString()),
                            new Claim(ClaimTypes.Role, "Owner"),
                            new Claim(ClaimTypes.Name, acc.FullName),
                            new Claim(ClaimTypes.Email, acc.UserEmail)
                        };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                //HttpContext.Session.SetInt32("isLoggedIn", 1);
                //HttpContext.Session.SetString("ID", cus.Result.CustomerId);
                //HttpContext.Session.SetString("ContactName", cus.Result.ContactName);
                return RedirectToPage("../HostelOwnerDashboard");

            }

            else
            {
                message = "Your account or password is incorrect. Try again!";
            }
            return Page();
        }

        public async Task<IActionResult> OnGetLogout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/Index");
        }
    }
}
