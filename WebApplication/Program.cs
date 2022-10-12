using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .ConfigureKestrel(x => x.Limits.MaxRequestBodySize = HttpRequestConfig.RequestSizeLimitBytes)
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseIISIntegration()
                        .ConfigureAppConfiguration((hostingContext, config) =>
                        {
                            config.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath);
                            config.AddJsonFile("AppSettings.Development.json");
                            config.AddEnvironmentVariables();
                        })
                        .UseStartup<Startup>()
                        .UseSerilog();
                });
        }
    }
}