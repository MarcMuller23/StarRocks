using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarRocks.Models
{
    public class EventRegistrationViewModel : IEventRegistration
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public int AccountID { get; set; }
    }
}
