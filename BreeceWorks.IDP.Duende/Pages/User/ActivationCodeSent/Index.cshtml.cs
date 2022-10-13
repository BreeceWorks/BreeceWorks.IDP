using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BreeceWorks.IDP.DuendeIdentityServer.Pages.User.ActivationCodeSent
{
    [SecurityHeaders]
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
