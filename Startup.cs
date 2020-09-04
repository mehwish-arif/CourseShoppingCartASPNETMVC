using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CouseCatalogueMVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
//using CouseCatalogueMVC.Models;

namespace CouseCatalogueMVC
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AppDBConnection")));

            //services.AddScoped<ICategoryRepository, MockCategoryRepository>();
            // services.AddScoped<ICourseRepository, MockCourseRepository>();
            services.AddScoped<ICourseRepository, EFCourseRepository>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();
            services.AddScoped<ShoppingCart>(s => ShoppingCart.GetShoppingCart(s));
            services.AddHttpContextAccessor();
            services.AddSession();
            
            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseEndpoints(endpoints =>

            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=index}/{id?}"                    
                    );
               /* endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
               */
            });
        }
    }
}
