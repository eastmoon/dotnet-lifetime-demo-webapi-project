using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Output("[Program] Start");

            Output("[Program] Create HostBuilder");
            var hostBuilder = CreateHostBuilder(args);

            Output("[Program] Build Host");
            var host = hostBuilder.Build();

            Output("[Program] Run Host");
            host.Run();

            Output("[Program] End");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices(services => {
                    Output("[Program] hostBuilder.ConfigureServices - Called");
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                         .ConfigureServices(services => {
                             Output("[Program] webBuilder.ConfigureServices - Called");
                         })
                         .Configure(app => {
                             Output("[Program] webBuilder.Configure - Called");
                         })
                         .UseStartup<Startup>();
                });

        public static void Output(string message)
        {
            Console.WriteLine($"[{DateTime.Now:yyyy/MM/dd HH:mm:ss}] {message}");
        }
    }
}
