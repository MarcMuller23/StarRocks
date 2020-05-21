using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Handlers
{
    public interface ICategoryDataBaseHandler
    {
        List<ICategorie> GetAllCatagory();

        void CreateEvent(ICategorie C1);

        void UpdateEvent(ICategorie C1);

        void DeleteEvent(int ID);

        ICategorie GetById(ICategorie categorie);
    }
}
