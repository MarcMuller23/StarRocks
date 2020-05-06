using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Entities
{
    public class Categorie_Interest
    {
        public int ID { get; set; }
        public int CategorieID { get; set; }
        public int AccountID { get; set; }
        public int EventPoint { get; set; }
    }
}
