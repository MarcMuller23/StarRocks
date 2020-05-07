using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Entities
{
    public interface IRole
    {
        int ID { get; set; }
        string Role_Description { get; set; }
    }
}
