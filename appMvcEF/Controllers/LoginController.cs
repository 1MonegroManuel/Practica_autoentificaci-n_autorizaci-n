using appMvcEF.Data;
using Microsoft.AspNetCore.Mvc;
using appMvcEF.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace appMvcEF.Controllers
{
	public class LoginController : Controller
	{
		private readonly AppDbContext _context;

		public LoginController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(User userF)
		{
			var userLogin = from usr in _context.Users
							join rolesX in _context.Rols
							on usr.RolId equals rolesX.RolId
							where usr.Email == userF.Email && usr.Password == userF.Password
							select new
							{
								UserId = usr.UserId,
								Email = usr.Email,
								Password = usr.Password,
								RolName = rolesX.RolName
							};
			if(userLogin.Count() != 0)
			{
				string rol = userLogin.First().RolName;
				string email = userLogin.First().Email;

				var claims = new List<Claim>()
				{
					new Claim(ClaimTypes.Name,"User"),
					new Claim("Email",email),
					new Claim(ClaimTypes.Role,rol)
				};

				var claimsIdentity = new ClaimsIdentity(claims, 
					CookieAuthenticationDefaults.AuthenticationScheme);

				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
					new ClaimsPrincipal(claimsIdentity));

				return RedirectToAction("Index", "Home");
			}
			else
			{
				ViewData["Message"] = "Invalid email or password";
				return View();
			}
		}
		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Index", "Login");
		}
	}
}
