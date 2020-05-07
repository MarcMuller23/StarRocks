using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Handlers
{
    public interface ICategory_InterestDataBaseHandler
    {
        List<ICategorie_Interest> GetAllCategorie_Interest();

        void CreateCategorie_Interest(ICategorie_Interest CI1);

        void UpdateCategorie_Interest(Categorie_Interest CI1);

        void DeleteCategorie_Interest(int ID);
    }
}
