using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Program.Output("[Startup] Constructor - Called");
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Program.Output("[Startup] ConfigureServices - Called");
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime appLifetime)
        {
            // Config webapi server
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // For traced application lifetime
            appLifetime.ApplicationStarted.Register(() =>
            {
                Program.Output("[Startup] ApplicationLifetime - Started");
            });

            appLifetime.ApplicationStopping.Register(() =>
            {
                Program.Output("[Startup] ApplicationLifetime - Stopping");
            });

            appLifetime.ApplicationStopped.Register(() =>
            {
                Thread.Sleep(5 * 1000);
                Program.Output("[Startup] ApplicationLifetime - Stopped");
            });

            // For trigger stop WebHost
            var thread = new Thread(() =>
            {
                Thread.Sleep(5 * 1000);
                Program.Output("[Startup] Trigger stop WebHost");
                appLifetime.StopApplication();
            });
            thread.Start();

            // Show Configure run before application lifetime - started
            Program.Output("[Startup] Configure - Called");
        }
    }
}
