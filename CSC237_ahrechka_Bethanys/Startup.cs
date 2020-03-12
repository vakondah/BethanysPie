// CSC237
// Aliaksandra Hrechka
// 02/03/2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC237_ahrechka_Bethanys.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CSC237_ahrechka_Bethanys
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            // Add services that will be used inside app :
            services.AddScoped<IPieRepository, MockPieRepository>();
            services.AddScoped<ICategoryRepository, MockCategoryRepository>();
            // Support of MVC collection:
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // if statement is checking if we are running in development mode:
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // more middleware components:
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
