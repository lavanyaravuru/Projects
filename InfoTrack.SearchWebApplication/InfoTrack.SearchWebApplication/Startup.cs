using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoTrack.SearchServiceLayer.Interfaces;
using InfoTrack.SearchServiceLayer.Services;
using InfoTrack.SearchWebApplication.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace InfoTrack.SearchWebApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<GoogleSearchService>();
            services.AddScoped<BingSearchService>();

            // use deletegate to register various implementations of the service interface
            services.AddTransient<Func<SearchEngineTypeEnum, ISearchService>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case SearchEngineTypeEnum.Google:
                        return serviceProvider.GetService<GoogleSearchService>();
                    case SearchEngineTypeEnum.Bing:
                        return serviceProvider.GetService<BingSearchService>();
                    default:
                        return null;
                }
            });         

            services.AddMvc(options =>
            {
                options.Filters.Add(new ProducesAttribute("application/json"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger, IConfiguration configuration)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                logger.LogError("");
            }

            app.UseFileServer();
            //app.UseMvcWithDefaultRoute();
            logger.LogInformation("");
            app.UseMvc(routes =>
            {
                //set default route to Search controller index action
                routes.MapRoute("default", "{controller=Search}/{action=Index}/{id?}");
            });
        }
    }
}
