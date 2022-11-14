using BusinessObject.BusinessObject;
using DataAccess;
using DataAccess.Repository;
using HostelManagementAPI.Helpers;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace HostelManagementAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            services.AddSession();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HostelManagementAPI", Version = "v1" });
            });
            services.AddMvc().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            services.AddDbContext<HostelManagementContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("HostelManagementContext")));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.AccessDeniedPath = "/AccessDenied";
                    options.LoginPath = "/Index";
                    options.LogoutPath = "/Logout";
                });
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IHostelRepository, HostelRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProvinceRepository, ProvinceRepository>();
            services.AddScoped<IDistrictRepository, DistrictRepository>();
            services.AddScoped<IWardRepository, WardRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IHostelPicRepository, HostelPicRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IRoomPicRepository, RoomPicRepository>();
            services.AddScoped<IRentRepository, RentRepository>();
            services.AddScoped<IBillRepository, BillRepository>();
            services.AddScoped<IBillDetailRepository, BillDetailRepository>();
            services.AddScoped<IRoomMemberRepository, RoomMemberRepository>();
            services.AddScoped<IIdentityCardRepository, IdentityCardRepository>();
            services.AddOptions();
            var mailsettings = Configuration.GetSection("MailSettings");
            services.Configure<MailSettings>(mailsettings);
            services.AddTransient<ISendMailService, SendMailService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HostelManagementAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/testmail", async context =>
                {

                    var sendmailservice = context.RequestServices.GetService<ISendMailService>();

                    MailContent content = new MailContent
                    {
                        To = "thanhdat3001@gmail.com",
                        Subject = "Test",
                        Body = "<p><strong>HIIIII</strong></p>"
                    };

                    await sendmailservice.SendMail(content);
                    await context.Response.WriteAsync("Send mail");
                });
            });
        }
    }
}
