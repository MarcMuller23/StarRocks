using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using StarRocks.Data.Entities;
using StarRocks.Data.Roles;
using StarRocks.Models;

namespace StarRocks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        [BindProperty] public UserRegisterViewModel UserRegisterViewModel { get; set; }

        public HomeController(ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _logger = logger;
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            var model = new UserLoginViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.PasswordHash, true, false);

            if (result.Succeeded)
            {
                _logger.LogInformation("User logged in.");

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("Login", "Kan niet inloggen! Email of Wachtwoord is incorrect");
            return View(model);
        }

        public IActionResult Register()
        {
            UserRegisterViewModel = new UserRegisterViewModel
            {
                RoleList = _roleManager.Roles.Where(u => u.Name != Roles.User).Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Name
                })
            };
            return View(UserRegisterViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegisterViewModel model)
        {
            if (ModelState.IsValid)
                if (await _userManager.FindByEmailAsync(model.Email) == null)
                {
                    if (!await _roleManager.RoleExistsAsync(Roles.Admin))
                        await _roleManager.CreateAsync(new IdentityRole(Roles.Admin));

                    if (!await _roleManager.RoleExistsAsync(Roles.User))
                        await _roleManager.CreateAsync(new IdentityRole(Roles.User));


                    var user = new User
                    {
                        Email = model.Email,
                        UserName = model.Email,
                        Role = model.Role,
                        EmailConfirmed = true
                    };
                   
                    var result = await _userManager.CreateAsync(user, model.PasswordHash);

                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User created met wahtwoord");

                        if (user.Role == null)
                            await _userManager.AddToRoleAsync(user, Roles.User);
                        else
                            await _userManager.AddToRoleAsync(user, model.Role);


                        await _signInManager.SignInAsync(user, false);

                        return RedirectToAction("Login", "Home");
                    }

                    ModelState.AddModelError("Register", result.Errors.Select(x => x.Description).ToString());
                    return View(model);
                }

            return View(model);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}