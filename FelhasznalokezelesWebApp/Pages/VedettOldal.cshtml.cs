using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FelhasznalokezelesWebApp.Pages
{
    [Authorize(Roles = "Admin, Editor")]
    public class VedettOldalModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
