using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Logic_Classes
{
    public interface ICategory_InterestLogic
    {
        void CreateCategoryInterest(ICategorie_Interest categorie_Interest);
        List<ICategorie_Interest> GetAllCategoryInterests();
        ICategorie_Interest UpdateCategoryInterest(ICategorie_Interest categorie_Interest);
        void DeleteCategoryInterest(int categorieInterestId);
        ICategorie_Interest GetById(ICategorie_Interest categorieInterest);
    }
}
