
using MadPay724.Data.DatabaseContext;
using MadPay724.Data.Models.MainDB;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using NLog.Extensions.Logging;
using NLog.Web;
using ZNetCS.AspNetCore.Logging.EntityFrameworkCore;


namespace MadPay724.Payment
{
    public class Program
    {
        public static void Main(string[] args)
        {

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging((hostingContext, logging) =>
                {
                    //logging.AddNLog();
                    logging.AddEntityFramework<Log_MadPayDbContext, ExtendedLog>();
                }).ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                ;
    }
}
