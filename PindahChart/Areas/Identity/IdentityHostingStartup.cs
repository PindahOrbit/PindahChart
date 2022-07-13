using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PindahChart.Areas.Identity.Data;
using PindahChart.Data;

[assembly: HostingStartup(typeof(PindahChart.Areas.Identity.IdentityHostingStartup))]
namespace PindahChart.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PindahChartIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PindahChartIdentityContextConnection")));

                services.AddDefaultIdentity<PindahChartUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<PindahChartIdentityContext>();
            });
        }
    }
}