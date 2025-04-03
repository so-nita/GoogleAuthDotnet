using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace GoogleAuthDotnet.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AuthController : Controller
	{
		private readonly ILogger<AuthController> _logger;

		public AuthController(ILogger<AuthController> logger)
		{
			_logger = logger;
		}

		/*public IActionResult Index()
        {
            return View();
        }*/

		[HttpGet]
		public async Task Login()
		{
			await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, new AuthenticationProperties()
			{
				RedirectUri = Url.Action("GoogleResponse")
			});

		}

		public async Task<IActionResult> GoogleResponse()
		{
			var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

			if (!result.Succeeded)
			{
				return RedirectToAction("Index", "Home");
			}

			var claims = result.Principal.Identities.FirstOrDefault().Claims.Select(claim => new
			{
				claim.Issuer,
				claim.OriginalIssuer,
				claim.Type,
				claim.Value
			});

			return RedirectToAction("Privacy", "Home");
		}

		[HttpPost("signout")]
		public async Task<IActionResult> Signout()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			// await HttpContext.SignOutAsync(GoogleDefaults.AuthenticationScheme);

			return RedirectToAction("Index", "Home");
		}
	}
}
