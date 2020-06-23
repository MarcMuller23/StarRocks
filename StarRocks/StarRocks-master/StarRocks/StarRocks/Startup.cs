using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StarRocks.Data;
using StarRocks.Data.Entities;
using StarRocks.Data.Handlers;
using StarRocks.Data.Roles;
using StarRocks.Interfaces.Handlers;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Logic;

namespace StarRocks
{
    public class Startup
    {
        private string ConnectionString = "";
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            configuration = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
            ConnectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddTransient<ApplicationDbContext>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySQL("server=meelsnet.nl;user id=mmuller;database=mmuller_proftaak;password=Hoi123"));

            services.AddIdentity<User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddDefaultUI();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Home/Login";
                options.AccessDeniedPath = "/Home/AccessDenied";
                options.ExpireTimeSpan = TimeSpan.FromHours(10);
            });

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 3;
                options.SignIn.RequireConfirmedEmail = true;
            });

            services.AddAuthentication().AddCookie();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", p =>
                {
                    p.RequireRole(Roles.Admin);
                });
            });

            services.AddControllersWithViews();
            services.AddScoped<IAccountLogic, AccountLogic>();
            services.AddScoped<ICategoryLogic, CategoryLogic>();
            services.AddScoped<ICategory_InterestLogic, Category_InterestLogic>();
            services.AddScoped<IEventLogic, EventLogic>();
            services.AddScoped<IEventRegistrationLogic, EventRegistrationLogic>();
            services.AddScoped<INewsMessageLogic, NewsMessageLogic>();
            services.AddScoped<IReminderLogic, ReminderLogic>();
            services.AddScoped<IReviewLogic, ReviewLogic>();
            //db
            services.AddScoped<IAccountDataBaseHandler, AccountDataBaseHandler>();
            services.AddScoped<ICategoryDataBaseHandler, CatagoryDataBaseHandler>();
            services.AddScoped<ICategory_InterestDataBaseHandler, Category_InterestDataBaseHandler>();
            services.AddScoped<IEventDataBaseHandler, EventDataBaseHandler>();
            services.AddScoped<IEventRegistrationDataBaseHandler, EventRegistrationDataBaseHandler>();
            services.AddScoped<INewsMessageDataBaseHandler, NewsMessageDataBaseHandler>();
            services.AddScoped<IReminderDataBaseHandler, ReminderDataBaseHandler>();
            services.AddScoped<IReviewDataBaseHandler, ReviewDataBaseHandler>();
            services.AddScoped<IRoleDataBaseHandler, RoleDataBaseHandler>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            AccountDataBaseHandler.SetConnectionString(ConnectionString);
            CatagoryDataBaseHandler.SetConnectionString(ConnectionString);
            Category_InterestDataBaseHandler.SetConnectionString(ConnectionString);
            EventDataBaseHandler.SetConnectionString(ConnectionString);
            EventRegistrationDataBaseHandler.SetConnectionString(ConnectionString);
            NewsMessageDataBaseHandler.SetConnectionString(ConnectionString);
            ReminderDataBaseHandler.SetConnectionString(ConnectionString);
            ReviewDataBaseHandler.SetConnectionString(ConnectionString);
            RoleDataBaseHandler.SetConnectionString(ConnectionString);
        }
    }
}
