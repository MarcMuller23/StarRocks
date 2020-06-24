using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StarRocks.Data.Entities;
using StarRocks.Data.Roles;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Models;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarRocks.Controllers
{
    [Authorize(Roles = Roles.Admin)]
    public class AccountController : Controller
    {
        private readonly IAccountLogic _accountLogic;
        private readonly UserManager<User> _userManager;

        public AccountController(IAccountLogic accountLogic, UserManager<User> usermanager)
        {
            _accountLogic = accountLogic;
            _userManager = usermanager;
        }


        //Read in CRUD
        public async Task<IActionResult> Index(string id)
        {

            var user = await _userManager.GetUserAsync(User);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return NotFound();
            }

            // // GetClaimsAsync retunrs the list of user Claims
            // var userClaims = await _userManager.GetClaimsAsync(user);
            // // GetRolesAsync returns the list of user Roles
            // var userRoles = await _userManager.GetRolesAsync(user);

            var model = new AccountViewModel()
            {
                ID = user.Id,
                FirstName = user.Firstname,
                Preposition = user.Preposition,
                LastName = user.Lastname,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Street = user.Street,
                HouseNumber = user.Housenumber,
                Addition = user.Addition,
                PostalCode = user.Postalcode,
                City = user.City,
                Birthdate = user.Birthday
                // Claims = userClaims.Select(c => c.Value).ToList(),
                // Roles = userRoles
            };

            return View(model);
        }

        //Delete in CRUD
        public ActionResult Delete(int ID)
        {
            _accountLogic.DeleteAccount(ID);
            return RedirectToAction("Index");
        }

        //Create in CRUD
        [HttpGet]
        public ActionResult Create()
        {
            var accountViewModel = new AccountViewModel();
            return View(accountViewModel);
        }

        [HttpPost]
        public ActionResult Create(AccountViewModel account)
        {
            _accountLogic.CreateAccount(account);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            var user = await _userManager.GetUserAsync(User);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return NotFound();
            }

            // // GetClaimsAsync retunrs the list of user Claims
            // var userClaims = await _userManager.GetClaimsAsync(user);
            // // GetRolesAsync returns the list of user Roles
            // var userRoles = await _userManager.GetRolesAsync(user);

            var model = new AccountViewModel()
            {
                ID = user.Id,
                FirstName = user.Firstname,
                Preposition = user.Preposition,
                LastName = user.Lastname,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Street = user.Street,
                HouseNumber = user.Housenumber,
                Addition = user.Addition,
                PostalCode = user.Postalcode,
                City = user.City,
                Birthdate = user.Birthday
                // Claims = userClaims.Select(c => c.Value).ToList(),
                // Roles = userRoles
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(AccountViewModel userViewModel)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userViewModel.ID} cannot be found";
                return NotFound();
            }


            user.Firstname = userViewModel.FirstName;
            user.Preposition = userViewModel.Preposition;
            user.Lastname = userViewModel.LastName;
            user.Email = userViewModel.Email;
            user.PhoneNumber = userViewModel.PhoneNumber;
            user.Street = userViewModel.Street;
            user.Housenumber = userViewModel.HouseNumber;
            user.Addition = userViewModel.Addition;
            user.Postalcode = userViewModel.PostalCode;
            user.City = userViewModel.City;
            user.Birthday = userViewModel.Birthdate;

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Update");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View();
        }


    }
}
