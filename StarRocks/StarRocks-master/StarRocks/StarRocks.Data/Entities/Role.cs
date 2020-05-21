using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Entities
{
    public class Role : IRole
    {
        public int ID { get; set; }
        public string Role_Description { get; set; }
    }
}
