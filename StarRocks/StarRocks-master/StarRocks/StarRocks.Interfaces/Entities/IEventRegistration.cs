using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Entities
{
   public interface IEventRegistration
    {
        int ID { get; set; }
        int EventID { get; set; }
        string AccountID { get; set; }
    }
}
