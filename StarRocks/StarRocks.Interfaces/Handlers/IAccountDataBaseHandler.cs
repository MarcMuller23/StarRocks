using System;
using System.Collections.Generic;
using System.Text;
namespace StarRocks.Interfaces.Handlers
{
    public interface IAccountDataBaseHandler
    {
        List<IAccount> GetAllAccounts();

        void CreateAccount(IAccount A1);

        void UpdateAccount(Account A1);

        void DeleteAccount(int ID);
    }
}
