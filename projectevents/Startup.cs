using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using projectevents.Models;
using projectevents.Interfaces;
using projectevents.Data;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Authentication.Cookies;
testt uma
namespace projectevents
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
            services.AddMemoryCache();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            // services.AddApplicationInsightsTelemetry();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //services.AddDistributedMemoryCache();
            //services.AddMvc().AddSessionStateTempDataProvider();
     
            // For Setting Session Timeout
            services.AddSession(options => {
               options.Cookie.IsEssential = true;
                options.IdleTimeout = TimeSpan.FromMinutes(30);
              //  options.CookieName = ".EventCore";
            });
            services.AddMvc()
       .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            services.AddDbContext<uma_testContext>(
      options => options.UseSqlServer("name=ConnectionStrings:DatabaseConnection"));
            //services.AddDbContext<uma_testContext>(options =>options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));
            services.AddTransient<ILogin, LoginConcrete>();
            services.AddTransient<IRegistration, RegistrationConcrete>();
            services.AddTransient<IRoles, RolesConcrete>();
            services.AddTransient<ICountry, CountryConcrete>();
            services.AddTransient<IState, StateConcrete>();
            services.AddTransient<ICity, CityConcrete>();
            services.AddTransient<IBookingVenue, BookingVenueConcrete>();
            services.AddTransient<IVenue, VenueConcrete>();
            services.AddTransient<IEvent, EventConcrete>();
            services.AddTransient<IEquipment, EquipmentConcrete>();
            services.AddTransient<IEquipment, EquipmentConcrete>();
            services.AddTransient<IBookEquipment, BookEquipmentConcrete>();
            services.AddTransient<IFood, FoodConcrete>();
            services.AddTransient<IBookFood, BookFoodConcrete>();
            services.AddTransient<IBookingLight, BookingLightConcrete>();
            services.AddTransient<IFlower, FlowerConcrete>();
            services.AddTransient<IBookFlower, BookFlowerConcrete>();
            services.AddTransient<IBookingLight, BookingLightConcrete>();
            services.AddTransient<ILight, LightConcrete>();
            services.AddTransient<ITotalbilling, TotalbillingConcrete>();
            services.AddTransient<IDishtypes, DishtypesConcrete>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
               // app.UseDeveloperExceptionPage();
            }
            else
            {
              //  app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Login}/{id?}");
                routes.MapRoute(
     "MoviesByReleaseDate",
     "Walkin3/welcome/{city}/{location}",
     new { controller = "welcome", action = "Index" }
 );
            });
        }
    }
}
