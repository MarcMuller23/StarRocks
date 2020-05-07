using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces
{
    public interface ICategorie_Interest
    {
        int CategorieID { get; set; }
        int AccountID { get; set; }
        int EventPoint { get; set; }
    }
}
