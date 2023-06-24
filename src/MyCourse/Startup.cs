using System.Xml.Schema;
using System.Net.Security;
using System.Net.Mime;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCourse.Models.Services.Application;
using MyCourse.Models.Services.Infrastructure;

namespace MyCourse
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddTransient<ICourseService, AdoNetCourseService>();
            services.AddTransient<IDatabaseAccessor, SqliteDatabaseAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();

            //app.UseMvcWithDefaultRoute();
            

            // app.UseMvc(routeBuilder =>
            // {
            //     routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            // });
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                // endpoints.MapGet("/", async context =>
                // {
                //     await context.Response.WriteAsync("Hello World!");
                // });
            }); 
        }
    }
}
