using BreeceWorks.IDP.DuendeIdentityServer.Pages.Login;
using BreeceWorks.IDP.DuendeIdentityServer.Services;
using Duende.IdentityServer.Events;
using Duende.IdentityServer;
using IdentityModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using System.Security;
using Duende.IdentityServer.Services;
using static IdentityModel.OidcConstants;

namespace BreeceWorks.IDP.DuendeIdentityServer.Pages.User.Activation
{
    [SecurityHeaders]
    [AllowAnonymous]

    public class Index : PageModel
    {
        private readonly ILocalUserService _localUserService;
        private readonly IEventService _events;

        public Index(ILocalUserService localUserService,
        IEventService events)
        {
            _localUserService = localUserService ??
                throw new ArgumentNullException(nameof(localUserService));
            _events = events;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IActionResult OnGet(string securityCode)
        {
            Input = new InputModel() { SecurityCode = securityCode };

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (await _localUserService.ValidateInActiveCredentialsAsync(Input.Username, Input.Password))
                {
                    if (await _localUserService.ActivateUserAsync(Input.SecurityCode))
                    {
                        await _localUserService.SaveChangesAsync();
                        var user = await _localUserService
                            .GetUserByUserNameAsync(Input.Username);

                        await _events.RaiseAsync(new UserLoginSuccessEvent(
                            user.UserName, user.Subject, user.UserName));

                        AuthenticationProperties props = null;

                        // issue authentication cookie with subject ID and username
                        var isuser = new IdentityServerUser(user.Subject)
                        {
                            DisplayName = user.UserName
                        };

                        await HttpContext.SignInAsync(isuser, props);

                        Response.Redirect("/MfaRegistration");
                    }
                    else
                    {
                        Input.Message = "Your account couldn't be activated, " +
                            "please contact your administrator.";
                    }
                }




                return Page();
            }
            else
            {
                return Page();
            }
        }
    }
}
