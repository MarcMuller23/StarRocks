using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Logic_Classes
{
    public interface ICategoryLogic
    {
        void CreateCategory(ICategorie categorie);
        List<ICategorie> GetAllCategories();
        ICategorie_Interest UpdateCategory(ICategorie categorie);
        void DeleteCategory(int categorieId);
        ICategorie GetById(ICategorie categorie);
    }
}
