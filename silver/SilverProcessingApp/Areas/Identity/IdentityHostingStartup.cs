using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SilverProcessingApp.Areas.Identity.Data;
using SilverProcessingApp.Data;

[assembly: HostingStartup(typeof(SilverProcessingApp.Areas.Identity.IdentityHostingStartup))]
namespace SilverProcessingApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
               /* services.AddDbContext<SilverProcessingAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SilverProcessingAppContextConnection")));

                services.AddDefaultIdentity<SilverProcessingAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SilverProcessingAppContext>();*/
            });
        }
    }
}