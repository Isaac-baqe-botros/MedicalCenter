using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Medical_Center.Models;
using Medical_Center.ViewModel;
using System.Threading.Tasks;

namespace Medical_Center.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Admin> _userManager;
        private readonly SignInManager<Admin> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<Admin> userManager, SignInManager<Admin> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var admin = new Admin { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(admin, model.Password);

                if (result.Succeeded)
                {
                    // Ensure the Admin role exists
                    var roleExists = await _roleManager.RoleExistsAsync("Admin");
                    if (!roleExists)
                    {
                        // Create the Admin role if it does not exist
                        await _roleManager.CreateAsync(new IdentityRole("Admin"));
                    }

                    // Assign the Admin role to the user
                    await _userManager.AddToRoleAsync(admin, "Admin");

                    // Sign in the user
                    await _signInManager.SignInAsync(admin, isPersistent: false);
                    return RedirectToAction(nameof(HomeController.Index), "Home");
                }

                // Add errors to the model state if creation fails
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToLocal(returnUrl);
                }
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            return View(model);
        }

        // POST: /Account/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(DashboardController.Index), "Dashboard");
            }
        }
    }
}
