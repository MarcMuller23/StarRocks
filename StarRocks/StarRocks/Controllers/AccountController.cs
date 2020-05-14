using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarRocks.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountLogic _accountLogic;

        public AccountController(IAccountLogic accountLogic)
        {
            _accountLogic = accountLogic;
        }


        //Read in CRUD
        public ActionResult Index()
        {
            var allAccounts = _accountLogic.GetAllAccounts();
            var accounts = new List<AccountViewModel>();

            foreach (var eventRegistration in allAccounts)
            {
                accounts.Add(new AccountViewModel
                {
                    //dasdasdasdasdasd
                });
            }
            return View(accounts);
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

        //Edit in CRUD
        [HttpGet]
        public ActionResult Edit()
        {
            var account = new AccountViewModel();
            _accountLogic.GetById(account);
            return View(account);
        }

        [HttpPost]
        public ActionResult Edit(AccountViewModel account)
        {
            _accountLogic.UpdateAccount(account);
            return RedirectToAction("Index");
        }

        public ActionResult AllMovies()
        {
            return View();
        }
    }
}
