using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace TopsyTurvyCakes.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required]
        public string EmailAddress { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            var isValidUser =
                EmailAddress == "admin@topsyturvycakes.com" && Password == "topsecret!";

            if (!isValidUser) {
                ModelState.AddModelError("","Invalid Username or password!");
            }

            if (!ModelState.IsValid) { }

            var scheme = CookieAuthenticationDefaults.AuthenticationScheme;

            var user = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, EmailAddress) }, scheme));

            return SignIn(user, scheme);
        }

        public async Task<IActionResult> OnPostLogoutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/Index");
        }
    }
}