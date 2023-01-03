using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace BreeceWorks.IDP.DuendeIdentityServer;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResource("roles",
                "Your role(s)",
                new [] { "role" }),
            new IdentityResource("country",
                "The country you're living in",
                new List<string>() { "country" })
        };

    public static IEnumerable<ApiResource> ApiResources =>
     new ApiResource[]
         {
             new ApiResource("imagegalleryapi",
                 "Image Gallery API",
                 new [] { "role", "country" })
             {
                 Scopes = { "imagegalleryapi.fullaccess",
                     "imagegalleryapi.read",
                     "imagegalleryapi.write"},
                ApiSecrets = { new Secret("apisecret".Sha256()) }
             },
             new ApiResource("breecemartapi",
                 "BreeceMart API",
                 new [] { "role", "country" })
             {
                 Scopes = { "breecemartapi.fullaccess",
                     "breecemartapi.read",
                     "breecemartapi.write"},
                ApiSecrets = { new Secret("apisecret".Sha256()) }
             }
         };


    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            {
                new ApiScope("imagegalleryapi.fullaccess"),
                new ApiScope("imagegalleryapi.read"),
                new ApiScope("imagegalleryapi.write"),
                new ApiScope("breecemartapi.fullaccess"),
                new ApiScope("breecemartapi.read"),
                new ApiScope("breecemartapi.write")};

public static IEnumerable<Client> Clients =>
        new Client[]
            {
                new Client()
                {
                    ClientName = "Image Gallery",
                    ClientId = "imagegalleryclient",
                    AllowedGrantTypes = GrantTypes.Code,
                    AccessTokenType = AccessTokenType.Reference,
                    AllowOfflineAccess = true,
                    UpdateAccessTokenClaimsOnRefresh = true,
                    AccessTokenLifetime = 120,
                    // AuthorizationCodeLifetime = ...
                    // IdentityTokenLifetime = ...
                    RedirectUris =
                    {
                        "https://localhost:7184/signin-oidc"
                    },
                    PostLogoutRedirectUris =
                    {
                        "https://localhost:7184/signout-callback-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "roles",
                        //"imagegalleryapi.fullaccess",
                        "imagegalleryapi.read",
                        "imagegalleryapi.write",
                        "country"
                    },
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    }, 
                    // RequireConsent = true
                },
                new Client()
                {
                    ClientName = "BreeceMart",
                    ClientId = "breecemartclient",
                    AllowedGrantTypes = GrantTypes.Code,
                    AccessTokenType = AccessTokenType.Reference,
                    AllowOfflineAccess = true,
                    UpdateAccessTokenClaimsOnRefresh = true,
                    AccessTokenLifetime = 120,
                    // AuthorizationCodeLifetime = ...
                    // IdentityTokenLifetime = ...
                    RedirectUris =
                    {
                        "https://localhost:7045/signin-oidc"
                    },
                    PostLogoutRedirectUris =
                    {
                        "https://localhost:7045/signout-callback-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "roles",
                        //"imagegalleryapi.fullaccess",
                        "breecemartapi.read",
                        "breecemartapi.write",
                        "country"
                    },
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    }, 
                    // RequireConsent = true
                }
            };
}