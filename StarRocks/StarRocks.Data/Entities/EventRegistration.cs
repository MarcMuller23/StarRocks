using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Entities
{
    public class EventRegistration : IEventRegistration
    {
        public int EventID { get; set; }
        public int AccountID { get; set; }
    }
}
