using StarRocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Entities
{
    public class Event_Categorie : IEvent_Categorie
    {
        public int EventID { get; set; }
        public int CategorieID { get; set; }
    }
}
