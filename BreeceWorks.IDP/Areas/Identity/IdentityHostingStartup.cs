using System;
using BreeceWorks.IDP.Areas.Identity.Data;
using BreeceWorks.IDP.Contexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BreeceWorks.IDP.Areas.Identity.IdentityHostingStartup))]
namespace BreeceWorks.IDP.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration
                        .GetConnectionString("UserDbContextConnection")));

                //services.AddDefaultIdentity<ApplicationUser>(
                //    options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<UserDbContext>();


                services.AddIdentity<ApplicationUser, IdentityRole>(
                    options => options.SignIn.RequireConfirmedAccount = true)
                  .AddEntityFrameworkStores<UserDbContext>()
                  .AddDefaultTokenProviders();

            });
        }
    }
}