using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExploreLeeds
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<FeatureToggles>(x => new FeatureToggles
            {
                DeveloperExceptions = configuration.GetValue<bool>("FeatureToggles:DeveloperExceptions")
            });

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, FeatureToggles features)
        {

            app.UseExceptionHandler("/error.html");

            if (features.DeveloperExceptions)
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // Errpr Handling
            app.Use(async (context, next) =>
            {
                if (context.Request.Path.Value.Contains("invalid"))
                {
                    throw new Exception("ERROR!");
                }
                await next();
            });

            // MVC
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");
            });

            // Run wwwroot static webpages
            app.UseFileServer();
        }
    }
}
