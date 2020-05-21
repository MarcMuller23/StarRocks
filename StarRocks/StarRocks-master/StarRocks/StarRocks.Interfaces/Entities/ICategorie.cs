using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces
{
    public interface ICategorie
    {
        int ID { get; set; }
        int AccountID { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
