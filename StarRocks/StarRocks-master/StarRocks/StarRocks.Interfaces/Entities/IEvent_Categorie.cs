using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces
{
    public interface IEvent_Categorie
    {
        int EventID { get; set; }
        int CategorieID { get; set; }
    }
}
