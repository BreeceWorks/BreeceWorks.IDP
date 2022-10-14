using BreeceWorks.IDP.DuendeIdentityServer.DbContexts;
using BreeceWorks.IDP.DuendeIdentityServer.Services;
using Duende.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;


namespace BreeceWorks.IDP.DuendeIdentityServer;

internal static class HostingExtensions
{
    public static WebApplication ConfigureServices(
        this WebApplicationBuilder builder)
    {
        // configures IIS out-of-proc settings 
        builder.Services.Configure<IISOptions>(iis =>
        {
            iis.AuthenticationDisplayName = "Windows";
            iis.AutomaticAuthentication = false;
        });
        // ..or configures IIS in-proc settings
        builder.Services.Configure<IISServerOptions>(iis =>
        {
            iis.AuthenticationDisplayName = "Windows";
            iis.AutomaticAuthentication = false;
        });


        // uncomment if you want to add a UI
        builder.Services.AddRazorPages();

        builder.Services.AddScoped<IPasswordHasher<Entities.User>,
            PasswordHasher<Entities.User>>();

        builder.Services.AddScoped<ILocalUserService, LocalUserService>();

        builder.Services.AddDbContext<IdentityDbContext>(options =>
        {
            options.UseSqlite(
                builder.Configuration
                .GetConnectionString("BreeceWorksIdentityDBConnectionString"));
        });


        builder.Services.AddIdentityServer(options =>
        {
            // https://docs.duendesoftware.com/identityserver/v6/fundamentals/resources/api_scopes#authorization-based-on-scopes
            options.EmitStaticAudienceClaim = true;
        })
            .AddProfileService<LocalUserProfileService>()
            .AddInMemoryIdentityResources(Config.IdentityResources)
            .AddInMemoryApiScopes(Config.ApiScopes)
            .AddInMemoryApiResources(Config.ApiResources)
            .AddInMemoryClients(Config.Clients);

        builder.Services
             .AddAuthentication()
             .AddOpenIdConnect("AAD", "Azure Active Directory", options =>
             {
                 options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                 options.Authority = "https://login.microsoftonline.com/8d5ed9c5-d147-480d-8fcb-0203dfcbe1c1/v2.0";
                 options.ClientId = "00340bed-0245-4713-8a2f-99efd524ef5c";
                 options.ClientSecret = "eQ98Q~P7fyx4bUTNJtBhpQNKBj~_EnI9X2uZ1chQ";
                 options.ResponseType = "code";
                 options.CallbackPath = new PathString("/signin-aad/");
                 options.SignedOutCallbackPath = new PathString("/signout-aad/");
                 options.Scope.Add("email");
                 options.Scope.Add("offline_access");
                 options.SaveTokens = true;
             });

        builder.Services.AddAuthentication()
            .AddFacebook("Facebook",
               options =>
               {
                   options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                   options.AppId = "799498951329302";
                   options.AppSecret = "a9633a2d2d169f84f7a0b32a56798382";
               });




        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseSerilogRequestLogging();

        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        // uncomment if you want to add a UI
        app.UseStaticFiles();
        app.UseRouting();

        app.UseIdentityServer();

        // uncomment if you want to add a UI
        app.UseAuthorization();
        app.MapRazorPages().RequireAuthorization();

        return app;
    }
}
