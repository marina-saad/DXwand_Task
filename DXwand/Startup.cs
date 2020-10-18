using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DXwand.Containers;
using DXwand.Controllers;
using DXwand.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Localization;

namespace DXwand
{
    public class Startup
    {
        private readonly IConfiguration conf;

        public Startup(IConfiguration conf)
        {
            this.conf = conf;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContextPool<dbContainer>(op => op.UseSqlServer(conf.GetConnectionString("mycon")));
            services.AddScoped<IUMessageRep, UMessageRep>();
            services.AddScoped<IRMessageRep, RMessageRep>();
            //services.AddScoped<IStringLocalizer<UMessageServiceController>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(a => a.MapDefaultControllerRoute());
             if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseEndpoints(a => a.MapControllerRoute( name:null, pattern: "api/RMesaage/{action=Getalldata}"));

            app.UseHttpsRedirection();

            app.UseRouting();

           // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
