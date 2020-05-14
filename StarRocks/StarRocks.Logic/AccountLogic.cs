using StarRocks.Interfaces;
using StarRocks.Interfaces.Entities;
using StarRocks.Interfaces.Handlers;
using StarRocks.Logic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Logic
{
    public class AccountLogic
    {
        private readonly IAccountDataBaseHandler _accountDataBaseHandler;

        public AccountLogic(IAccountDataBaseHandler accountDataBaseHandler)
        {
            _accountDataBaseHandler = accountDataBaseHandler;
        }

        private IAccountDataBaseHandler AccountDataBaseHandler { get; }

        public void CreateEventRegistration(IAccountDataBaseHandler accountRegistration)
        {
            var _account = new Account()
            {
               
            };
            AccountDataBaseHandler.CreateAccount(_account);
        }

        public List<IAccount> GetAllEventRegistrations()
        {
            return AccountDataBaseHandler.GetAllAccounts();
        }

        public IAccount UpdateEventRegistration(IAccount account)
        {
            AccountDataBaseHandler.UpdateAccount(account);
            return account;
        }

        public void DeleteEventRegistration(int accountId)
        {
            AccountDataBaseHandler.DeleteAccount(accountId);
        }

        public IEventRegistration GetById(IAccount account)
        {
            return AccountDataBaseHandler.GetById(account);
        }
    }
}
