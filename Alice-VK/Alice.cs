using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice_VK.Handlers;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

namespace Alice_VK
{
    public class Alice : Controller
    {
        static void Main(string[] args) => CreateWebHostBuilder(args).Build().Run();

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(srv => srv.AddRazorPages())
                .Configure(app =>
                {
                    app.UseRouting();
                    app.UseAuthorization();

                    app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });
                });

        [HttpPost("/alice")]
        public AliceResponse WebHook([FromBody] AliceRequest req)
        {
            return req.Reply("Привет");
        }
    }
}
