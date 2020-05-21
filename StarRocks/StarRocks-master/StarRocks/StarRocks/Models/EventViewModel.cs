using StarRocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarRocks.Models
{
    public class EventViewModel : IEvent
    {
        public int ID { get; set; }
        public int AccountID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int MaxCapacity { get; set; }
    }
}
