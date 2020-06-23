using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Entities
{
   public interface IEventRegistration
    {
        int ID { get; set; }
        int EventID { get; set; }
        int AccountID { get; set; }
        int MaxCapacity { get; set; }
    }
}
