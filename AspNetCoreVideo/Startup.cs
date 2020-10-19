using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AspNetCoreVideo.Data;
using AspNetCoreVideo.Entities;
using AspNetCoreVideo.Services;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AspNetCoreVideo
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.Add(new ServiceDescriptor(typeof(IMessageService), typeof(ConfigurationMessageService), ServiceLifetime.Singleton));
            services.Add(new ServiceDescriptor(typeof(IPersonService), typeof(HardCodedPersonService), ServiceLifetime.Singleton));
            services.Add(new ServiceDescriptor(typeof(IComaxEmployeeService), typeof(HardCodedComaxEmployeeService), ServiceLifetime.Singleton));
            services.Add(new ServiceDescriptor(typeof(IVideoDataRepository), typeof(SQLVideoDataService), ServiceLifetime.Scoped));
            services.AddDbContext<VideoDbContext>(options =>
            {
                options.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
            });
           
            services.AddMvc();
            services.AddIdentity<CustomUser, IdentityRole>()
                    .AddEntityFrameworkStores<VideoDbContext>();
            //setupAction: options =>
            // {
            //     options.EnableEndpointRouting = false;

            //});
            services.Configure<RouteOptions>(config =>
            {
                config.LowercaseUrls = true;
                config.AppendTrailingSlash = true;
                config.LowercaseQueryStrings = true;
            });
            services.AddRazorPages(options =>
            {

                //options.RootDirectory = "/tuseTheProgrammer";
                //options.Conventions.AuthorizePage("/Test/Index");


            }).AddRazorRuntimeCompilation();
            //services.AddAuthorization();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();
          

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
