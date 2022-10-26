using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Security;

namespace BreeceWorks.IDP.DuendeIdentityServer.Pages.User.ActivationCodeSent
{
    [SecurityHeaders]
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        public ViewModel ViewModel { get; set; }

        public IActionResult OnGet(string activationLink)
        {
            ViewModel = new ViewModel() { ActivationLink = SanitizeLink(activationLink) };

            return Page();
        }

        private String SanitizeLink(String url)
        {
            url = url.Replace("+", "%2B");
            return url;
        }
    }
}
