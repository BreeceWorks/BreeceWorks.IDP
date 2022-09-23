// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace BreeceWorks.IDP
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
             new TestUser
             {
                 SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                 Username = "Frank",
                 Password = "password",

                 Claims = new List<Claim>
                 {
                     new Claim(JwtClaimTypes.Name, "Frank Underwood"),
                     new Claim(JwtClaimTypes.GivenName, "Frank"),
                     new Claim(JwtClaimTypes.FamilyName, "Underwood"),
                     new Claim(JwtClaimTypes.Address, "Main Road 1"),
                     new Claim(JwtClaimTypes.Email, "frank.underwood@email.com"),
                     new Claim(JwtClaimTypes.Role, "FreeUser"),
                     new Claim("subscriptionlevel", "FreeUser"),
                     new Claim("country", "nl")
                 }
             },
             new TestUser
             {
                 SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                 Username = "Claire",
                 Password = "password",

                 Claims = new List<Claim>
                 {
                     new Claim(JwtClaimTypes.Name, "Claire Underwood"),
                     new Claim(JwtClaimTypes.GivenName, "Claire"),
                     new Claim(JwtClaimTypes.FamilyName, "Underwood"),
                     new Claim(JwtClaimTypes.Address, "Big Street 2"),
                     new Claim(JwtClaimTypes.Email, "claire.underwood@email.com"),
                     new Claim(JwtClaimTypes.Role, "PayingUser"),
                     new Claim("subscriptionlevel", "PayingUser"),
                     new Claim("country", "be")
                 }
             },
             new TestUser{
                 SubjectId = "06c71238-0137-4df6-bb6a-e50e62a4a7c5", 
                 Username = "Jack", 
                 Password = "password",

                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Jack Torrance"),
                    new Claim(JwtClaimTypes.GivenName, "Jack"),
                    new Claim(JwtClaimTypes.FamilyName, "Torrance"),
                    new Claim(JwtClaimTypes.Email, "jack.torrance@email.com"),
                    new Claim(JwtClaimTypes.Role, "PayingUser"),
                    new Claim("subscriptionlevel", "PayingUser"),
                    new Claim("country", "BE")
                }
            },
            new TestUser{
                SubjectId = "37d0f2fa-1069-489f-9d65-48c9ba44639b", 
                Username = "Wendy", 
                Password = "password",

                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Wendy Torrance"),
                    new Claim(JwtClaimTypes.GivenName, "Wendy"),
                    new Claim(JwtClaimTypes.FamilyName, "Torrance"),
                    new Claim(JwtClaimTypes.Email, "wendy.torrance@email.com"),
                    new Claim(JwtClaimTypes.Role, "FreeUser"),
                    new Claim("subscriptionlevel", "FreeUser"),
                    new Claim("country", "NL")
                }
            }

         };

    }
}